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
    public partial class bedwards : DevExpress.XtraEditors.XtraForm
    {
        public bedwards()
        {
            InitializeComponent();
        }
        HMSgeneralentity bn = new HMSgeneralentity();
        bedward bd = new bedward();
        public Docterview labrq;
        public void loadsdata()
        {
            name.Text = ((Docterview)labrq).paitentname.Text;
            fathername.Text = ((Docterview)labrq).fathername.Text;
            sex.Text = ((Docterview)labrq).sex.Text;
            dates.Text = ((Docterview)labrq).date.Text;
            physicianname.Text = ((Docterview)labrq).physitianname.Text;
            paitentid.Text = ((Docterview)labrq).paitentid.Text;
            Age.Text = ((Docterview)labrq).age.Text;
            
        }
        public void savefiles()
        {
            try
            {
                bd = bn.bedwards.Create();
                bd.PatientID = int.Parse(paitentid.Text);
                bd.PatientName = name.Text;
                bd.FatherName = fathername.Text;
                bd.Age = int.Parse(Age.Text);
                bd.Sex = sex.Text;
                bd.Date = DateTime.Parse(dates.Text);
                bd.Physician = physicianname.Text;
                bd.AssignFor = DateTime.Parse(assignedfor.Text);
                bd.RoomStatus = roomstatus.Text;
                bn.bedwards.Add(bd);
                bn.SaveChanges();
                clear();
               
            }
            catch (Exception gt)
            {
                MessageBox.Show(gt.Message.ToString());
            }
        }
        public void updatss()
        {
            try
            {
                int ides = Convert.ToInt32(roomid.Text);
                bd = bn.bedwards.Where(p => p.BedwID == ides).First();
                bd.PatientID = int.Parse(paitentid.Text);
                bd.PatientName = name.Text;
                bd.FatherName = fathername.Text;
                bd.Age = int.Parse(Age.Text);
                bd.Sex = sex.Text;
                bd.Date = DateTime.Parse(dates.Text);
                bd.Physician = physicianname.Text;
                bd.AssignFor = DateTime.Parse(assignedfor.Text);
                bd.RoomStatus = roomstatus.Text;
                bn.SaveChanges();
                clear();
            }
            catch (Exception tr)
            {
                MessageBox.Show(tr.Message.ToString());
            }
        }
        public void removess()
        {
            try
            {
                int ides = Convert.ToInt32(roomid.Text);
                bd = bn.bedwards.Where(p => p.BedwID == ides).First();
                bn.bedwards.Remove(bd);
                bn.SaveChanges();
                
                clear();
            }
            catch (Exception vg)
            {
                MessageBox.Show(vg.Message.ToString());
            }
        }
        private void bedwards_Load(object sender, EventArgs e)
        {
            loadsdata();
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {
            savefiles();
        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {
            updatss();
        }
        public void clear()
        {
            assignedfor.DateTime = DateTime.Now;
            roomstatus.Text = "";

        }
        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            removess();
        }

        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}