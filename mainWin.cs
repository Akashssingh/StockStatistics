using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooFinanceApi;
using System.Windows.Forms;

namespace Project3Group16
{
    public partial class mainWin : Form
    {
        public mainWin()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (ticketCB.SelectedIndex > -1 && ticketCB.SelectedIndex < 10)
            {
                if (periodCB.SelectedIndex > -1 && periodCB.SelectedIndex < 3)
                {
                    if (startDate.Checked && endDate.Checked && DateTime.Compare(startDate.Value, endDate.Value) < 0 && DateTime.Compare(DateTime.Today.Date, endDate.Value.Date) >= 0)
                    {
                        dataForm newDataForm = new dataForm(ticketCB.SelectedIndex, periodCB.SelectedIndex, startDate.Value, endDate.Value);
                        newDataForm.ShowDialog();
                    }
                }
            }
        }
    }
}
