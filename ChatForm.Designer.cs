namespace deliverable_1
{
    partial class ChatForm
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
            this.chatdataGridView1 = new System.Windows.Forms.DataGridView();
            this.msgbox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelbutton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.chatdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chatdataGridView1
            // 
            this.chatdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.chatdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chatdataGridView1.Location = new System.Drawing.Point(135, 81);
            this.chatdataGridView1.Name = "chatdataGridView1";
            this.chatdataGridView1.Size = new System.Drawing.Size(441, 247);
            this.chatdataGridView1.TabIndex = 0;
            this.chatdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chatdataGridView1_CellContentClick);
            // 
            // msgbox
            // 
            this.msgbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msgbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgbox.Location = new System.Drawing.Point(135, 350);
            this.msgbox.Multiline = true;
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(405, 30);
            this.msgbox.TabIndex = 1;
            this.msgbox.TextChanged += new System.EventHandler(this.msgbox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.SkyBlue;
            this.SendButton.BackgroundImage = global::deliverable_1.Properties.Resources.send_button;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.SendButton.Location = new System.Drawing.Point(546, 350);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(30, 30);
            this.SendButton.TabIndex = 2;
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deliverable_1.Properties.Resources.icons8_chat_50;
            this.pictureBox1.Location = new System.Drawing.Point(266, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chat Inbox";
            // 
            // cancelbutton1
            // 
            this.cancelbutton1.Location = new System.Drawing.Point(327, 438);
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
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cancelbutton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.chatdataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chatdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView chatdataGridView1;
        private System.Windows.Forms.TextBox msgbox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelbutton1;
    }
}