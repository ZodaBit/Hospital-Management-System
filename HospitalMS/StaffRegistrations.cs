using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class StaffRegistrations : DevExpress.XtraEditors.XtraForm
    {
        AutoCompleteStringCollection autodata = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();
        public StaffRegistrations()
        {
            InitializeComponent();
            Autocomplete();
            //AutoCompletedepartment();
        }

        //metod for doing autocomplete sugestion to staffid text box
        public void Autocomplete()
        {
            Staffregistration poples = mo.Staffregistrations.Create();
            var pol = mo.Staffregistrations;
            foreach (var p in pol)
            {
                autodata.Add(p.staffID.ToString());

            }
            staffidtext.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            staffidtext.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            staffidtext.MaskBox.AutoCompleteCustomSource = autodata;

        }

        //etho for oin autooplete uetion to epartent
        //private void AutoCompletedepartment()
        //{
       // HMSgeneral mos = new HMSgeneral();


        //    HMS.DAL.Department dep = mo.Departments.Create();
        //    var pos = mo.Departments;
        //    foreach (var p in pos)
        //    {

        //        autodata.Add(p.DepartmentName);
        //    }
        //    Departmenttext.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    Departmenttext.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    Departmenttext.MaskBox.AutoCompleteCustomSource = autodata;

        //}


        //method for feching data from the database
        public void fechfromdatabase()
        {
            if (staffidtext.Text == "")
            {
                //MessageBox.Show("please  first insert Staff id if you want to Edit");
            }
            else
            {
                int ids = Convert.ToInt32(staffidtext.Text);
                Staffregistration cm = mo.Staffregistrations.Create();
                var staffpop = from z in mo.Staffregistrations where z.staffID == ids select z;

                foreach (var p in staffpop)
                {

                    staffnametext.Text = p.Name;
                    staffmiddlenamettext.Text = p.MiddleName;
                    stafflastnametext.Text = p.LastName;
                    seccomboboxtext.Text = p.Sex;
                    Positiontext.Text = p.Possition;
                    Departmenttext.Text = p.Department;
                    Branchtext.Text = p.Branch;
                    Remarkstext.Text = p.Remarks;
                }
            }
        }
        // method to reset the vaue of text filds
        public void clear()
        {
            staffidtext.Text = "";
            staffnametext.Text = "";
            staffmiddlenamettext.Text = "";
            stafflastnametext.Text = "";
            seccomboboxtext.Text = "";
            Positiontext.Text = "";
            Departmenttext.Text = "";
            Branchtext.Text = "";
            Remarkstext.Text = "";
        }
// method save data to the database 
        private void toolStripButton23_Click(object sender, EventArgs e)
        {
            var staffdal = new Staffregistration()
            {
                Name = staffnametext.Text,
                MiddleName = staffmiddlenamettext.Text,
                LastName = stafflastnametext.Text,
                Sex = seccomboboxtext.Text,
                Possition = Positiontext.Text,
                Department = Departmenttext.Text,
                Branch = Branchtext.Text,
                Remarks = Remarkstext.Text
            };
            var staffbiz = new StaffRegistrationsBiz();
            var result = staffbiz.Add(staffdal);
            if (result.Status)
            {
                XtraMessageBox.Show("Saved Succsessfully");
                clear();
            }

            else { XtraMessageBox.Show("Note Saved Successfully." + result.Message); }
        }

        //method that edit data from the database
        private void Edittoolstrip_Click(object sender, EventArgs e)
        {
            if (staffidtext.Text == "")
            {
                MessageBox.Show("Please Insert Staff ID ");
            }
            else
            {
                var staffdata = new Staffregistration()
                {
                    staffID = Convert.ToInt32(staffidtext.Text),
                    Name = staffnametext.Text,
                    MiddleName = staffmiddlenamettext.Text,
                    LastName = stafflastnametext.Text,
                    Sex = seccomboboxtext.Text,
                    Possition = Positiontext.Text,
                    Department = Departmenttext.Text,
                    Branch = Branchtext.Text,
                    Remarks = Remarkstext.Text
                };

                var editstaffBiz = new StaffRegistrationsBiz();
                if (MessageBox.Show("are you sure you want to Edit this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = editstaffBiz.Update(staffdata);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Updated");
                        clear();
                    }
                    else
                    { MessageBox.Show("Update faild." + result.Message); }

                }
            }
        }
//method to delete data fromthe hms database using staff id
        private void Deletetoolstrip_Click(object sender, EventArgs e)
        {
            if (staffidtext.Text == "")
            {
                MessageBox.Show("Please Insert Staff ID");
            }
            else
            {
                int staffid = Convert.ToInt32(staffidtext.Text);
                var staffbiz = new StaffRegistrationsBiz();
                if (MessageBox.Show("Are you Sure you want to delete", "Confirm Deltion",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    var result = staffbiz.Delete(staffid);
                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Deleted");
                        clear();
                    }

                    else
                        MessageBox.Show("Not Deleted Successfuly." + result.Message);
                }

            }
        }

        //method for to clear text box
        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void staffnametext_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }
    }
}