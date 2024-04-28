namespace deliverable_1
{
    partial class ViewAnouncements
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cancelbutton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deliverable_1.Properties.Resources.icons8_announcement_50;
            this.pictureBox1.Location = new System.Drawing.Point(265, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_Announcements
            // 
            this.label_Announcements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Announcements.AutoSize = true;
            this.label_Announcements.BackColor = System.Drawing.Color.Navy;
            this.label_Announcements.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Announcements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_Announcements.Location = new System.Drawing.Point(321, 15);
            this.label_Announcements.Name = "label_Announcements";
            this.label_Announcements.Size = new System.Drawing.Size(175, 26);
            this.label_Announcements.TabIndex = 0;
            this.label_Announcements.Text = "Announcements";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 315);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cancelbutton1
            // 
            this.cancelbutton1.Location = new System.Drawing.Point(326, 414);
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
            this.cancelbutton1.TabIndex = 46;
            this.cancelbutton1.Values.Text = "Cancel";
            this.cancelbutton1.Click += new System.EventHandler(this.cancelbutton1_Click);
            // 
            // ViewAnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cancelbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAnouncements";
            this.Text = "ViewAnouncements";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Announcements;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelbutton1;
    }
}