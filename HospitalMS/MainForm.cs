using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HMSSecurity.ApplySecurityToUi(this);
        }

        private void barButtonItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Front_Office frontOfficeForm = new Front_Office();
            frontOfficeForm.MdiParent = this;
            frontOfficeForm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            StaffRegistrations bgw = new StaffRegistrations();
            bgw.MdiParent = this;
            bgw.Show();

        }

        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Docters bbg = new Docters();
            bbg.MdiParent = this;
            bbg.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Charging yuyu = new Charging();
            yuyu.MdiParent = this;
            yuyu.Show();

        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            TaxType ui = new TaxType();
            ui.MdiParent = this;
            ui.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Department_Form oppo = new Department_Form();
            oppo.MdiParent = this;
            oppo.Show();
        }

        private void hideContainerRight_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            BranchForm hu = new BranchForm();
            hu.MdiParent=this;
            hu.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Docterview ju = new Docterview();
            ju.MdiParent = this;
            ju.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            possition_Form hj = new possition_Form();
            hj.MdiParent = this;
            hj.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsMdiContainer=true;
            BirthDayregistration jk = new BirthDayregistration();
            jk.MdiParent = this;
            jk.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsMdiContainer = true;
           Deathregistration bny = new Deathregistration();
           bny.MdiParent = this;
           bny.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsMdiContainer = true;
           // ItemRegistration_Form itemfrms = new ItemRegistration_Form();
           // itemfrms.MdiParent = this;
           // itemfrms.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsMdiContainer = true;
           // Roomregistration ver = new Roomregistration();
            //ver.MdiParent = this;
            //ver.Show();
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsMdiContainer = true;
            Outpaitent bb = new Outpaitent();
            bb.MdiParent = this;
            bb.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem55_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            Labratory bwwo = new Labratory();
             bwwo.Show();
        }

        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            LabreadingResult br = new LabreadingResult();
            br.Show();
        }

        private void barButtonItem68_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            Drug_Interaction hy = new Drug_Interaction();
            hy.MdiParent = this;
            hy.Show();
        }

        private void barButtonItem65_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            LabTestitem bt = new LabTestitem();
            bt.MdiParent = this;
            bt.Show();

        }

        private void barButtonItem70_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            DrugAdding hy = new DrugAdding();
            hy.MdiParent = this;
            hy.Show();
        }

        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            inpatient gt = new inpatient();
            gt.MdiParent = this;
            gt.Show();
        }

        private void barButtonItem69_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            DrugIndex hr = new DrugIndex();
            hr.MdiParent = this;
            hr.Show();
        }

        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Ultrasoundresult bb = new Ultrasoundresult();
             bb.Show();
        }

        private void barButtonItem66_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            X_rayelementadd ty = new X_rayelementadd();
            ty.MdiParent = this;
            ty.Show();

        }

        private void barButtonItem71_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem84_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
                //pictureEdit1.LoadImage();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }

        private void barButtonItem92_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.IsMdiContainer = true;
            UltrasoundReport bb = new UltrasoundReport();
            bb.MdiParent = this;
            bb.Show();
        }

        private void barButtonItem98_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Splush.ActiveForm.Close();
        }
    }
}
