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
    public partial class Department_Form : Form
    {
        AutoCompleteStringCollection Autodata = new AutoCompleteStringCollection();
        AutoCompleteStringCollection Brachauto = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();

        public Department_Form()
        {
            InitializeComponent();
            AutoComplete();
            BranchAutoComplete();
        }

        public void fechfromdatabase()
        {
            if (DepartmentIdtextbox.Text == "")
            {

            }
            else
            {
                int ids = Convert.ToInt32(DepartmentIdtextbox.Text);



                var popl = from z in mo.Departments where z.ID == ids select z;
                foreach (var p in popl)
                {
                    DepNametextbox.Text = p.DepartmentName;
                    DepBranchtextbox.Text = p.Branch;
                    DepRemarkstextbox.Text = p.Remarks;


                }

            }
        }


        // autocomplete for  departement id
        private void AutoComplete()
        {
            Department po = mo.Departments.Create();
            var pos = mo.Departments;
            foreach (var p in pos)
            {

                Autodata.Add(p.ID.ToString());
            }

            DepartmentIdtextbox.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DepartmentIdtextbox.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DepartmentIdtextbox.MaskBox.AutoCompleteCustomSource = Autodata;

        }

        //autocomplete for Branch
        public void BranchAutoComplete()
        {
            HMSgeneralentity bhms = new HMSgeneralentity();
            Branch bra = bhms.Branches.Create();
            var pos = bhms.Branches;
            foreach (var p in pos)
            {

                Brachauto.Add(p.BranchName.ToString());
            }

            DepBranchtextbox.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DepBranchtextbox.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DepBranchtextbox.MaskBox.AutoCompleteCustomSource = Brachauto;
        }
        void clearbr()
        {
            DepartmentIdtextbox.Text = "";
            DepNametextbox.Text = "";
            DepBranchtextbox.Text = "";
            DepRemarkstextbox.Text = "";
        }
  //save data to the database in department table
        private void SavetoolStripButton_Click(object sender, EventArgs e)
        {
            var depodata = new Department()
            {

                DepartmentName = DepNametextbox.Text,
                Branch = DepBranchtextbox.Text,
                Remarks = DepRemarkstextbox.Text


            };
            var dbDepobiz = new DepartmentBiz();
            var result = dbDepobiz.Add(depodata);
            if (result.Status)
            {
                MessageBox.Show("Successfuly Saved");
                clearbr();
            }

            else
                MessageBox.Show("Save Faild." + result.Message);
        }
        //method edit data to the database 
        private void EdittoolStripButton_Click(object sender, EventArgs e)
        {
            if (DepartmentIdtextbox.Text == "")
            {
                MessageBox.Show("Please Insert Department ID ");
            }
            else
            {
                var updatdepo = new Department()
                {
                    ID = Convert.ToInt32(DepartmentIdtextbox.Text),
                    DepartmentName = DepNametextbox.Text,
                    Branch = DepBranchtextbox.Text,
                    Remarks = DepRemarkstextbox.Text

                };


                var updepobiz = new DepartmentBiz();
                if (MessageBox.Show("are you sure you want to Edit this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    var result = updepobiz.Update(updatdepo);

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
//method delete data from z database 
        private void DeletetoolStripButton_Click(object sender, EventArgs e)
        {
            if (DepartmentIdtextbox.Text == "")
            {
                MessageBox.Show("please insert departement id ");
            }
            else
            {
                DepartmentBiz depobiz = new DepartmentBiz();
                int deleteId = Convert.ToInt32(DepartmentIdtextbox.Text);
                if (MessageBox.Show("Are you Sure you want to delete?", "Confirm deletion",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = depobiz.Delete(deleteId);
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

        private void DepNametextbox_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }
      


    }
}
