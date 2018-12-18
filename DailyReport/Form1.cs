using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
