namespace deliverable_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_managegroup = new System.Windows.Forms.Button();
            this.button_groupdetails = new System.Windows.Forms.Button();
            this.button_meeting = new System.Windows.Forms.Button();
            this.button_Announcements = new System.Windows.Forms.Button();
            this.panel_groupsubmenu = new System.Windows.Forms.Panel();
            this.searchbutton = new System.Windows.Forms.Button();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_makeannouncement = new System.Windows.Forms.Button();
            this.panel_AnnounceSubmenu = new System.Windows.Forms.Panel();
            this.button_viewall = new System.Windows.Forms.Button();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.buttonxchat = new System.Windows.Forms.Button();
            this.panel_EVALUATIONsubmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonenterevaluation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_evaluation = new System.Windows.Forms.Button();
            this.panel_home = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_LOGOUT = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_groupsubmenu.SuspendLayout();
            this.panel_AnnounceSubmenu.SuspendLayout();
            this.panel_slide.SuspendLayout();
            this.panel_EVALUATIONsubmenu.SuspendLayout();
            this.panel_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(213, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(822, 504);
            this.panel_main.TabIndex = 5;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // panel_cover
            // 
            this.panel_cover.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_cover.Controls.Add(this.panel3);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(822, 504);
            this.panel_cover.TabIndex = 0;
            this.panel_cover.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cover_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.button_LOGOUT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 131);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 102);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::deliverable_1.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(255, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(253, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::deliverable_1.Properties.Resources.FYP;
            this.pictureBox2.Location = new System.Drawing.Point(173, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(421, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_managegroup
            // 
            this.button_managegroup.AutoSize = true;
            this.button_managegroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_managegroup.FlatAppearance.BorderSize = 0;
            this.button_managegroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_managegroup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_managegroup.ForeColor = System.Drawing.Color.White;
            this.button_managegroup.Location = new System.Drawing.Point(0, 156);
            this.button_managegroup.Margin = new System.Windows.Forms.Padding(5);
            this.button_managegroup.Name = "button_managegroup";
            this.button_managegroup.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_managegroup.Size = new System.Drawing.Size(196, 50);
            this.button_managegroup.TabIndex = 1;
            this.button_managegroup.Text = "Manage Groups";
            this.button_managegroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_managegroup.UseVisualStyleBackColor = true;
            this.button_managegroup.Click += new System.EventHandler(this.button_managegroup_Click);
            // 
            // button_groupdetails
            // 
            this.button_groupdetails.BackColor = System.Drawing.Color.SkyBlue;
            this.button_groupdetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_groupdetails.FlatAppearance.BorderSize = 0;
            this.button_groupdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_groupdetails.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_groupdetails.ForeColor = System.Drawing.Color.White;
            this.button_groupdetails.Location = new System.Drawing.Point(0, 50);
            this.button_groupdetails.Name = "button_groupdetails";
            this.button_groupdetails.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_groupdetails.Size = new System.Drawing.Size(196, 50);
            this.button_groupdetails.TabIndex = 1;
            this.button_groupdetails.Text = "View Groups Detail";
            this.button_groupdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_groupdetails.UseVisualStyleBackColor = false;
            this.button_groupdetails.Click += new System.EventHandler(this.button_groupdetails_Click);
            // 
            // button_meeting
            // 
            this.button_meeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_meeting.FlatAppearance.BorderSize = 0;
            this.button_meeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_meeting.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_meeting.ForeColor = System.Drawing.Color.White;
            this.button_meeting.Location = new System.Drawing.Point(0, 518);
            this.button_meeting.Margin = new System.Windows.Forms.Padding(5);
            this.button_meeting.Name = "button_meeting";
            this.button_meeting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_meeting.Size = new System.Drawing.Size(196, 50);
            this.button_meeting.TabIndex = 4;
            this.button_meeting.Text = "Schedule Meeting";
            this.button_meeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_meeting.UseVisualStyleBackColor = true;
            this.button_meeting.Click += new System.EventHandler(this.button_Announcements_Click);
            // 
            // button_Announcements
            // 
            this.button_Announcements.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Announcements.FlatAppearance.BorderSize = 0;
            this.button_Announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Announcements.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Announcements.ForeColor = System.Drawing.Color.White;
            this.button_Announcements.Location = new System.Drawing.Point(0, 356);
            this.button_Announcements.Margin = new System.Windows.Forms.Padding(5);
            this.button_Announcements.Name = "button_Announcements";
            this.button_Announcements.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Announcements.Size = new System.Drawing.Size(196, 50);
            this.button_Announcements.TabIndex = 3;
            this.button_Announcements.Text = "Announcements";
            this.button_Announcements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Announcements.UseVisualStyleBackColor = true;
            this.button_Announcements.Click += new System.EventHandler(this.button_meeting_Click);
            // 
            // panel_groupsubmenu
            // 
            this.panel_groupsubmenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_groupsubmenu.Controls.Add(this.searchbutton);
            this.panel_groupsubmenu.Controls.Add(this.button_groupdetails);
            this.panel_groupsubmenu.Controls.Add(this.button_registration);
            this.panel_groupsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_groupsubmenu.Location = new System.Drawing.Point(0, 206);
            this.panel_groupsubmenu.Name = "panel_groupsubmenu";
            this.panel_groupsubmenu.Size = new System.Drawing.Size(196, 150);
            this.panel_groupsubmenu.TabIndex = 2;
            this.panel_groupsubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_groupsubmenu_Paint);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.SkyBlue;
            this.searchbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.Color.White;
            this.searchbutton.Location = new System.Drawing.Point(0, 100);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.searchbutton.Size = new System.Drawing.Size(196, 48);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search Groups";
            this.searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.SkyBlue;
            this.button_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.Location = new System.Drawing.Point(0, 0);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(196, 50);
            this.button_registration.TabIndex = 0;
            this.button_registration.Text = "Register Group";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_makeannouncement
            // 
            this.button_makeannouncement.BackColor = System.Drawing.Color.SkyBlue;
            this.button_makeannouncement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_makeannouncement.FlatAppearance.BorderSize = 0;
            this.button_makeannouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_makeannouncement.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_makeannouncement.ForeColor = System.Drawing.Color.White;
            this.button_makeannouncement.Location = new System.Drawing.Point(0, 0);
            this.button_makeannouncement.Name = "button_makeannouncement";
            this.button_makeannouncement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_makeannouncement.Size = new System.Drawing.Size(196, 50);
            this.button_makeannouncement.TabIndex = 0;
            this.button_makeannouncement.Text = "Make Announcement";
            this.button_makeannouncement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_makeannouncement.UseVisualStyleBackColor = false;
            this.button_makeannouncement.Click += new System.EventHandler(this.button_makeannouncement_Click);
            // 
            // panel_AnnounceSubmenu
            // 
            this.panel_AnnounceSubmenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_AnnounceSubmenu.Controls.Add(this.button_viewall);
            this.panel_AnnounceSubmenu.Controls.Add(this.button_makeannouncement);
            this.panel_AnnounceSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_AnnounceSubmenu.Location = new System.Drawing.Point(0, 406);
            this.panel_AnnounceSubmenu.Name = "panel_AnnounceSubmenu";
            this.panel_AnnounceSubmenu.Size = new System.Drawing.Size(196, 112);
            this.panel_AnnounceSubmenu.TabIndex = 5;
            this.panel_AnnounceSubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_AnnounceSubmenu_Paint);
            // 
            // button_viewall
            // 
            this.button_viewall.BackColor = System.Drawing.Color.SkyBlue;
            this.button_viewall.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_viewall.FlatAppearance.BorderSize = 0;
            this.button_viewall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_viewall.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewall.ForeColor = System.Drawing.Color.White;
            this.button_viewall.Location = new System.Drawing.Point(0, 50);
            this.button_viewall.Name = "button_viewall";
            this.button_viewall.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_viewall.Size = new System.Drawing.Size(196, 55);
            this.button_viewall.TabIndex = 1;
            this.button_viewall.Text = "View All Announcements";
            this.button_viewall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_viewall.UseVisualStyleBackColor = false;
            this.button_viewall.Click += new System.EventHandler(this.button_viewall_Click);
            // 
            // panel_slide
            // 
            this.panel_slide.AutoScroll = true;
            this.panel_slide.BackColor = System.Drawing.Color.Navy;
            this.panel_slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_slide.Controls.Add(this.buttonxchat);
            this.panel_slide.Controls.Add(this.panel_EVALUATIONsubmenu);
            this.panel_slide.Controls.Add(this.button_evaluation);
            this.panel_slide.Controls.Add(this.button_meeting);
            this.panel_slide.Controls.Add(this.panel_AnnounceSubmenu);
            this.panel_slide.Controls.Add(this.button_Announcements);
            this.panel_slide.Controls.Add(this.panel_groupsubmenu);
            this.panel_slide.Controls.Add(this.button_managegroup);
            this.panel_slide.Controls.Add(this.panel_home);
            this.panel_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Margin = new System.Windows.Forms.Padding(5);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(213, 504);
            this.panel_slide.TabIndex = 4;
            this.panel_slide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_slide_Paint);
            // 
            // buttonxchat
            // 
            this.buttonxchat.BackColor = System.Drawing.Color.Navy;
            this.buttonxchat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonxchat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonxchat.FlatAppearance.BorderSize = 0;
            this.buttonxchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonxchat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxchat.ForeColor = System.Drawing.Color.White;
            this.buttonxchat.Location = new System.Drawing.Point(0, 718);
            this.buttonxchat.Margin = new System.Windows.Forms.Padding(5);
            this.buttonxchat.Name = "buttonxchat";
            this.buttonxchat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonxchat.Size = new System.Drawing.Size(196, 50);
            this.buttonxchat.TabIndex = 8;
            this.buttonxchat.Text = "Chat";
            this.buttonxchat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxchat.UseVisualStyleBackColor = false;
            this.buttonxchat.Click += new System.EventHandler(this.buttonxchat_Click_1);
            // 
            // panel_EVALUATIONsubmenu
            // 
            this.panel_EVALUATIONsubmenu.AutoScroll = true;
            this.panel_EVALUATIONsubmenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_EVALUATIONsubmenu.Controls.Add(this.button2);
            this.panel_EVALUATIONsubmenu.Controls.Add(this.buttonenterevaluation);
            this.panel_EVALUATIONsubmenu.Controls.Add(this.label1);
            this.panel_EVALUATIONsubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_EVALUATIONsubmenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel_EVALUATIONsubmenu.Location = new System.Drawing.Point(0, 618);
            this.panel_EVALUATIONsubmenu.Name = "panel_EVALUATIONsubmenu";
            this.panel_EVALUATIONsubmenu.Size = new System.Drawing.Size(196, 100);
            this.panel_EVALUATIONsubmenu.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "View All Evaluations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonenterevaluation
            // 
            this.buttonenterevaluation.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonenterevaluation.FlatAppearance.BorderSize = 0;
            this.buttonenterevaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonenterevaluation.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonenterevaluation.ForeColor = System.Drawing.Color.White;
            this.buttonenterevaluation.Location = new System.Drawing.Point(0, 0);
            this.buttonenterevaluation.Name = "buttonenterevaluation";
            this.buttonenterevaluation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonenterevaluation.Size = new System.Drawing.Size(196, 50);
            this.buttonenterevaluation.TabIndex = 0;
            this.buttonenterevaluation.Text = "Enter Evaluations";
            this.buttonenterevaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonenterevaluation.UseVisualStyleBackColor = true;
            this.buttonenterevaluation.Click += new System.EventHandler(this.buttonenterevaluation_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button_evaluation
            // 
            this.button_evaluation.AllowDrop = true;
            this.button_evaluation.BackColor = System.Drawing.Color.Navy;
            this.button_evaluation.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_evaluation.FlatAppearance.BorderSize = 0;
            this.button_evaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_evaluation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_evaluation.ForeColor = System.Drawing.Color.White;
            this.button_evaluation.Location = new System.Drawing.Point(0, 568);
            this.button_evaluation.Margin = new System.Windows.Forms.Padding(5);
            this.button_evaluation.Name = "button_evaluation";
            this.button_evaluation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_evaluation.Size = new System.Drawing.Size(196, 50);
            this.button_evaluation.TabIndex = 6;
            this.button_evaluation.Text = "Evaluations";
            this.button_evaluation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_evaluation.UseVisualStyleBackColor = false;
            this.button_evaluation.Click += new System.EventHandler(this.button_evaluation_Click);
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.Navy;
            this.panel_home.Controls.Add(this.pictureBox1);
            this.panel_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_home.Location = new System.Drawing.Point(0, 0);
            this.panel_home.Margin = new System.Windows.Forms.Padding(5);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(196, 156);
            this.panel_home.TabIndex = 0;
            this.panel_home.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_home_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::deliverable_1.Properties.Resources.home_button;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_LOGOUT
            // 
            this.button_LOGOUT.Location = new System.Drawing.Point(348, 60);
            this.button_LOGOUT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_LOGOUT.Name = "button_LOGOUT";
            this.button_LOGOUT.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_LOGOUT.Size = new System.Drawing.Size(97, 38);
            this.button_LOGOUT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_LOGOUT.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_LOGOUT.StateCommon.Back.ColorAngle = 45F;
            this.button_LOGOUT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_LOGOUT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_LOGOUT.StateCommon.Border.ColorAngle = 45F;
            this.button_LOGOUT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_LOGOUT.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_LOGOUT.StateCommon.Border.Rounding = 20;
            this.button_LOGOUT.StateCommon.Border.Width = 1;
            this.button_LOGOUT.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.button_LOGOUT.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_LOGOUT.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_LOGOUT.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LOGOUT.TabIndex = 46;
            this.button_LOGOUT.Values.Text = "Logout";
            this.button_LOGOUT.Click += new System.EventHandler(this.button_LOGOUT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1035, 504);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_slide);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_groupsubmenu.ResumeLayout(false);
            this.panel_AnnounceSubmenu.ResumeLayout(false);
            this.panel_slide.ResumeLayout(false);
            this.panel_slide.PerformLayout();
            this.panel_EVALUATIONsubmenu.ResumeLayout(false);
            this.panel_EVALUATIONsubmenu.PerformLayout();
            this.panel_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_managegroup;
        private System.Windows.Forms.Button button_groupdetails;
        private System.Windows.Forms.Button button_meeting;
        private System.Windows.Forms.Button button_Announcements;
        private System.Windows.Forms.Panel panel_groupsubmenu;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_makeannouncement;
        private System.Windows.Forms.Panel panel_AnnounceSubmenu;
        private System.Windows.Forms.Button button_viewall;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button button_evaluation;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Panel panel_EVALUATIONsubmenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonenterevaluation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonxchat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_LOGOUT;
    }
}