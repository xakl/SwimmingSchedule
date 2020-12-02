using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class GetTargetDate
    {
        public GetTargetDate() { }

        public List<DateTime> YearAndMonthGetter(int targetYear,int targetMonth, DayOfWeek wantDayOfWeek)
        {
            int daysInMonth;
            // 月の最終日取得
            daysInMonth = DateTime.DaysInMonth(targetYear, targetMonth);

            //今月の日付を取得
            DateTime getTargetMonthOfDay = new DateTime(targetYear, targetMonth, 1);


            DateTime date;

            if (getTargetMonthOfDay.DayOfWeek == wantDayOfWeek)
            {
                date = getTargetMonthOfDay;
            }
            else
            {
                int additionalDay = ((int)(DayOfWeek.Saturday - getTargetMonthOfDay.DayOfWeek + wantDayOfWeek) % 7) + 1;
                date = getTargetMonthOfDay.AddDays(additionalDay);
            }

            // 7日ずつ日付をずらして、対象年における指定した曜日の日付を全て取得する。
            List<DateTime> days = new List<DateTime>();
            while (date.Month == targetMonth)
            {
                days.Add(date);
                date = date.AddDays(7);
            }

            return days;

        }

    }
}
