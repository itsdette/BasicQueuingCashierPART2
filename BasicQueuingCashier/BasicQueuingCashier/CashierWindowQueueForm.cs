using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            RemoveNumberQueue(CashierClass.CashierQueue);
        }

        public void RemoveNumberQueue(Queue<string> cashierQueue)
        {
            if (cashierQueue.Count > 0)  
            {
                cashierQueue.Dequeue();
            }
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(btnRefresh_Click);
            timer.Start();
        }


    }
}
