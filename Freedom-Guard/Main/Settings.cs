using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freedom_Guard.Main
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            MessageBox.Show("this section not ready");
            this.Close();
        }

        private void IpaddressCustom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
