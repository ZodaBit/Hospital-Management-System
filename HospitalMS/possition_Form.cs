using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class possition_Form : Form
    {
        AutoCompleteStringCollection autodata = new AutoCompleteStringCollection();
        AutoCompleteStringCollection autodepartment = new AutoCompleteStringCollection();
        AutoCompleteStringCollection Brachauto = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();

        public possition_Form()
        {
            InitializeComponent();
            AutoComplete();
            DepoAutoComplete();
            BranchAutoComplete();
        }


        public void AutoComplete()
        {
            Possition po = mo.Possitions.Create();
            var pos = mo.Possitions;
            foreach (var p in pos)
            {
                autodata.Add(p.ID.ToString());
            }
            psitionidtext.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            psitionidtext.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            psitionidtext.MaskBox.AutoCompleteCustomSource = autodata;
        }

        //auto complete for  departemnt name
        public void DepoAutoComplete()
        {
            HMSgeneralentity hmsd = new HMSgeneralentity();
            Department dps = hmsd.Departments.Create();
            var pos = hmsd.Departments;
            foreach (var p in pos)
            {

                autodepartment.Add(p.DepartmentName.ToString());
            }

            textEdit4.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEdit4.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEdit4.MaskBox.AutoCompleteCustomSource = autodepartment;
        }
        //auto complete for branch
        public void BranchAutoComplete()
        {
            HMSgeneralentity bhms = new HMSgeneralentity();
            Branch bra = bhms.Branches.Create();
            var pos = bhms.Branches;
            foreach (var p in pos)
            {

                Brachauto.Add(p.BranchName.ToString());
            }

            textEdit3.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textEdit3.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textEdit3.MaskBox.AutoCompleteCustomSource = Brachauto;
        }
// method for feaching data from the database 
        public void fechfromdatabase()
        {
            if (psitionidtext.Text == "")
            {

            }
            else
            {
                int ids = Convert.ToInt32(psitionidtext.Text);


                Possition cm = mo.Possitions.Create();
                var popl = from z in mo.Possitions where z.ID == ids select z;
                foreach (var p in popl)
                {

                    textEdit4.Text = p.Department;
                    textEdit3.Text = p.Branch;
                    textEdit2.Text = p.PossitionName;
                    textEdit1.Text = p.Remarks;
                }

            }
        }

//method clear the text filds
        void clearpo()
        {
            psitionidtext.Text = "";
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";

        }
 // method for saving data to the database 
        private void SavetoolStripButton45_Click(object sender, EventArgs e)
        {
            var possitons = new Possition()
            {
                Department = textEdit4.Text,
                Branch = textEdit3.Text,
                PossitionName = textEdit2.Text,
                Remarks = textEdit1.Text

            };
            var PossitionBiz = new PossitionsBiz();
            var result = PossitionBiz.Add(possitons);

            if (result.Status)
            {
                MessageBox.Show("Successfully saved.");
                clearpo();
            }

            else
                MessageBox.Show("Save failed. " + result.Message); 

        }
//method for editing data from the database 
        private void EdittoolStripButton46_Click(object sender, EventArgs e)
        {
            if (psitionidtext.Text == "")
            {
                MessageBox.Show("Please Insert Possition ID");
            }
            else
            {
                var updatpossition = new Possition()
                {
                    ID = Convert.ToInt32(psitionidtext.Text),
                    Department = textEdit4.Text,
                    Branch = textEdit3.Text,
                    PossitionName = textEdit2.Text,
                    Remarks = textEdit1.Text
                };

                var uppossitionBiz = new PossitionsBiz();
                if (MessageBox.Show("are you sure you want to Edit this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = uppossitionBiz.Update(updatpossition);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Updated");
                        clearpo();
                    }
                    else
                    { MessageBox.Show("Update faild." + result.Message); }

                }
            }
        }
//Mthod for deleting data from the database 
        private void DeletdtoolStripButton51_Click(object sender, EventArgs e)
        {
            if (psitionidtext.Text == "")
            {
                MessageBox.Show("Please Insert Possition ID");
            }
            else
            {
                int poid = Convert.ToInt32(psitionidtext.Text);
                var positonbiz = new PossitionsBiz();

                if (MessageBox.Show("are you sure you want to delet ?", "Confirm Deletion",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    var result = positonbiz.Delete(poid);

                    if (result.Status)
                    {
                        XtraMessageBox.Show("Successfully Deleted");
                        clearpo();
                    }

                    else
                    { XtraMessageBox.Show("Not Deleted Successfully ." + result.Message); }

                }
            }
        }

        private void CleartoolStripButton52_Click(object sender, EventArgs e)
        {
            clearpo();
        }

        private void textEdit4_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }

        private void psitionidtext_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }

    }
}
