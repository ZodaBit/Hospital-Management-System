using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class DrugAdding : DevExpress.XtraEditors.XtraForm
    {
        public DrugAdding()
        {
            InitializeComponent();
        }
        //drugitem hh = new drugitem();
        //drugitementity ent = new drugitementity();
        
//        public void drugadd()
//        ugApplication = drugapplication.Text;
//                hh.DrugDosage = drugdosage.Text;
//                hh.DrugName = drugname.Text;
//                hh.DrugPeriod = drugperiod.Text;
//{
//            try
//            {
//                int quantity = Convert.ToInt32(drugquantity.Text);
//                hh = ent.drugitems.Create();
//                hh.DrugGroup = druggroup.Text;
//                hh.Dr                hh.DrugRefills = drugrefils.Text;
//                hh.DrugQuantity = quantity;
//                hh.DrugFrequency = drugfrequancy.Text;
//                ent.drugitems.Add(hh);
//                ent.SaveChanges();
//                MessageBox.Show("Value add Successfully ");
//                cleardrug();
//            }
//            catch (Exception ty)
//            {
//                MessageBox.Show(ty.Message.ToString());
//                cleardrug();
//            }
            
            

//        }
        //public void drugupdate()
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(ids.Text);
        //        int quantity = Convert.ToInt32(drugquantity.Text);
        //        hh = ent.drugitems.Where(p => p.ID == id).First();
        //       // hh = ent.drugitems.Create();
        //      /*  hh.DrugGroup = druggroup.Text;
        //        hh.DrugApplication = drugapplication.Text;
        //        hh.DrugDosage = drugdosage.Text;
        //        hh.DrugName = drugname.Text;
        //        hh.DrugPeriod = drugperiod.Text;
        //        hh.DrugRefills = drugrefils.Text;
        //        hh.DrugQuantity = quantity;
        //        hh.DrugFrequency = drugfrequancy.Text;
        //        ent.SaveChanges();
        //        MessageBox.Show("Value update Successfully ");
        //        cleardrug();*/
        //    }
        //    catch (Exception rt)
        //    {
        //        MessageBox.Show(rt.Message.ToString());
        //        cleardrug();
        //    }
        //}
        //public void drugremove()
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(ids.Text);
        //        hh = ent.drugitems.Where(p => p.ID == id).First();
        //        ent.drugitems.Remove(hh);
        //        ent.SaveChanges();
        //        MessageBox.Show("Value Removed Successfully ");
        //        cleardrug();
        //    }
        //    catch (Exception hg)
        //    {
        //        MessageBox.Show(hg.Message.ToString());
        //        cleardrug();
        //    }
        //}
        public void cleardrug()
        {
            druggroup.Text = "";
            drugapplication.Text = "";
            drugdosage.Text = "";
            drugname.Text ="" ;
            drugperiod.Text = "";
            drugrefils.Text= "";
            drugquantity.Text = "";
            drugfrequancy.Text = "";
            ids.Text = "";
        }
        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrugAdding_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            //drugadd();
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            //drugupdate();
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            //drugremove();
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            cleardrug();
        }
    }
}