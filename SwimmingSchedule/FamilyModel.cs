using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class FamilyModel
    {
        public DayOfWeek familyMonth { get; set; }
        public int familyTime { get; set; }
        public int familyMoney { get; set; }

        public FamilyModel() 
        {
            familyMonth = DayOfWeek.Sunday;
            familyTime = 10;
            familyMoney = 1500;
        }

    }

}
