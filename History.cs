using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAppp
{
    public partial class History : Form
    {
        public History(List<string> history)
        {
            InitializeComponent();
            if (history.Count > 0)
            {
                foreach (string historyItem in history)
                {
                    lbHistory.Items.Add(historyItem);
                }
            }
            else
            {
                MessageBox.Show("The history is empty!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
