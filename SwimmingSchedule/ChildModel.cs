using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class ChildModel
    {
        public DayOfWeek childMonth { get; private set; }
        public int childTime { get; private set; }
        public int childMoney { get; private set; }

        public ChildModel()
        {
            childMonth = DayOfWeek.Tuesday;
            childTime = 10;
            childMoney = 1000;
        }
    }
}
