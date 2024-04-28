using System;
using System.Data.SqlClient;
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
    
    
    public partial class Form2 : Form
    {
        private string loggedInSupervisorID;
        private string loggedInStudentID=null;
        public Form2(string supervisorID)
        {
            InitializeComponent();
            loggedInSupervisorID = supervisorID;
           // loggedInStudentID = null;
            submenuclose();
        }

        private void submenuclose()
        {


            panel_groupsubmenu.Visible = false;

            panel_AnnounceSubmenu.Visible = false;

            panel_EVALUATIONsubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            

            if (panel_groupsubmenu.Visible == true)
                panel_groupsubmenu.Visible = false;
             

            if (panel_AnnounceSubmenu.Visible == true)
                panel_AnnounceSubmenu.Visible = false;

            if (panel_EVALUATIONsubmenu.Visible == true)
                panel_EVALUATIONsubmenu.Visible = false;
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
        private void button_managegroup_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_groupsubmenu);
        }

        private void button_Announcements_Click(object sender, EventArgs e)
        {
            //showSubmenu(panel_AnnounceSubmenu);
            ScheduleMeeting ScheduleMeeting = new ScheduleMeeting();
            ScheduleMeeting.Show();
        }

        private void button_evaluation_Click(object sender, EventArgs e)
        {

            showSubmenu(panel_EVALUATIONsubmenu);
            

        }
        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
           


            hideSubmenu();

        }

        // form in mainform
        private Form activeForm1 = null;
        private void openChildForm1(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void button_groupdetails_Click(object sender, EventArgs e)
        {
            openChildForm1(new Form4());



            hideSubmenu();

            string connectionString = "Data Source=ASIM-SHARIF\\SQLEXPRESS;Initial Catalog=myDB;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //  sqlConnection.Open();

            // string Query = "";

            //SqlCommand cmd = new SqlCommand(Query, sqlConnection);

            // var reader = cmd.ExecuteReader();

            sqlConnection.Close();
        }

        private void button_meeting_Click(object sender, EventArgs e)
        {
            

            showSubmenu(panel_AnnounceSubmenu);

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new SearchGroups());

            hideSubmenu();
        }
                    //to show register form in mainform
                private Form activeForm3 = null;
                private void openChildForm3(Form childForm)
                {
                    if (activeForm != null)
                        activeForm.Close();
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panel_main.Controls.Add(childForm);
                    panel_main.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
       
        private void button_makeannouncement_Click(object sender, EventArgs e)
        {
            openChildForm(new MakeAnnouncements());
        }

        private void button_viewall_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewAnouncements());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form1 login = new Form1();
            //this.Hide();
            //login.Show();
        }

        private void panel_cover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_groupsubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_AnnounceSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonenterevaluation_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonenterevaluation_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormEvaluation());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            openChildForm(new ViewAllEvaluations());
        }

        
        
        

        private void buttonxchat_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ChatForm(loggedInSupervisorID, loggedInStudentID = null));
        }

        private void button_LOGOUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
