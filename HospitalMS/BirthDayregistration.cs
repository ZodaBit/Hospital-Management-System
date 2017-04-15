using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace HospitalMS
{
    public partial class BirthDayregistration :  DevExpress.XtraEditors.XtraForm
    {
        AutoCompleteStringCollection autodata = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();
         
        public BirthDayregistration()
        {
            InitializeComponent();
            AutoComplete();
        }

        private void AutoComplete()
        {

            BirthRegestration bo = mo.BirthRegestrations.Create();
            var pos = mo.BirthRegestrations;
            foreach (var p in pos)
            {

                autodata.Add(p.ID.ToString());
            }
            babybirthidtxt.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            babybirthidtxt.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            babybirthidtxt.MaskBox.AutoCompleteCustomSource = autodata;

        }

        // Method fech from the database 
        public void fechfromdatabase()
        {
            if (babybirthidtxt.Text == "")
            {
                //MessageBox.Show("please  first insert birth id if you want to Edit");
            }
            else
            {
                int ids = Convert.ToInt32(babybirthidtxt.Text);
                BirthRegestration cm = mo.BirthRegestrations.Create();
                var birthpop = from z in mo.BirthRegestrations where z.ID == ids select z;


                foreach (var p in birthpop)
                {
                    babynametxt.Text = p.BabyName;
                    babymotehrtext.Text = p.MotherName;
                    babyfathertext.Text = p.BabyFatherName;
                    dateEdit1.Text = p.Date;
                    timeEdit1.Text = p.Time;
                    doctornametext.Text = p.StaffName;
                    babyweighttext.Text = p.BabyWeight;
                    babyheighttxt.Text = p.BabyHeight;
                    remarkstext.Text = p.Remarks;

                }
            }
        }
        //method for clearing textbox fields 
        public void Clear()
        {
            babybirthidtxt.Text = "";
            babynametxt.Text = "";
            babymotehrtext.Text = "";
            babyfathertext.Text = "";
            dateEdit1.Text = "";
            timeEdit1.Text = "";
            //nursetext.Text = "";
            doctornametext.Text = "";
            babyweighttext.Text = "";
            babyheighttxt.Text = "";
            remarkstext.Text = "";
        }
        //method for saving the data to the database 
        private void toolStripButton109_Click(object sender, EventArgs e)
        {
            
            var birthDal = new BirthRegestration()
            {
                BabyName = babynametxt.Text,
                BabyFatherName = babyfathertext.Text,
                MotherName = babymotehrtext.Text,
                Date = dateEdit1.Text,
                Time = timeEdit1.Text,

                StaffName = doctornametext.Text,
                BabyWeight = babyweighttext.Text,
                BabyHeight = babyheighttxt.Text,
                Remarks = remarkstext.Text

            };

            var birthbiz = new BirthDayregistrationBiz();
            var result = birthbiz.Add(birthDal);
            if (result.Status)
            {
                MessageBox.Show("Saved Successfully");
                Clear();
            }

            else
                MessageBox.Show("Not Saved Successfully." + result.Message);
        
        
        }
// method for editing dtata from the database 
        private void BirthDayEdittoolstrip_Click(object sender, EventArgs e)
        {

            if (babybirthidtxt.Text == "")
            {
                MessageBox.Show("Please Insert Birth ID");
            }
            else
            {
                var birthdata = new BirthRegestration()
                {
                    ID = Convert.ToInt32(babybirthidtxt.Text),
                    BabyName = babynametxt.Text,
                    BabyFatherName = babyfathertext.Text,
                    MotherName = babymotehrtext.Text,
                    Date = dateEdit1.Text,
                    Time = timeEdit1.Text,

                    StaffName = doctornametext.Text,
                    BabyWeight = babyweighttext.Text,
                    BabyHeight = babyheighttxt.Text,
                    Remarks = remarkstext.Text
                };

                var editbirthBiz = new BirthDayregistrationBiz();
                if (MessageBox.Show("are you sure you want to Update this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = editbirthBiz.Update(birthdata);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Updated");
                        Clear();
                    }
                    else
                    { MessageBox.Show("Update faild." + result.Message); }

                }
            }
        }
        //method for deleting data from the database 
        private void BirthdayDeletetoolstrip_Click(object sender, EventArgs e)
        {
            if (babybirthidtxt.Text == "")
            {
                MessageBox.Show("Please Insert Birth ID");
            }
            else
            {
                int delteid = Convert.ToInt32(babybirthidtxt.Text);
                var birthbiz = new BirthDayregistrationBiz();
                if (MessageBox.Show("Are you Sure you want to delete", "Confirm Deltion",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var result = birthbiz.Delete(delteid);
                    if (result.Status)
                    {
                        XtraMessageBox.Show("Successfuly Deleted");
                        Clear();
                    }
                    else
                        XtraMessageBox.Show("Not Deleted Successfuly." + result.Message);
                }
            }
        }

        private void BirthdayCleartoolstrip_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void babynametxt_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }
        
    }
}
