namespace Project_1
{
    partial class SetInAdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.setInButton = new System.Windows.Forms.Button();
            this.showPaswBox = new System.Windows.Forms.CheckBox();
            this.setUpLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.passwField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 152);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(226, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход админа";
            // 
            // setInButton
            // 
            this.setInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.setInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setInButton.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setInButton.Location = new System.Drawing.Point(244, 513);
            this.setInButton.Name = "setInButton";
            this.setInButton.Size = new System.Drawing.Size(203, 56);
            this.setInButton.TabIndex = 16;
            this.setInButton.Text = "Войти";
            this.setInButton.UseVisualStyleBackColor = false;
            this.setInButton.Click += new System.EventHandler(this.setInButton_Click);
            // 
            // showPaswBox
            // 
            this.showPaswBox.AutoSize = true;
            this.showPaswBox.BackColor = System.Drawing.Color.Transparent;
            this.showPaswBox.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPaswBox.Location = new System.Drawing.Point(443, 434);
            this.showPaswBox.Name = "showPaswBox";
            this.showPaswBox.Size = new System.Drawing.Size(134, 21);
            this.showPaswBox.TabIndex = 15;
            this.showPaswBox.Text = "Показать пароль";
            this.showPaswBox.UseVisualStyleBackColor = false;
            this.showPaswBox.CheckedChanged += new System.EventHandler(this.showPaswBox_CheckedChanged);
            // 
            // setUpLabel
            // 
            this.setUpLabel.AutoSize = true;
            this.setUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.setUpLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setUpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.setUpLabel.Location = new System.Drawing.Point(273, 589);
            this.setUpLabel.Name = "setUpLabel";
            this.setUpLabel.Size = new System.Drawing.Size(150, 23);
            this.setUpLabel.TabIndex = 14;
            this.setUpLabel.Text = "Войти как студент";
            this.setUpLabel.Click += new System.EventHandler(this.setUpLabel_Click);
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.closeLabel.Location = new System.Drawing.Point(301, 627);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(92, 20);
            this.closeLabel.TabIndex = 13;
            this.closeLabel.Text = "закрыть х";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // passwField
            // 
            this.passwField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwField.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwField.Location = new System.Drawing.Point(244, 358);
            this.passwField.Name = "passwField";
            this.passwField.PasswordChar = '*';
            this.passwField.Size = new System.Drawing.Size(333, 33);
            this.passwField.TabIndex = 12;
            // 
            // usernameField
            // 
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(244, 227);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(333, 33);
            this.usernameField.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project_1.Properties.Resources._8726549_user_square_icon;
            this.pictureBox2.Location = new System.Drawing.Point(110, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_1.Properties.Resources._8726020_lock_alt_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(110, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SetInAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 676);
            this.Controls.Add(this.setInButton);
            this.Controls.Add(this.showPaswBox);
            this.Controls.Add(this.setUpLabel);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.passwField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetInAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetInAdminForm";
            this.Load += new System.EventHandler(this.SetInAdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setInButton;
        private System.Windows.Forms.CheckBox showPaswBox;
        private System.Windows.Forms.Label setUpLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}