using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    class SelectCourseJudge
    {
        public SelectCourseJudge() { }

        public List<object> CheckCourse(int courseCheck)
        {
            DayOfWeek courseDayOfweek =  DayOfWeek.Sunday;
            int courseStartTime = 0;
            int courseMoney = 0;
            List<object> ChoiceCourse = null;
            
            switch (courseCheck)
            {
                case 0:

                    BabyModel babyModel = new BabyModel();
                    courseDayOfweek = babyModel.BabyMonth;
                    courseStartTime = babyModel.BabyTime;
                    courseMoney = babyModel.BabyMoney;
                    break;
                    
                case 1:
                    ChildModel childModel = new ChildModel();
                    courseDayOfweek = childModel.childMonth;
                    courseStartTime = childModel.childTime;
                    courseMoney = childModel.childMoney;
                    break;
                case 2:
                    ElementaryStudent elementaryStudent = new ElementaryStudent();
                    courseDayOfweek = elementaryStudent.elementaryStudentMonth;
                    courseStartTime = elementaryStudent.elementaryStudentTime;
                    courseMoney = elementaryStudent.elementaryStudentMoney;
                    break;
                case 3:
                    MiddleStudent middleStudent = new MiddleStudent();
                    courseDayOfweek = middleStudent.middleStudentMonth;
                    courseStartTime = middleStudent.middleStudentTime;
                    courseMoney = middleStudent.middleStudentMoney;
                    break;
                case 4:
                    LadyModel ladyModel = new LadyModel();
                    courseDayOfweek = ladyModel.ladyMonth;
                    courseStartTime = ladyModel.ladyTime;
                    courseMoney = ladyModel.ladyMoney;
                    break;
                case 5:
                    NormalModel normalModel = new NormalModel();
                    courseDayOfweek = normalModel.normalMonth;
                    courseStartTime = normalModel.normalTime;
                    courseMoney = normalModel.normalMoney;
                    break;
                case 6:
                    FamilyModel familyModel = new FamilyModel();
                    courseDayOfweek = familyModel.familyMonth;
                    courseStartTime = familyModel.familyTime;
                    courseMoney = familyModel.familyMoney;
                    break;
                default:
                    break;
            }
            ChoiceCourse = new List<object> { courseDayOfweek, courseStartTime, courseMoney };
            return ChoiceCourse;
        }

    }
}
