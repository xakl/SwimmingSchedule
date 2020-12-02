using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
            DateTime nowDateTime = DateTime.Now;
            numYear.Minimum = 1;
            numYear.Maximum = 9999;
            numYear.Value = nowDateTime.Year;
            numYear.Increment = 1;
            numMonth.Minimum = 1;
            numMonth.Maximum = 12;
            numMonth.Value = nowDateTime.Month;
            numMonth.Increment = 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lstCourse.Items.Add("ベビーコース");
            lstCourse.Items.Add("幼児コース");
            lstCourse.Items.Add("小学生コース");
            lstCourse.Items.Add("中学生コース");
            lstCourse.Items.Add("レディースコース");
            lstCourse.Items.Add("一般コース");
            lstCourse.Items.Add("家族コース");

        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            int selectCourse;
            // 選択したコースの取得
            selectCourse = lstCourse.SelectedIndex;

            SelectCourseJudge selectCourseJudge = new SelectCourseJudge();

            List<object> getCourseData = selectCourseJudge.CheckCourse(selectCourse);

            GetTargetDate getTargetDate = new GetTargetDate();

            List <DateTime> targetDays = getTargetDate.YearAndMonthGetter((int)numYear.Value,(int)numMonth.Value,(DayOfWeek)getCourseData[0]);

            lblTime.Text = getCourseData[1].ToString()+"時";
            lblMoney.Text = getCourseData[2].ToString()+ "円";
            DaysSeting(targetDays);
        }

        private void DaysSeting(List<DateTime> targetDays)
        {
            lblDay1.Text = targetDays[0].ToString("dd") + "日";
            lblDay2.Text = targetDays[1].ToString("dd") + "日";
            lblDay3.Text = targetDays[2].ToString("dd") + "日";
            lblDay4.Text = targetDays[3].ToString("dd") + "日";
            if (targetDays.Count == 4)
            {
                lblDay5.Text = "";
            }
            else
                lblDay5.Text = targetDays[4].ToString("dd") + "日";
        }

    }
}
