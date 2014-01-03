using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Entities.Enums;

namespace pomoweb.Domain.Entities
{
    public class User
    {
        private ICollection<Pomodoro> _pomodoros;
        private ICollection<Category> _categories;

        public User()
        {
            _pomodoros = new List<Pomodoro>();
            _categories = new List<Category>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public RoleType Role { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Pomodoro> Pomodoros
        {
            get { return _pomodoros; }
            set { _pomodoros = value; }
        }

        public virtual ICollection<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
    }
}
