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
    public partial class BranchForm : Form
    {
        AutoCompleteStringCollection Autodata = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();

        public BranchForm()
        {
            InitializeComponent();
            AutoComplete();
        }

 //method to fech data from the database and place data to the text fields 
        public void fechfromdatabase()
        {
            if (Idtextediter.Text == "")
            {

            }
            else
            {
                int ids = Convert.ToInt32(Idtextediter.Text);



                var popl = from z in mo.Branches where z.ID == ids select z;
                foreach (var p in popl)
                {

                    Remarkstextbox.Text = p.Remarks;
                    Descriptiontextbox.Text = p.Description;
                    Specialplacetextbox.Text = p.SpecialPlaceName;
                    Branchnametextbox.Text = p.BranchName;

                }

            }
        }
    //en

        private void AutoComplete()
        {
            Branch po = mo.Branches.Create();
            var pos = mo.Branches;
            foreach (var p in pos)
            {

                Autodata.Add(p.ID.ToString());
            }

            Idtextediter.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Idtextediter.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Idtextediter.MaskBox.AutoCompleteCustomSource = Autodata;
        }

 //method to clear the text box
        void clearbr()
        {
            Idtextediter.Text = "";
            Branchnametextbox.Text = "";
            Specialplacetextbox.Text = "";
            Descriptiontextbox.Text = "";
            Remarkstextbox.Text = "";
        }
  //method to save data to the database
        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            var branchdata = new Branch()
            {
                BranchName = Branchnametextbox.Text,
                SpecialPlaceName = Specialplacetextbox.Text,
                Description = Descriptiontextbox.Text,
                Remarks = Remarkstextbox.Text

            };
            var dbbranchbiz = new BranchBiz();
            var result = dbbranchbiz.Add(branchdata);
            if (result.Status)
            {
                MessageBox.Show("Successfuly Saved");
                clearbr();
            }

            else
                MessageBox.Show("Save Faild." + result.Message);
        }
 //Method to edit data from the database 
        private void EdittoolStripButton_Click(object sender, EventArgs e)
        {
            if (Idtextediter.Text == "")
            {
                MessageBox.Show("Please Insert Branch ID");
            }
            else
            {
                var updatebranch = new Branch()
                {

                    ID = Convert.ToInt32(Idtextediter.Text),
                    BranchName = Branchnametextbox.Text,
                    SpecialPlaceName = Specialplacetextbox.Text,
                    Description = Descriptiontextbox.Text,
                    Remarks = Remarkstextbox.Text


                };


                var upbranchBiz = new BranchBiz();
                if (MessageBox.Show("are you sure you want to Edit this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = upbranchBiz.Update(updatebranch);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Updated");
                        clearbr();
                    }
                    else
                    { MessageBox.Show("Update faild." + result.Message); }

                }

            }
        }

//Method to delete data from the database
        private void DeletetoolStripButton_Click(object sender, EventArgs e)
        {
            if (Idtextediter.Text == "")
            {
                MessageBox.Show("Please Insert Branch ID");
            }
            else
            {
                BranchBiz branchBiz = new BranchBiz();
                int deleteId = Convert.ToInt32(Idtextediter.Text);
                if (MessageBox.Show("Are you Sure you want to delete?", "Confirm deletion",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = branchBiz.Delete(deleteId);
                    if (result.Status)
                    {
                        MessageBox.Show("Successfully Deleted");
                        clearbr();
                    }

                    else
                        MessageBox.Show("Not Successfully Deleted." + result.Message);

                }
            }

        }

        private void CleartoolStripButton_Click(object sender, EventArgs e)
        {
            clearbr();
        }

        private void Branchnametextbox_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }

        private void Idtextediter_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }


       
    }
}
