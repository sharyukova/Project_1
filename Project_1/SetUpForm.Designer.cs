namespace Project_1
{
    partial class SetUpForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameField = new System.Windows.Forms.TextBox();
            this.surnameField = new System.Windows.Forms.TextBox();
            this.patronymicField = new System.Windows.Forms.TextBox();
            this.dateofbirthField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwField = new System.Windows.Forms.TextBox();
            this.phoneNumField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 170);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(266, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.phoneNumField);
            this.panel2.Controls.Add(this.passwField);
            this.panel2.Controls.Add(this.loginField);
            this.panel2.Controls.Add(this.dateofbirthField);
            this.panel2.Controls.Add(this.patronymicField);
            this.panel2.Controls.Add(this.surnameField);
            this.panel2.Controls.Add(this.nameField);
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 594);
            this.panel2.TabIndex = 1;
            // 
            // nameField
            // 
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(41, 66);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(350, 27);
            this.nameField.TabIndex = 0;
            // 
            // surnameField
            // 
            this.surnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameField.Location = new System.Drawing.Point(41, 122);
            this.surnameField.Name = "surnameField";
            this.surnameField.Size = new System.Drawing.Size(350, 27);
            this.surnameField.TabIndex = 1;
            // 
            // patronymicField
            // 
            this.patronymicField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patronymicField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronymicField.Location = new System.Drawing.Point(41, 194);
            this.patronymicField.Name = "patronymicField";
            this.patronymicField.Size = new System.Drawing.Size(350, 27);
            this.patronymicField.TabIndex = 2;
            // 
            // dateofbirthField
            // 
            this.dateofbirthField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateofbirthField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthField.Location = new System.Drawing.Point(41, 266);
            this.dateofbirthField.Name = "dateofbirthField";
            this.dateofbirthField.Size = new System.Drawing.Size(350, 27);
            this.dateofbirthField.TabIndex = 3;
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(501, 66);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(350, 27);
            this.loginField.TabIndex = 4;
            // 
            // passwField
            // 
            this.passwField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwField.Location = new System.Drawing.Point(501, 122);
            this.passwField.Name = "passwField";
            this.passwField.Size = new System.Drawing.Size(350, 27);
            this.passwField.TabIndex = 5;
            // 
            // phoneNumField
            // 
            this.phoneNumField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumField.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumField.Location = new System.Drawing.Point(501, 194);
            this.phoneNumField.Name = "phoneNumField";
            this.phoneNumField.Size = new System.Drawing.Size(350, 27);
            this.phoneNumField.TabIndex = 6;
            // 
            // SetUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SetUpForm";
            this.Text = "SetUpForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateofbirthField;
        private System.Windows.Forms.TextBox patronymicField;
        private System.Windows.Forms.TextBox surnameField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox phoneNumField;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.TextBox loginField;
    }
}