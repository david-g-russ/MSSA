using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using FinanceDll;

namespace PersonalFinanceApp
{
    public partial class Calendar : Form
    {
        int month; 
        int year;
        FinanceDB repo;
        int userID;
        public Calendar(int id)
        {
            InitializeComponent();
            this.userID = id;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            repo = new FinanceDB();
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            DisplayDays(year, month);
        }

        private void DisplayDays(int year, int month)
        {
            DateTime startDay = new DateTime(year, month, 1);
            lblMonth.Text = DateTimeFormatInfo.CurrentInfo.MonthNames[month-1];
            lblYear.Text = year.ToString();
            int numDays = DateTime.DaysInMonth(year, month);
            int dayOfWeek = Convert.ToInt32(startDay.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                flwDayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= numDays; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);

                DateTime date = startDay.AddDays(i-1);
                DateTime yesterday = date.Subtract(TimeSpan.FromDays(1));

                decimal balance = repo.SumPastTransactions(userID, date);
                ucDays.Balance(balance);

                decimal netChange = balance - repo.SumPastTransactions(userID, yesterday);
                ucDays.NetChange(netChange);
                

                flwDayContainer.Controls.Add(ucDays);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flwDayContainer.Controls.Clear();
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
            DisplayDays(year, month);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            flwDayContainer.Controls.Clear();
            month--;
            if (month == 0)
            {
                month = 12;
                year--;
            }
            DisplayDays(year, month);
        }
    }
}
