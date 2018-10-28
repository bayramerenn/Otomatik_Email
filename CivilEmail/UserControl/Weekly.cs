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
            Gunler.gunlers = new List<bool>();
            Gunler.gunler = new Dictionary<string, bool>();
            Gunler.gunler.Add(chcPazar.Text, chcPazar.Checked);
            Gunler.gunler.Add(chcCumartesi.Text, chcCumartesi.Checked);
            Gunler.gunler.Add(chcCuma.Text, chcCuma.Checked);
            Gunler.gunler.Add(chcPersembe.Text, chcPersembe.Checked);
            Gunler.gunler.Add(chcCarsamba.Text, chcCarsamba.Checked);
            Gunler.gunler.Add(chcSali.Text, chcSali.Checked);
            Gunler.gunler.Add(chcPazartesi.Text, chcPazartesi.Checked);


            //Gunler.gunlers.Add(chcPazar.Checked);
            //Gunler.gunlers.Add(chcCumartesi.Checked);
            //Gunler.gunlers.Add(chcCuma.Checked);
            //Gunler.gunlers.Add(chcPersembe.Checked);
            //Gunler.gunlers.Add(chcCarsamba.Checked);
            //Gunler.gunlers.Add(chcSali.Checked);
            //Gunler.gunlers.Add(chcPazartesi.Checked);



            //Gunler.chcPazar = chcPazar.Checked;
            //Gunler.chcCumartesi = chcCumartesi.Checked;
            //Gunler.chcCuma = chcCuma.Checked;
            //Gunler.chcPersembe = chcPersembe.Checked;
            //Gunler.chcCarsamba = chcCarsamba.Checked;
            //Gunler.chcSali = chcSali.Checked;
            //Gunler.chcPazartesi = chcPazartesi.Checked;

            
        }

        private void Weekly_Load(object sender, EventArgs e)
        {
            
           
          
        }


    }

}
class Gunler    
{
    public static List<bool> gunlers;
    public static Dictionary<string, bool> gunler;

    public static bool chcPazar { get; set; }
    public static bool chcCumartesi { get; set; }
    public static bool chcCuma { get; set; }
    public static bool chcPersembe { get; set; }
    public static bool chcCarsamba { get; set; }
    public static bool chcSali { get; set; }
    public static bool chcPazartesi { get; set; }

}

