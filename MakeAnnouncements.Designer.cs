namespace deliverable_1
{
    partial class MakeAnnouncements
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Announcements = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supervisoridbox = new System.Windows.Forms.TextBox();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.contentbox = new System.Windows.Forms.TextBox();
            this.button_add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelbutton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_Announcements);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deliverable_1.Properties.Resources.icons8_announcement_50;
            this.pictureBox1.Location = new System.Drawing.Point(216, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_Announcements
            // 
            this.label_Announcements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Announcements.AutoSize = true;
            this.label_Announcements.BackColor = System.Drawing.Color.Navy;
            this.label_Announcements.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Announcements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Announcements.Location = new System.Drawing.Point(272, 10);
            this.label_Announcements.Name = "label_Announcements";
            this.label_Announcements.Size = new System.Drawing.Size(230, 26);
            this.label_Announcements.TabIndex = 0;
            this.label_Announcements.Text = "Make Announcement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(98, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Supervisor ID/Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(98, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(98, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Content";
            // 
            // supervisoridbox
            // 
            this.supervisoridbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supervisoridbox.Location = new System.Drawing.Point(312, 134);
            this.supervisoridbox.Multiline = true;
            this.supervisoridbox.Name = "supervisoridbox";
            this.supervisoridbox.Size = new System.Drawing.Size(151, 22);
            this.supervisoridbox.TabIndex = 21;
            this.supervisoridbox.TextChanged += new System.EventHandler(this.supervisoridbox_TextChanged);
            // 
            // titlebox
            // 
            this.titlebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlebox.Location = new System.Drawing.Point(312, 178);
            this.titlebox.Multiline = true;
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(151, 22);
            this.titlebox.TabIndex = 21;
            this.titlebox.TextChanged += new System.EventHandler(this.supervisoridbox_TextChanged);
            // 
            // contentbox
            // 
            this.contentbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contentbox.Location = new System.Drawing.Point(312, 224);
            this.contentbox.Multiline = true;
            this.contentbox.Name = "contentbox";
            this.contentbox.Size = new System.Drawing.Size(332, 123);
            this.contentbox.TabIndex = 21;
            this.contentbox.TextChanged += new System.EventHandler(this.supervisoridbox_TextChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(373, 421);
            this.button_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_add.Name = "button_add";
            this.button_add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.button_add.Size = new System.Drawing.Size(90, 35);
            this.button_add.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_add.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_add.StateCommon.Back.ColorAngle = 45F;
            this.button_add.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.button_add.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.button_add.StateCommon.Border.ColorAngle = 45F;
            this.button_add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.button_add.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.button_add.StateCommon.Border.Rounding = 20;
            this.button_add.StateCommon.Border.Width = 1;
            this.button_add.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.button_add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button_add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button_add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.TabIndex = 44;
            this.button_add.Values.Text = "OK";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // cancelbutton1
            // 
            this.cancelbutton1.Location = new System.Drawing.Point(277, 421);
            this.cancelbutton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cancelbutton1.Name = "cancelbutton1";
            this.cancelbutton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.cancelbutton1.Size = new System.Drawing.Size(90, 35);
            this.cancelbutton1.StateCommon.Back.Color1 = System.Drawing.Color.Brown;
            this.cancelbutton1.StateCommon.Back.Color2 = System.Drawing.Color.Firebrick;
            this.cancelbutton1.StateCommon.Back.ColorAngle = 45F;
            this.cancelbutton1.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.cancelbutton1.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.cancelbutton1.StateCommon.Border.ColorAngle = 45F;
            this.cancelbutton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cancelbutton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cancelbutton1.StateCommon.Border.Rounding = 20;
            this.cancelbutton1.StateCommon.Border.Width = 1;
            this.cancelbutton1.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.cancelbutton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.cancelbutton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.cancelbutton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton1.TabIndex = 45;
            this.cancelbutton1.Values.Text = "Cancel";
            this.cancelbutton1.Click += new System.EventHandler(this.cancelbutton1_Click);
            // 
            // MakeAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cancelbutton1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.contentbox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.supervisoridbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MakeAnnouncements";
            this.Text = "MakeAnnouncements";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Announcements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supervisoridbox;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox contentbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton button_add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelbutton1;
    }
}