﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableManagementSystem.Sessions
{
    public partial class Sessions : MetroFramework.Forms.MetroForm
    {
        public Sessions()
        {
            InitializeComponent();
        }

        SqlConnection con = Config.con;

        public String names = "";
        public String lecturers = "";

        private void Sessions_Load(object sender, EventArgs e)
        {
            GetLecturers();
        }

        public void GetLecturers()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT LecName FROM Lecturers";

            cmd.ExecuteNonQuery();

            DataTable dtlecturers = new DataTable();

            SqlDataAdapter dalecturers = new SqlDataAdapter(cmd);

            dalecturers.Fill(dtlecturers);

            foreach (DataRow dr in dtlecturers.Rows)
            {
                cmbSessionLecturer.Items.Add(dr["LecName"].ToString());
            }

            con.Close();
        }

        private void btnSessionSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Sessions VALUES (@Lecturer, @Subject, @SubjectCode, @Tag, @GroupID, @StudentCount, @Duration)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Lecturer", lecturers);
                cmd.Parameters.AddWithValue("@Subject", cmbSessionSubject.Text);
                cmd.Parameters.AddWithValue("@SubjectCode", cmbSessionSubject.Text);
                cmd.Parameters.AddWithValue("@Tag", cmbSessionTag.Text);
                cmd.Parameters.AddWithValue("@GroupID", cmbSessionGroup.Text);    
                cmd.Parameters.AddWithValue("@StudentCount", nmudSessionNoStudents.Text);
                cmd.Parameters.AddWithValue("@Duration", nmudSessionDuration.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //GetSubjects();

                //ClearFieldsAfterAdd();

                //tabControlSubjects.SelectedTab = tabPageSubView;
            }
        }

        private bool IsValid()
        {
            if (cmbSessionLecturer.Text == string.Empty)
            {
                MessageBox.Show("Fill the all fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearFieldsAfterAdd()
        {
            cmbSessionLecturer.SelectedIndex = -1;
            lecturers = "";
            txtSelectedLecturers.Clear();
            
        }

        //--------------------Header Buttons--------------------

        private void btnHeaderHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage homepage = new Homepage();
            homepage.ShowDialog();
        }

        private void btnHeaderSessions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sessions sessions = new Sessions();
            sessions.ShowDialog();
        }

        private void btnHeaderRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rooms.Rooms rooms = new Rooms.Rooms();
            rooms.ShowDialog();
        }

        private void btnHeaderAdvanced_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdvancedOp.Advanced advc = new AdvancedOp.Advanced();
            advc.ShowDialog();
        }

        private void btnHeaderGenerate_Click(object sender, EventArgs e)
        {

        }


        //--------------------Side Nav Buttons--------------------

        private void btnSideNavWorking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Working_Days.Add_Number_of_Working_Days workingDays = new Working_Days.Add_Number_of_Working_Days();
            workingDays.ShowDialog();
        }

        private void btnSideNavLecturers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturers.AddLecturer addLecturer = new Lecturers.AddLecturer();
            addLecturer.ShowDialog();
        }

        private void btnSideNavSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects.AddSubject addSubject = new Subjects.AddSubject();
            addSubject.ShowDialog();
        }

        private void btnSideNavStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students.Students stu = new Students.Students();
            stu.ShowDialog();
        }

        private void btnSideNavTags_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tags.Tags tag = new Tags.Tags();
            tag.ShowDialog();
        }

        private void btnSideNavLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            Locations.Location loc = new Locations.Location();
            loc.ShowDialog();
        }

        private void btnSideNavStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics.Statistics stat = new Statistics.Statistics();
            stat.ShowDialog();
        }

        private void cmbSessionLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lecturers.Add(cmbSessionLecturer.Text);
            lecturers = lecturers + cmbSessionLecturer.Text+", ";
            

            txtSelectedLecturers.Text = lecturers;
            /*
            for (int i=0; i< lecturers.Count; i++)
            {
                names = names + lecturers[i];
                metroLabel19.Text = names;
            }
            */

            //MessageBox.Show("Fill the all fields"+ lecturers[0], "Failed", MessageBoxButtons.OK);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFieldsAfterAdd();

        }
    }
}
