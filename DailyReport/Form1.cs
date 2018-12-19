using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Word;

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

            Microsoft.Office.Interop.Word.Application oDaily_report = new Microsoft.Office.Interop.Word.Application();
            Document oDaily_reportDoc = new Document();
            object oTemplate = "c:\\bin\\template\\daily_report_template.dot";
            object oSavePath = "c:\\bin\\daily_report\\";
            object oFullPath = "";
            object oReportDate_BookMark = "ReportDate";
            

            object oMissing = System.Reflection.Missing.Value;
            
            while((end_date - target_date).TotalDays > 0)
            {
                target_date = target_date.AddDays(1);
                if ((int)target_date.DayOfWeek == 6 || (int)target_date.DayOfWeek == 0)
                {
                    continue;
                }

                oDaily_report = new Microsoft.Office.Interop.Word.Application();
                oDaily_report.Visible = false;
                oDaily_reportDoc = oDaily_report.Documents.Add(ref oTemplate, ref oMissing, ref oMissing, ref oMissing);

                if (oDaily_reportDoc.Bookmarks.Exists("ReportDate"))
                {
                    oFullPath = oSavePath + "[시행세칙]일일점검양식_ver_2_" + target_date.ToString("yyyy-MM-dd") + ".docx";
                    oDaily_reportDoc.Bookmarks.get_Item(ref oReportDate_BookMark).Range.Text = target_date.ToString("yyyy년 MM월 dd일");
                    oDaily_reportDoc.SaveAs2(oFullPath, ref oMissing);
                    oDaily_report.Application.Quit(ref oMissing, ref oMissing, ref oMissing);


                    Thread.Sleep(1000);
                    File.SetCreationTime(oFullPath.ToString(), target_date);
                    File.SetLastWriteTime(oFullPath.ToString(), target_date);
                    File.SetLastAccessTime(oFullPath.ToString(), target_date);
                }

                else
                {
                    oDaily_report.Application.Quit(ref oMissing, ref oMissing, ref oMissing);
                }
            }
        }

    }
}
