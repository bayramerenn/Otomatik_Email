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
using System.Collections;

namespace CivilEmail.UserControl
{
    public partial class Weekly : DevExpress.XtraEditors.XtraUserControl
    {
        public Weekly()
        {
            InitializeComponent();

        }

        // public bool deneme;

        private void chcPazar_CheckedChanged(object sender, EventArgs e)
        {
           Gunler.gunler = new Dictionary<string, bool>();
            Gunler.gunler.Add(chcPazar.Text, chcPazar.Checked);
            Gunler.gunler.Add(chcCumartesi.Text, chcCumartesi.Checked);
            Gunler.gunler.Add(chcCuma.Text, chcCuma.Checked);
            Gunler.gunler.Add(chcPersembe.Text, chcPersembe.Checked);
            Gunler.gunler.Add(chcCarsamba.Text, chcCarsamba.Checked);
            Gunler.gunler.Add(chcSali.Text, chcSali.Checked);
            Gunler.gunler.Add(chcPazartesi.Text, chcPazartesi.Checked);
        }

        private void Weekly_Load(object sender, EventArgs e)
        {
            
           
          
        }


    }

}
class Gunler    
{
    public static Dictionary<string, bool> gunler;

}

