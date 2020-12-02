using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class NormalModel
    {
        public DayOfWeek normalMonth { get; private set; }
        public int normalTime { get; private set; }
        public int normalMoney { get; private set; }

        public NormalModel()
        {
            normalMonth = DayOfWeek.Saturday;
            normalTime = 20;
            normalMoney = 1200;

        }
    }
}
