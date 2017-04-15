using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class Paitenthistory : DevExpress.XtraEditors.XtraForm
    {
        HMSgeneralentity db = new HMSgeneralentity();
        FoPastMedicalHistory medicalHisotry;
        foPatient patient;
        int _patientId;
        bool isNew = false;

        public Paitenthistory()
        {
            InitializeComponent();
        }

        public Paitenthistory(int patientId)
        {
            InitializeComponent();
            _patientId = patientId;
        }  

        private void Paitenthistory_Load(object sender, EventArgs e)
        {
            //HMSSecurity.ApplySecurityToUi(this);

            loadsdata();
            basic();
            pasmedical();
            familys();
            socialhis();
            reviewsysy();
            general();
            phyExam();
        }

        public void loadsdata()
        {
            medicalHisotry = db.FoPastMedicalHistories.Where(mh => mh.PatientId == _patientId).FirstOrDefault();
            patient = db.foPatients.FirstOrDefault(p => p.Id == _patientId);

            if (medicalHisotry == null)
            {
                medicalHisotry = new FoPastMedicalHistory();
                isNew = true;
                IntitalizemedicalHisotry();
            }

            name.Text = patient.FullName;
            sex.Text = patient.Sex;
            RegNO.Text = patient.Id.ToString();
            Age.Text = patient.Age.ToString();
        }

        private void IntitalizemedicalHisotry()
        {
            medicalHisotry.PatientId = _patientId;

            medicalHisotry.HeartDiseaseRemark = "";
            medicalHisotry.HypertensionRemark = "";
            medicalHisotry.DyslipidemiaRemark = "";
            medicalHisotry.DiabetesRemark = "";
            medicalHisotry.CancerRemark = "";
            medicalHisotry.AnthemiaRemark = "";
            medicalHisotry.PastillnessRemark = "";
            medicalHisotry.AdmissionHistoryRemark = "";
            medicalHisotry.MentalHistoryRemark = "";
            medicalHisotry.PregnancyHistoryRemark = "";
            medicalHisotry.FatherandMother = false;

            medicalHisotry.FatherandMotherRemark = "";
            medicalHisotry.SiblingsRemark = "";
            medicalHisotry.FamilydiseaseRemark = "";
            medicalHisotry.FamilyOtherRemark = "";

            medicalHisotry.EarlyDevelopment = "";
            medicalHisotry.Education = "";
            medicalHisotry.SocialActivities = "";
            medicalHisotry.WorkRecord = "";
            medicalHisotry.Environment = "";
            medicalHisotry.Habits = "";
            medicalHisotry.MentalStatus = "";
            medicalHisotry.OtherSocialHistoryRemark = "";

            medicalHisotry.HEENTRemark = "";
            medicalHisotry.GlandsRemark = "";
            medicalHisotry.RespiratoryRemark = "";
            medicalHisotry.CNSRemark = "";
            medicalHisotry.CardiovascularRemark = "";
            medicalHisotry.GastrointestinalRemark = "";
            medicalHisotry.GenitourinaryRemark = "";
            medicalHisotry.IntegumentaryRemark = "";
            medicalHisotry.AllergyRemark = "";
            medicalHisotry.LocomotorsRemark = "";
            medicalHisotry.ReviewSysOtherRemark = "";

            medicalHisotry.GeneralAppearanceRemark = "";
            medicalHisotry.RespiratorySystemRemark = "";
            medicalHisotry.NervousSystemRemark = "";
            medicalHisotry.CentralSystemRemark = "";
            medicalHisotry.MotorRemark = "";
            medicalHisotry.SensoryRemark = "";
            medicalHisotry.ReflexRemark = "";
            medicalHisotry.GeneralOtherRemark = "";

            medicalHisotry.Ccompliment = "";
            medicalHisotry.PIllness = "";
            medicalHisotry.DifDiagnosis = "";
            medicalHisotry.CurrentModification = "";
            medicalHisotry.Assesment = "";
            medicalHisotry.Allergies = "";

            medicalHisotry.bp1 = "";
            medicalHisotry.bp2 = "";
            medicalHisotry.bp3 = "";
            medicalHisotry.bp4 = "";
            medicalHisotry.bp5 = "";
            medicalHisotry.bp6 = "";
            medicalHisotry.bp7 = "";
            medicalHisotry.bp8 = "";
            medicalHisotry.bp9 = "";
            medicalHisotry.bp10 = "";
            medicalHisotry.bp11 = "";
            medicalHisotry.bp12 = "";

            medicalHisotry.tp1 = "";
            medicalHisotry.tp2 = "";
            medicalHisotry.tp3 = "";
            medicalHisotry.tp4 = "";
            medicalHisotry.tp5 = "";
            medicalHisotry.tp6 = "";

            medicalHisotry.p = "";
            medicalHisotry.rr = "";
            medicalHisotry.brpm = "";
            medicalHisotry.wt = "";
            medicalHisotry.wsf = "";
            medicalHisotry.hsf = "";
            medicalHisotry.bmi = "";
            medicalHisotry.vr = "";
            medicalHisotry.vl = "";
        }

        private void basic()
        {
            txtCCompliment.Text = medicalHisotry.Ccompliment;
            txtPreIll.Text = medicalHisotry.PIllness;
            txtDifDiagnosise.Text = medicalHisotry.DifDiagnosis;
            txtCurrModi.Text = medicalHisotry.CurrentModification;
            txtAssessment.Text = medicalHisotry.Assesment;
            txtAllergies.Text = medicalHisotry.Allergies;
        }

        private void phyExam()
        {
            bp1.Text = medicalHisotry.bp1;
            bp2.Text = medicalHisotry.bp2;
            bp3.Text = medicalHisotry.bp3;
            bp4.Text = medicalHisotry.bp4;
            bp5.Text = medicalHisotry.bp5;
            bp6.Text = medicalHisotry.bp6;
            bp7.Text = medicalHisotry.bp7;
            bp8.Text = medicalHisotry.bp8;
            bp9.Text = medicalHisotry.bp9;
            bp10.Text = medicalHisotry.bp10;
            bp11.Text = medicalHisotry.bp11;
            bp12.Text = medicalHisotry.bp12;

            tp1.Text = medicalHisotry.tp1;
            tp2.Text = medicalHisotry.tp2;
            tp3.Text = medicalHisotry.tp3;
            tp4.Text = medicalHisotry.tp4;
            tp5.Text = medicalHisotry.tp5;
            tp6.Text = medicalHisotry.tp6;

            p.Text = medicalHisotry.p;
            rr.Text = medicalHisotry.rr;
            brpm.Text = medicalHisotry.brpm;
            wt.Text = medicalHisotry.wt;
            wsf.Text = medicalHisotry.wsf;
            hsf.Text = medicalHisotry.hsf;
            bmi.Text = medicalHisotry.bmi;
            vr.Text = medicalHisotry.vr;
            vl.Text = medicalHisotry.vl;
        }

        public void pasmedical()
        {
            string[] row = new string[] { "Heart Disease", medicalHisotry.HeartDisease.ToString(), medicalHisotry.HeartDiseaseRemark };
            dataGridViewPastMedHis.Rows.Add(row);
            string[] row1 = new string[] { "Hypertension", medicalHisotry.Hypertension.ToString(), medicalHisotry.HypertensionRemark };
            dataGridViewPastMedHis.Rows.Add(row1);
            string[] row2 = new string[] { "Dyslipidemia", medicalHisotry.Dyslipidemia.ToString(), medicalHisotry.DyslipidemiaRemark };
            dataGridViewPastMedHis.Rows.Add(row2);
            string[] row3 = new string[] { "Diabetes  ", medicalHisotry.Diabetes.ToString(), medicalHisotry.DiabetesRemark };
            dataGridViewPastMedHis.Rows.Add(row3);
            string[] ro4 = new string[] { "Cancer", medicalHisotry.Cancer.ToString(), medicalHisotry.CancerRemark };
            dataGridViewPastMedHis.Rows.Add(ro4);
            string[] row5 = new string[] { "Anthemia", medicalHisotry.Anthemia.ToString(), medicalHisotry.AnthemiaRemark };
            dataGridViewPastMedHis.Rows.Add(row5);
            string[] row6 = new string[] { "Past illness", medicalHisotry.Pastillness.ToString(), medicalHisotry.PastillnessRemark };
            dataGridViewPastMedHis.Rows.Add(row6);
            string[] row7 = new string[] { "Admission History ", medicalHisotry.AdmissionHistory.ToString(), medicalHisotry.AdmissionHistoryRemark };
            dataGridViewPastMedHis.Rows.Add(row7);
            string[] row8 = new string[] { "Mental History ", medicalHisotry.MentalHistory.ToString(), medicalHisotry.MentalHistoryRemark };
            dataGridViewPastMedHis.Rows.Add(row8);
            string[] row9 = new string[] { "Pregnancy History ", medicalHisotry.PregnancyHistory.ToString(), medicalHisotry.PregnancyHistoryRemark };
            dataGridViewPastMedHis.Rows.Add(row9);
        }
        public void familys()
        {
            string[] row = new string[] { "Father and Mother", medicalHisotry.FatherandMother.ToString(), medicalHisotry.FatherandMotherRemark };
            dataGridViewFamilHIstory.Rows.Add(row);
            string[] row1 = new string[] { "Siblings ", medicalHisotry.Siblings.ToString(), medicalHisotry.SiblingsRemark };
            dataGridViewFamilHIstory.Rows.Add(row1);
            string[] row2 = new string[] { "Family disease ", medicalHisotry.Familydisease.ToString(), medicalHisotry.FamilydiseaseRemark };
            dataGridViewFamilHIstory.Rows.Add(row2);
            string[] row3 = new string[] { "Other ", medicalHisotry.FamilyOther.ToString(), medicalHisotry.FamilyOtherRemark };
            dataGridViewFamilHIstory.Rows.Add(row3);
        }
        public void socialhis()
        {
            string[] row = new string[] { "Early Development", medicalHisotry.EarlyDevelopment };
            dataGridViewSocailHistory.Rows.Add(row);
            string[] row1 = new string[] { "Education", medicalHisotry.Education };
            dataGridViewSocailHistory.Rows.Add(row1);
            string[] row2 = new string[] { "Social Activities", medicalHisotry.SocialActivities };
            dataGridViewSocailHistory.Rows.Add(row2);
            string[] row3 = new string[] { "Work Record", medicalHisotry.WorkRecord };
            dataGridViewSocailHistory.Rows.Add(row3);
            string[] row4 = new string[] { "Environment", medicalHisotry.Environment };
            dataGridViewSocailHistory.Rows.Add(row4);
            string[] row5 = new string[] { "Habits", medicalHisotry.Habits };
            dataGridViewSocailHistory.Rows.Add(row5);
            string[] row6 = new string[] { "Mental Status", medicalHisotry.MentalStatus };
            dataGridViewSocailHistory.Rows.Add(row6);
            string[] row7 = new string[] { "Other", medicalHisotry.OtherSocialHistoryRemark };
            dataGridViewSocailHistory.Rows.Add(row7);
        }
        public void reviewsysy()
        {
            string[] row = new string[] { "HEENT", medicalHisotry.HEENT.ToString(), medicalHisotry.HEENTRemark };
            dataGridViewReviewSystem.Rows.Add(row);
            string[] row1 = new string[] { "Glands", medicalHisotry.Glands.ToString(), medicalHisotry.GlandsRemark };
            dataGridViewReviewSystem.Rows.Add(row1);
            string[] row2 = new string[] { "Respiratory", medicalHisotry.Respiratory.ToString(), medicalHisotry.RespiratoryRemark };
            dataGridViewReviewSystem.Rows.Add(row2);
            string[] row3 = new string[] { "CNS", medicalHisotry.CNS.ToString(), medicalHisotry.CNSRemark };
            dataGridViewReviewSystem.Rows.Add(row3);
            string[] row4 = new string[] { "Cardiovascula", medicalHisotry.Cardiovascular.ToString(), medicalHisotry.CardiovascularRemark };
            dataGridViewReviewSystem.Rows.Add(row4);
            string[] row5 = new string[] { "Gastrointestinal", medicalHisotry.Gastrointestinal.ToString(), medicalHisotry.GastrointestinalRemark };
            dataGridViewReviewSystem.Rows.Add(row5);
            string[] row6 = new string[] { "Genitourinary", medicalHisotry.Genitourinary.ToString(), medicalHisotry.GenitourinaryRemark };
            dataGridViewReviewSystem.Rows.Add(row6);
            string[] row7 = new string[] { "Integumentary", medicalHisotry.Integumentary.ToString(), medicalHisotry.IntegumentaryRemark };
            dataGridViewReviewSystem.Rows.Add(row7);
            string[] row10 = new string[] { "Allergy", medicalHisotry.Allergy.ToString(), medicalHisotry.AllergyRemark };
            dataGridViewReviewSystem.Rows.Add(row10);
            string[] row11 = new string[] { "Locomotors", medicalHisotry.Locomotors.ToString(), medicalHisotry.LocomotorsRemark };
            dataGridViewReviewSystem.Rows.Add(row11);
            string[] row12 = new string[] { "Other ", medicalHisotry.ReviewSysOther.ToString(), medicalHisotry.ReviewSysOtherRemark };
            dataGridViewReviewSystem.Rows.Add(row12);
        }
        public void general()
        {
            string[] row = new string[] { "General Appearance", medicalHisotry.GeneralAppearance.ToString(), medicalHisotry.GeneralAppearanceRemark };
            dataGridViewGeneralExam.Rows.Add(row);
            //string[] row1 = new string[] { "HEENT" };
            //dataGridViewGeneralExam.Rows.Add(row1);
            //string[] row2 = new string[] { "Glands" };
            //dataGridViewGeneralExam.Rows.Add(row2);
            string[] row3 = new string[] { "Respiratory System", medicalHisotry.RespiratorySystem.ToString(), medicalHisotry.RespiratorySystemRemark };
            dataGridViewGeneralExam.Rows.Add(row3);
            //string[] row4 = new string[] { "CVS" };
            //dataGridViewGeneralExam.Rows.Add(row4);
            //string[] row5 = new string[] { "Gastrointestinal System " };
            //dataGridViewGeneralExam.Rows.Add(row5);
            //string[] row6 = new string[] { "Genitourinary System " };
            //dataGridViewGeneralExam.Rows.Add(row6);
            //string[] row7 = new string[] { "Locomotors System " };
            //dataGridViewGeneralExam.Rows.Add(row7);
            string[] row8 = new string[] { "Nervous System", medicalHisotry.NervousSystem.ToString(), medicalHisotry.NervousSystemRemark };
            dataGridViewGeneralExam.Rows.Add(row8);
            string[] row9 = new string[] { "Central System", medicalHisotry.CentralSystem.ToString(), medicalHisotry.CentralSystemRemark };
            dataGridViewGeneralExam.Rows.Add(row9);
            string[] row10 = new string[] { "Motor", medicalHisotry.Motor.ToString(), medicalHisotry.MotorRemark };
            dataGridViewGeneralExam.Rows.Add(row10);
            string[] row11 = new string[] { "Sensory", medicalHisotry.Sensory.ToString(), medicalHisotry.SensoryRemark };
            dataGridViewGeneralExam.Rows.Add(row11);
            string[] row12 = new string[] { "Reflex ", medicalHisotry.Reflex.ToString(), medicalHisotry.ReflexRemark };
            dataGridViewGeneralExam.Rows.Add(row12);
            string[] row13 = new string[] { "Other", medicalHisotry.GeneralOther.ToString(), medicalHisotry.GeneralOtherRemark };
            dataGridViewGeneralExam.Rows.Add(row13);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            medicalHisotry.HeartDisease = Convert.ToBoolean(dataGridViewPastMedHis.Rows[0].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Hypertension = Convert.ToBoolean(dataGridViewPastMedHis.Rows[1].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Dyslipidemia = Convert.ToBoolean(dataGridViewPastMedHis.Rows[2].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Diabetes = Convert.ToBoolean(dataGridViewPastMedHis.Rows[3].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Cancer = Convert.ToBoolean(dataGridViewPastMedHis.Rows[4].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Anthemia = Convert.ToBoolean(dataGridViewPastMedHis.Rows[5].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Pastillness = Convert.ToBoolean(dataGridViewPastMedHis.Rows[6].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.AdmissionHistory = Convert.ToBoolean(dataGridViewPastMedHis.Rows[7].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.MentalHistory = Convert.ToBoolean(dataGridViewPastMedHis.Rows[8].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.PregnancyHistory = Convert.ToBoolean(dataGridViewPastMedHis.Rows[9].Cells[1].EditedFormattedValue.ToString());

            medicalHisotry.HeartDiseaseRemark = dataGridViewPastMedHis.Rows[0].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.HypertensionRemark = dataGridViewPastMedHis.Rows[1].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.DyslipidemiaRemark = dataGridViewPastMedHis.Rows[2].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.DiabetesRemark = dataGridViewPastMedHis.Rows[3].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.CancerRemark = dataGridViewPastMedHis.Rows[4].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.AnthemiaRemark = dataGridViewPastMedHis.Rows[5].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.PastillnessRemark = dataGridViewPastMedHis.Rows[6].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.AdmissionHistoryRemark = dataGridViewPastMedHis.Rows[7].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.MentalHistoryRemark = dataGridViewPastMedHis.Rows[8].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.PregnancyHistoryRemark = dataGridViewPastMedHis.Rows[9].Cells[2].EditedFormattedValue.ToString();

            medicalHisotry.FatherandMother = Convert.ToBoolean(dataGridViewFamilHIstory.Rows[0].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Siblings = Convert.ToBoolean(dataGridViewFamilHIstory.Rows[1].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Familydisease = Convert.ToBoolean(dataGridViewFamilHIstory.Rows[2].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.FamilyOther = Convert.ToBoolean(dataGridViewFamilHIstory.Rows[3].Cells[1].EditedFormattedValue.ToString());

            medicalHisotry.FatherandMotherRemark = dataGridViewFamilHIstory.Rows[0].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.SiblingsRemark = dataGridViewFamilHIstory.Rows[1].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.FamilydiseaseRemark = dataGridViewFamilHIstory.Rows[2].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.FamilyOtherRemark = dataGridViewFamilHIstory.Rows[3].Cells[2].EditedFormattedValue.ToString();

            medicalHisotry.EarlyDevelopment = dataGridViewSocailHistory.Rows[0].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.Education = dataGridViewSocailHistory.Rows[1].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.SocialActivities = dataGridViewSocailHistory.Rows[1].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.WorkRecord = dataGridViewSocailHistory.Rows[3].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.Environment = dataGridViewSocailHistory.Rows[4].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.Habits = dataGridViewSocailHistory.Rows[5].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.MentalStatus = dataGridViewSocailHistory.Rows[6].Cells[1].EditedFormattedValue.ToString();
            medicalHisotry.OtherSocialHistoryRemark = dataGridViewSocailHistory.Rows[7].Cells[1].EditedFormattedValue.ToString();

            medicalHisotry.HEENT = Convert.ToBoolean(dataGridViewReviewSystem.Rows[0].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Glands = Convert.ToBoolean(dataGridViewReviewSystem.Rows[1].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Respiratory = Convert.ToBoolean(dataGridViewReviewSystem.Rows[2].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.CNS = Convert.ToBoolean(dataGridViewReviewSystem.Rows[3].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Cardiovascular = Convert.ToBoolean(dataGridViewReviewSystem.Rows[4].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Gastrointestinal = Convert.ToBoolean(dataGridViewReviewSystem.Rows[5].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Genitourinary = Convert.ToBoolean(dataGridViewReviewSystem.Rows[6].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Integumentary = Convert.ToBoolean(dataGridViewReviewSystem.Rows[7].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Allergy = Convert.ToBoolean(dataGridViewReviewSystem.Rows[8].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Locomotors = Convert.ToBoolean(dataGridViewReviewSystem.Rows[9].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.ReviewSysOther = Convert.ToBoolean(dataGridViewReviewSystem.Rows[10].Cells[1].EditedFormattedValue.ToString());

            medicalHisotry.HEENTRemark = dataGridViewReviewSystem.Rows[0].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.GlandsRemark = dataGridViewReviewSystem.Rows[1].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.RespiratoryRemark = dataGridViewReviewSystem.Rows[2].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.CNSRemark = dataGridViewReviewSystem.Rows[3].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.CardiovascularRemark = dataGridViewReviewSystem.Rows[4].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.GastrointestinalRemark = dataGridViewReviewSystem.Rows[5].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.GenitourinaryRemark = dataGridViewReviewSystem.Rows[6].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.IntegumentaryRemark = dataGridViewReviewSystem.Rows[7].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.AllergyRemark = dataGridViewReviewSystem.Rows[8].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.LocomotorsRemark = dataGridViewReviewSystem.Rows[9].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.ReviewSysOtherRemark = dataGridViewReviewSystem.Rows[10].Cells[2].EditedFormattedValue.ToString();

            medicalHisotry.GeneralAppearance = Convert.ToBoolean(dataGridViewGeneralExam.Rows[0].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.RespiratorySystem = Convert.ToBoolean(dataGridViewGeneralExam.Rows[1].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.NervousSystem = Convert.ToBoolean(dataGridViewGeneralExam.Rows[2].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.CentralSystem = Convert.ToBoolean(dataGridViewGeneralExam.Rows[3].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Motor = Convert.ToBoolean(dataGridViewGeneralExam.Rows[4].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Sensory = Convert.ToBoolean(dataGridViewGeneralExam.Rows[5].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.Reflex = Convert.ToBoolean(dataGridViewGeneralExam.Rows[6].Cells[1].EditedFormattedValue.ToString());
            medicalHisotry.GeneralOther = Convert.ToBoolean(dataGridViewGeneralExam.Rows[7].Cells[1].EditedFormattedValue.ToString());

            medicalHisotry.GeneralAppearanceRemark = dataGridViewGeneralExam.Rows[0].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.RespiratorySystemRemark = dataGridViewGeneralExam.Rows[1].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.NervousSystemRemark = dataGridViewGeneralExam.Rows[2].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.CentralSystemRemark = dataGridViewGeneralExam.Rows[3].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.MotorRemark = dataGridViewGeneralExam.Rows[4].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.SensoryRemark = dataGridViewGeneralExam.Rows[5].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.ReflexRemark = dataGridViewGeneralExam.Rows[6].Cells[2].EditedFormattedValue.ToString();
            medicalHisotry.GeneralOtherRemark = dataGridViewGeneralExam.Rows[7].Cells[2].EditedFormattedValue.ToString();

            medicalHisotry.Ccompliment = txtCCompliment.Text;
            medicalHisotry.PIllness = txtPreIll.Text;
            medicalHisotry.DifDiagnosis = txtDifDiagnosise.Text;
            medicalHisotry.CurrentModification = txtCurrModi.Text;
            medicalHisotry.Assesment = txtAssessment.Text;
            medicalHisotry.Allergies = txtAllergies.Text;

            medicalHisotry.bp1 = bp1.Text;
            medicalHisotry.bp2 = bp2.Text;
            medicalHisotry.bp3 = bp3.Text;
            medicalHisotry.bp4 = bp4.Text;
            medicalHisotry.bp5 = bp5.Text;
            medicalHisotry.bp6 = bp6.Text;
            medicalHisotry.bp7 = bp7.Text;
            medicalHisotry.bp8 = bp8.Text;
            medicalHisotry.bp9 = bp9.Text;
            medicalHisotry.bp10 = bp10.Text;
            medicalHisotry.bp11 = bp11.Text;
            medicalHisotry.bp12 = bp12.Text;

            medicalHisotry.tp1 = tp1.Text;
            medicalHisotry.tp2 = tp2.Text;
            medicalHisotry.tp3 = tp3.Text;
            medicalHisotry.tp4 = tp4.Text;
            medicalHisotry.tp5 = tp5.Text;
            medicalHisotry.tp6 = tp6.Text;

            medicalHisotry.p = p.Text;
            medicalHisotry.rr = rr.Text;
            medicalHisotry.brpm = brpm.Text;
            medicalHisotry.wt = wt.Text;
            medicalHisotry.wsf =  wsf.Text;
            medicalHisotry.hsf = hsf.Text;
            medicalHisotry.bmi = bmi.Text;
            medicalHisotry.vr = vr.Text;
            medicalHisotry.vl = vl.Text;

            if (isNew)
                db.FoPastMedicalHistories.Add(medicalHisotry);

            var count =  db.SaveChanges();
            if (count > 0)
            {
                MessageBox.Show("Save Successfull");
                this.Close();
            }
            else
                MessageBox.Show("Save Failed");
        }

    }
}