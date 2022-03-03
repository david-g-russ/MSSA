using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void Days(int numday)
        {
            lblCCDay.Text = numday.ToString();
        }

        public void NetChange(decimal net)
        {
            lblCCNetChange.Text = net.ToString("c");
            if (net > 0)
                lblCCNetChange.ForeColor = Color.Green;
            else if (net == 0)
                lblCCNetChange.ForeColor = Color.DarkGray;
            else
                lblCCNetChange.ForeColor = Color.Red;
        }

        public void Balance(decimal bal)
        {
            lblCCbalance.Text = bal.ToString("c");
            
            if (bal > 0)
                lblCCbalance.ForeColor = Color.Green;
            else if (bal == 0)
                lblCCbalance.ForeColor = Color.DarkGray;
            else
                lblCCbalance.ForeColor = Color.Red;
        }
    }
}
