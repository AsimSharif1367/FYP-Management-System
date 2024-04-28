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
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
            submenuclose();
        }


        private void submenuclose()
        {


            panelmngstudentsubmenu.Visible = false;

            panel_AnnounceSubmenu.Visible = false;

           

        }

        private void hideSubmenu()
        {


            if (panelmngstudentsubmenu.Visible == true)
                panelmngstudentsubmenu.Visible = false;


            if (panel_AnnounceSubmenu.Visible == true)
             panel_AnnounceSubmenu.Visible = false;

            //if (panel_EVALUATIONsubmenu.Visible == true)
            //    panel_EVALUATIONsubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentsProfileForm());
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentsProfileForm());
        }

        private void AnnouncementButton_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAllEvaluations());
        }

        private void Managestu_Button_Click(object sender, EventArgs e)
        {
            showSubmenu(panelmngstudentsubmenu);
        }

        private void button_addstudent_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudentForm());
        }

        private void button_removeStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoveStudentForm());
        }

        private void MarksButton_Click(object sender, EventArgs e)
        {
            openChildForm( new ViewAllEvaluations());

        }

        private void MeetscheduleButton_Click(object sender, EventArgs e)
        {
            openChildForm(new Meeting_Schedule());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openChildForm(new Meeting_Schedule());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            showSubmenu(panelmngstudentsubmenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 login = new Form1();
            //this.Hide();
            //login.Show();
        }

        private void button_Announcements_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_AnnounceSubmenu);
        }

        private void button_makeannouncement_Click(object sender, EventArgs e)
        {
           

            openChildForm(new MakeAnnouncements());
        }

        private void button_viewall_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAnouncements());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_AnnounceSubmenu);
        }

        private void button_LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
