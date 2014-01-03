using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pomoweb.Domain.Entities.Enums;

namespace pomoweb.Domain.Entities
{
    public class History
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        //foreign key for pomodoro
        public Int32 PomodoroId { get; set; }
        public StatusType Status { get; set; }
        public DateTime DateTime { get; set; }
    }
}
