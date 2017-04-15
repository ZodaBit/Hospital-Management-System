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
    public partial class Deathregistration : Form
    {
        AutoCompleteStringCollection autodata = new AutoCompleteStringCollection();
        HMSgeneralentity mo = new HMSgeneralentity();

        public Deathregistration()
        {
            InitializeComponent();
            AutoComplet();
        }

        //method to suggest option from id
        public void AutoComplet()
        {
            DeathRegestration deathre = mo.DeathRegestrations.Create();
            var deathreg = mo.DeathRegestrations;
            foreach (var p in deathreg)
            {
                autodata.Add(p.ID.ToString());
            }
            DeathRegIdtextbox.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DeathRegIdtextbox.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            DeathRegIdtextbox.MaskBox.AutoCompleteCustomSource = autodata;
        }

        // method for feaching data from the database 

        public void fechfromdatabase()
        {
            if (DeathRegIdtextbox.Text == "")
            {

            }
            else
            {
                int ids = Convert.ToInt32(DeathRegIdtextbox.Text);

                DeathRegestration cm = mo.DeathRegestrations.Create();
                var deathpop = from z in mo.DeathRegestrations where z.ID == ids select z;
                foreach (var p in deathpop)
                {
                    FirstNametextbox.Text = p.Name;
                    FatherNametextbox.Text = p.MiddleName;
                    GrandFathernametextbox.Text = p.LastName;
                    SexcomboBoxEdit1.Text = p.Sex;
                    AgespinEdit1.Text = p.Age.ToString();
                    dateEdit1.Text = p.Date;
                    timeEdit1.Text = p.Time;
                    Doctornametextbox.Text = p.PhesetianName;
                    DeathCaserichEditControl1.Text = p.DeathCase;

                }

            }
        }
        // Method Clear 
        void clearDeath()
        {
            DeathRegIdtextbox.Text = "";
            FirstNametextbox.Text = "";
            FatherNametextbox.Text = "";
            GrandFathernametextbox.Text = "";
            SexcomboBoxEdit1.Text = "";
            AgespinEdit1.Text = "";
            dateEdit1.Text = "";
            timeEdit1.Text = "";
            Doctornametextbox.Text = "";
            DeathCaserichEditControl1.Text = "";
        }
//method for saving data to the database
        private void DeathSavetoolstrip_Click(object sender, EventArgs e)
        {
              var deathpopl = new DeathRegestration()
            {
                Name = FirstNametextbox.Text,
                MiddleName = FatherNametextbox.Text,
                LastName = GrandFathernametextbox.Text,
                Sex = SexcomboBoxEdit1.Text,
                Date = dateEdit1.Text,
                Time = timeEdit1.Text,
                PhesetianName = Doctornametextbox.Text,
                DeathCase = DeathCaserichEditControl1.Text
            };
            var DeathregBiz = new DeathRegistrationBiz();
            var result = DeathregBiz.Add(deathpopl);

            if (result.Status)
            {
                MessageBox.Show("Successfully saved.");
                clearDeath();
            }

            else
                MessageBox.Show("Save failed. " + result.Message);
        
        
        }
// edit data from the the data base 
        private void DeathEdittoolstrip_Click(object sender, EventArgs e)
        {
            if (DeathRegIdtextbox.Text == "")
            {
                MessageBox.Show("Please Insert DeathReg ID");
            }
            else
            {
                var updateDeath = new DeathRegestration()
                {

                    ID = Convert.ToInt32(DeathRegIdtextbox.Text),
                    Name = FirstNametextbox.Text,
                    MiddleName = FatherNametextbox.Text,
                    LastName = GrandFathernametextbox.Text,
                    Sex = SexcomboBoxEdit1.Text,
                    Date = dateEdit1.Text,
                    Time = timeEdit1.Text,
                    PhesetianName = Doctornametextbox.Text,
                    DeathCase = DeathCaserichEditControl1.Text
                };

                var updeathBiz = new DeathRegistrationBiz();
                if (MessageBox.Show("are you sure you want to Edit this file ?", "Confirm Updating",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                {

                    var result = updeathBiz.Update(updateDeath);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfuly Updated");
                        clearDeath();
                    }
                    else
                    { MessageBox.Show("Update faild." + result.Message); }

                }
            }
        }
        //method to delete data from the database
        private void DeathDelettoolstrip_Click(object sender, EventArgs e)
        {
              if (DeathRegIdtextbox.Text == "")
            {
                MessageBox.Show("Please Insert DeathReg ID");
            }
            else
            {
                int poid = Convert.ToInt32(DeathRegIdtextbox.Text);

                var Deathpobiz = new DeathRegistrationBiz();

                if (MessageBox.Show("are you sure you want to delet ?", "Confirm Deletion",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) 
                {


                    var result = Deathpobiz.Delete(poid);

                    if (result.Status)
                    {
                        MessageBox.Show("Successfully Deleted");
                        clearDeath();
                    }

                    else
                    { MessageBox.Show("Not Deleted Successfully ." + result.Message); }
                }
            }
        }

        private void DeathCleartoolStrip_Click(object sender, EventArgs e)
        {
            clearDeath();
        }

        private void FirstNametextbox_Click(object sender, EventArgs e)
        {
            fechfromdatabase();
        }
        


    }
}
