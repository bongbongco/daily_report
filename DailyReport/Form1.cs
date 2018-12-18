using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace DailyReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 선택 범위 지정
            monthCalendar.SelectionStart = DateTime.Now;
            monthCalendar.SelectionEnd = DateTime.Now.AddDays(3);

            // MaxSelectionCount 디폴트 값은 7일            
            monthCalendar.MaxSelectionCount = 1;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void startDateChange_Button_Click(object sender, EventArgs e)
        {
            startDate_TextBox.Text = monthCalendar.SelectionStart.ToShortDateString();
        }

        private void endDateChange_Button_Click(object sender, EventArgs e)
        {
            endDate_TextBox.Text = monthCalendar.SelectionEnd.ToShortDateString();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DateTime start_date = DateTime.Parse(startDate_TextBox.Text);
            DateTime target_date = start_date.AddDays(-1);
            DateTime end_date = DateTime.Parse(endDate_TextBox.Text);

            object oMissing = System.Reflection.Missing.Value;
            
            while((end_date - target_date).TotalDays > 0)
            {
                target_date = target_date.AddDays(1);
                if ((int)target_date.DayOfWeek == 6 || (int)target_date.DayOfWeek == 0)
                {
                    continue;
                }
                Console.WriteLine((int)target_date.DayOfWeek);



                Word.Application daily_report;
                Word.Document daily_reportDoc;

                daily_report = new Word.Application();
                daily_report.Visible = true;
                daily_reportDoc = daily_report.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            }
        }

    }
}
