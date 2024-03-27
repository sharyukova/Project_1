namespace Project_1
{
    partial class SetInForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.setInButton = new System.Windows.Forms.Button();
            this.showPaswBox = new System.Windows.Forms.CheckBox();
            this.setUpLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.passwField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 147);
            this.panel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.titleLabel.Location = new System.Drawing.Point(130, 59);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(442, 50);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Войти в учетную запись";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.setInButton);
            this.panel3.Controls.Add(this.showPaswBox);
            this.panel3.Controls.Add(this.setUpLabel);
            this.panel3.Controls.Add(this.closeLabel);
            this.panel3.Controls.Add(this.passwField);
            this.panel3.Controls.Add(this.usernameField);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 526);
            this.panel3.TabIndex = 1;
            // 
            // setInButton
            // 
            this.setInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.setInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setInButton.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setInButton.Location = new System.Drawing.Point(239, 352);
            this.setInButton.Name = "setInButton";
            this.setInButton.Size = new System.Drawing.Size(203, 56);
            this.setInButton.TabIndex = 8;
            this.setInButton.Text = "Войти";
            this.setInButton.UseVisualStyleBackColor = false;
            this.setInButton.Click += new System.EventHandler(this.setInButton_Click);
            // 
            // showPaswBox
            // 
            this.showPaswBox.AutoSize = true;
            this.showPaswBox.BackColor = System.Drawing.Color.Transparent;
            this.showPaswBox.Font = new System.Drawing.Font("Yu Gothic UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPaswBox.Location = new System.Drawing.Point(438, 273);
            this.showPaswBox.Name = "showPaswBox";
            this.showPaswBox.Size = new System.Drawing.Size(134, 21);
            this.showPaswBox.TabIndex = 7;
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
            this.setUpLabel.Location = new System.Drawing.Point(268, 428);
            this.setUpLabel.Name = "setUpLabel";
            this.setUpLabel.Size = new System.Drawing.Size(142, 23);
            this.setUpLabel.TabIndex = 6;
            this.setUpLabel.Text = "Войти как админ";
            this.setUpLabel.Click += new System.EventHandler(this.setUpLabel_Click);
            this.setUpLabel.MouseEnter += new System.EventHandler(this.setUpLabel_MouseEnter);
            this.setUpLabel.MouseLeave += new System.EventHandler(this.setUpLabel_MouseLeave);
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.closeLabel.Location = new System.Drawing.Point(296, 466);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(92, 20);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "закрыть х";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // passwField
            // 
            this.passwField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwField.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwField.Location = new System.Drawing.Point(239, 197);
            this.passwField.Name = "passwField";
            this.passwField.PasswordChar = '*';
            this.passwField.Size = new System.Drawing.Size(333, 33);
            this.passwField.TabIndex = 3;
            // 
            // usernameField
            // 
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(239, 66);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(333, 33);
            this.usernameField.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Project_1.Properties.Resources._8726549_user_square_icon;
            this.pictureBox2.Location = new System.Drawing.Point(105, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project_1.Properties.Resources._8726020_lock_alt_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(105, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 400);
            this.panel2.TabIndex = 1;
            // 
            // SetInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 671);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetInForm";
            this.Text = "SetInForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label setUpLabel;
        private System.Windows.Forms.CheckBox showPaswBox;
        private System.Windows.Forms.Button setInButton;
    }
}