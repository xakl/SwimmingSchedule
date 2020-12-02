using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class BabyModel
    {
        public DayOfWeek BabyMonth {get; private set;}
        public int BabyTime { get; private set;}
        public int BabyMoney { get; private set; }
        
        public BabyModel()
        {
            BabyMonth = DayOfWeek.Monday;
            BabyTime = 14;
            BabyMoney = 1000;
        }

    }
}
