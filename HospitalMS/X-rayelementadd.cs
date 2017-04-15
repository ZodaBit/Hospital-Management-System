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
    public partial class X_rayelementadd : DevExpress.XtraEditors.XtraForm
    {
        //Xrayentityadd tr = new Xrayentityadd();
        //xrayelem bb = new xrayelem();

        public X_rayelementadd()
        {
            InitializeComponent();
            
        }
        //public void xrayelementadd()
        //{
        //    try
        //    {
        //        tr = bb.Xrayentityadds.Create();
        //        tr.InvestigationType = investigationtype.Text;
        //        tr.InvestigationEntity = investentity.Text;
        //        tr.SubEntity = subentity.Text;
        //       // tr.Remarks = remark.Text;
        //        bb.Xrayentityadds.Add(tr);
        //        bb.SaveChanges();
        //        MessageBox.Show("Value add Successfully ");
        //        clerelement();
        //    }
        //    catch (Exception gt)
        //    {
        //        MessageBox.Show(gt.Message.ToString());
        //        clerelement();
        //    }
        //}
        //public void xrayelementupdate()
        //{
        //    try
        //    {
        //        int ids = Convert.ToInt32(id.Text);
        //        tr = bb.Xrayentityadds.Where(p => p.ID == ids).First();
        //        tr.InvestigationType = investigationtype.Text;
        //        tr.InvestigationEntity = investentity.Text;
        //        tr.SubEntity = subentity.Text;
        //       // tr.Remarks = remark.Text;
        //        bb.SaveChanges();
        //        MessageBox.Show("Value add Update  ");
        //        clerelement();
        //    }
        //    catch (Exception hh)
        //    {
        //        MessageBox.Show(hh.Message.ToString());
        //        clerelement();

        //    }


        //}
        //public void xrayelementrremove()
        //{
        //    try
        //    {
        //        int ids = Convert.ToInt32(id.Text);
        //        tr = bb.Xrayentityadds.Where(p => p.ID == ids).First();
        //        bb.Xrayentityadds.Remove(tr);
        //        bb.SaveChanges();
        //        MessageBox.Show("Value Removed  ");
        //        clerelement();
        //    }
        //    catch (Exception bt)
        //    {
        //        MessageBox.Show(bt.Message.ToString());
        //        clerelement();
        //    }
        //}
        public void clerelement()
        {
            investigationtype.Text = "";
            investentity.Text = "";
            subentity.Text = "";
            remark.Text = "";
            id.Text = "";
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void X_rayelementadd_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton97_Click(object sender, EventArgs e)
        {
            //xrayelementadd();
        }

        private void toolStripButton98_Click(object sender, EventArgs e)
        {
            //xrayelementupdate();
        }

        private void toolStripButton99_Click(object sender, EventArgs e)
        {
            //xrayelementrremove();
        }

        private void toolStripButton100_Click(object sender, EventArgs e)
        {
            clerelement();
        }
    }
}