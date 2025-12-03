using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.UI
{
    public partial class FrmNotification : Form
    {
        public FrmNotification(string message)
        {
            InitializeComponent();
            LblNotif.Text = message;
        }

        private async void FrmNotification_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20;
            this.Location = new Point(x, y);

            await Task.Delay(4000);
            this.Close();
        }
    }
}
