using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class ElementaryStudent
    {
        public DayOfWeek elementaryStudentMonth { get; private set; }
        public int elementaryStudentTime { get; private set; }
        public int elementaryStudentMoney { get; private set; }
    
        public ElementaryStudent()
        {
            elementaryStudentMonth = DayOfWeek.Wednesday;
            elementaryStudentTime = 17;
            elementaryStudentMoney = 800;
        }
    }
}
