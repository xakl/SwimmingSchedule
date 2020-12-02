using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class MiddleStudent
    {
        public DayOfWeek middleStudentMonth { get; private set; }
        public int middleStudentTime { get; private set; }
        public int middleStudentMoney { get; private set; }

        public MiddleStudent()
        {
            middleStudentMonth = DayOfWeek.Thursday;
            middleStudentTime = 19;
            middleStudentMoney = 800;

        }
    }
}
