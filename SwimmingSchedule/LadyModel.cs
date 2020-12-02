using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class LadyModel
    {
        public DayOfWeek ladyMonth { get; private set; }
        public int ladyTime { get; private set; }
        public int ladyMoney { get; private set; }
        
        public LadyModel()
        {
            ladyMonth = DayOfWeek.Friday;
            ladyTime = 20;
            ladyMoney = 1000;
        }
    }
}
