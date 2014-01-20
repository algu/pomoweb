using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomoweb.Domain.ViewModels
{
    public class PomoFull
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Estimate { get; set; }
        public int Pomodoros { get; set; }
    }
}
