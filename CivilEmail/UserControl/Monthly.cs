using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CivilEmail.UserControl
{
    public partial class Monthly : DevExpress.XtraEditors.XtraUserControl
    {
        public Monthly()
        {
            InitializeComponent();
        }

        private void chcHekikinci_CheckedChanged(object sender, EventArgs e)
        {
            if (chcHekikinci.Checked == true)
            {
                
                seAydaBir.Enabled = false;
                seGunu.Enabled = false;

                seAydaBirikinci.Enabled = true;
                cmdZaman.Enabled = true;
                cmdGun.Enabled = true;

                chcHerilk.Checked = false;
            }
            else
            {
                chcHekikinci.Checked = false;
                
            }
        }

        private void chcHerilk_CheckedChanged(object sender, EventArgs e)
        {
            if (chcHerilk.Checked == true)
            {
               
                cmdGun.Enabled = false;
                cmdZaman.Enabled = false;
                seAydaBirikinci.Enabled = false;

                seAydaBir.Enabled = true;
                seGunu.Enabled = true;

                chcHekikinci.Checked = false;
            }
            else
            {
                chcHerilk.Checked = false;
             
            }
        }
    }
}
