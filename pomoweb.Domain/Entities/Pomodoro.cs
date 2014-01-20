using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Domain.Entities
{
    public class Pomodoro
    {
        private ICollection<History> _histories;

        public Pomodoro()
        {
            _histories = new List<History>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public Int32 Estimate { get; set; }
        //foreign key for User
        public Int32 UserId { get; set; }
        //foreign key for Category (allow null)
        public Int32? CategoryId { get; set; }

        //navigation 
        public virtual User User { get; set; }
        //navigation
        public virtual Category Category { get; set; }
        //navigation
        public virtual ICollection<History> Histories
        {
            get { return _histories; }
            set { _histories = value; }
        }
    }
}
