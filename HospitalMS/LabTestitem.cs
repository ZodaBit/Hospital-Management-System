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
    public partial class LabTestitem : DevExpress.XtraEditors.XtraForm
    {

        Labtest hp = new Labtest();
        labtestiemadd jk = new labtestiemadd();
        public LabTestitem()
        {
            InitializeComponent();
        }
        public void labelemtadd()
        {
            
            
            try
            {
                int mini = Convert.ToInt32(minimumrange.Text);
                int max = Convert.ToInt32(maximumrange.Text);
                int malemin = Convert.ToInt32(malelower.Text);
                int malemax = Convert.ToInt32(maleupper.Text);
                int femalup = Convert.ToInt32(femaleupper.Text);
                int femalelower = Convert.ToInt32(femaleupper.Text);
                int childlower = Convert.ToInt32(childrenlower.Text);
                int childuppe = Convert.ToInt32(childrenupper.Text);
                hp = jk.Labtests.Create();
                hp.TestType = testtype.Text;
                hp.TestEntity = testentity.Text;
                hp.SubEntity = subentity.Text;
                hp.MinimumRange = mini;
                hp.MaximumRange = max;
                hp.Unit = unit.Text;
                hp.Maleupper = malemax;
                hp.Malelower = malemin;
                hp.Femalelower = femalelower;
                hp.Femaleupper = femalup;
                hp.Childrenlower = childlower;
                hp.ChildrenUpper = childuppe;
                jk.Labtests.Add(hp);
                jk.SaveChanges();
                MessageBox.Show("add sucessfuly");
                testclear();
            }
            catch (Exception yu)
            {
                MessageBox.Show(yu.Message, ToString());
                testclear();
            }
        }
        public void testupdate()
        {
            try
            {
                int mini = Convert.ToInt32(minimumrange.Text);
                int max = Convert.ToInt32(maximumrange.Text);
                int malemin = Convert.ToInt32(malelower.Text);
                int malemax = Convert.ToInt32(maleupper.Text);
                int femalup = Convert.ToInt32(femaleupper.Text);
                int femalelower = Convert.ToInt32(femaleupper.Text);
                int childlower = Convert.ToInt32(childrenlower.Text);
                int childuppe = Convert.ToInt32(childrenupper.Text);
                int testid = Convert.ToInt32(testitemid.Text);
                hp = jk.Labtests.Where(c => c.LabTestID == testid).First();
                hp.TestType = testtype.Text;
                hp.TestEntity = testentity.Text;
                hp.SubEntity = subentity.Text;
                hp.MinimumRange = mini;
                hp.MaximumRange = max;
                hp.Unit = unit.Text;
                hp.Maleupper = malemax;
                hp.Malelower = malemin;
                hp.Femalelower = femalelower;
                hp.Femaleupper = femalup;
                hp.Childrenlower = childlower;
                hp.ChildrenUpper = childuppe;
                jk.SaveChanges();
                MessageBox.Show("Update sucessfuly");
                testclear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void deleteddata()
        {
            try
            {
                int testid = Convert.ToInt32(testitemid.Text);
                hp = jk.Labtests.Where(c => c.LabTestID == testid).First();
                jk.Labtests.Remove(hp);
                jk.SaveChanges();
                MessageBox.Show("Deleted sucessfuly");
                testclear();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message.ToString());
                testclear();
            }
        }
        public void testclear()
        {
            minimumrange.Text = "";
            maximumrange.Text = "";
            malelower.Text = "";
            maleupper.Text = "";
            femaleupper.Text = "";
            femaleupper.Text = "";
            childrenlower.Text = "";
            childrenupper.Text = "";
            testitemid.Text = "";
            testtype.Text = "";
            testentity.Text = "";
            subentity.Text = "";
            unit.Text = "";
            femalelower.Text = "";
        }
        private void LabTestitem_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            labelemtadd();
        }

        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            testupdate();
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            deleteddata();
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            testclear();
        }
    }
}