using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pomoweb.ViewModels.Enums;

namespace pomoweb.ViewModels
{
    public class PomoDetails
    {
            public PomoFull PomoFull { get; set; }
            public List<HistoryView> HistoryViews { get; set; }
    }
}
