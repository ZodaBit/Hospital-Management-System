using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HospitalMS
{
    public partial class Xrayreports : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrayreports()
        {
            InitializeComponent();
        }
        HMSgeneralentity hgen = new HMSgeneralentity();
        private void topMarginBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            
        }

    }
}
