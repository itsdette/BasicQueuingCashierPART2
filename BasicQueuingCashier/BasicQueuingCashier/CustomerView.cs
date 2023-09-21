using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Refresh);
            timer.Start();
        }

        private void Refresh(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblPosition.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblPosition.Text = "No Customer.";
            }
        }
    }
}
