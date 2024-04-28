using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliverable_1
{
    public partial class StudentHomeForm : Form
    {
        private string loggedInStudentID;
        private string loggedInSupervisorID=null;
        public StudentHomeForm(string studentID)
        {
            InitializeComponent();
            loggedInStudentID = studentID;
            


        }

        private void button_managegroup_Click(object sender, EventArgs e)
        {

        }
        //to show child form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main2.Controls.Add(childForm);
            panel_main2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(loggedInStudentID));
        }

        private void panel_slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 login = new Form1();
            //this.Hide();
            //login.Show();
        }

        private void EvaluationButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAllEvaluations());
        }

        private void groupsdetailbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void AnnouncementButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAnouncements());
        }

        private void GroupdetailButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void MarksButton_Click(object sender, EventArgs e)
        {
            
            openChildForm(new MarksForm(loggedInStudentID));
            
        }

        private void MeetscheduleButton_Click(object sender, EventArgs e)
        {
           
            openChildForm(new Meeting_Schedule());
        }

        private void chatbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new ChatForm(loggedInStudentID, loggedInSupervisorID=null));
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(loggedInStudentID));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAnouncements());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            openChildForm(new MarksForm(loggedInStudentID));
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openChildForm(new Meeting_Schedule());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            openChildForm(new ChatForm(loggedInStudentID, loggedInSupervisorID = null));
        }

        private void button_LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
