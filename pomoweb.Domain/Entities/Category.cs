using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Domain.Entities
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public string Name { get; set; }
        //foreign key for User
        public Int32? UserId { get; set; }
        //navigation for user
        public virtual User User { get; set; }
    }
}
