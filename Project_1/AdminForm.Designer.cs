namespace Project_1
{
    partial class AdminForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataLabel = new System.Windows.Forms.Label();
            this.studDataGridView = new System.Windows.Forms.DataGridView();
            this.editPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.passwField = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteStudButton = new System.Windows.Forms.Button();
            this.clearStudButton = new System.Windows.Forms.Button();
            this.updateStudButton = new System.Windows.Forms.Button();
            this.addStudButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.phonenumLabel = new System.Windows.Forms.Label();
            this.genderField = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.patronymicField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secnameField = new System.Windows.Forms.TextBox();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).BeginInit();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 91);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.editPanel);
            this.panel2.Controls.Add(this.dataPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 650);
            this.panel2.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataPanel.Controls.Add(this.dataLabel);
            this.dataPanel.Controls.Add(this.studDataGridView);
            this.dataPanel.Location = new System.Drawing.Point(12, 17);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1275, 360);
            this.dataPanel.TabIndex = 3;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.dataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.dataLabel.Location = new System.Drawing.Point(15, 21);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(283, 38);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "Данные о студентах";
            // 
            // studDataGridView
            // 
            this.studDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.studDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDataGridView.Location = new System.Drawing.Point(22, 73);
            this.studDataGridView.Name = "studDataGridView";
            this.studDataGridView.RowHeadersWidth = 51;
            this.studDataGridView.RowTemplate.Height = 24;
            this.studDataGridView.Size = new System.Drawing.Size(1234, 272);
            this.studDataGridView.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editPanel.Controls.Add(this.closeLabel);
            this.editPanel.Controls.Add(this.passwField);
            this.editPanel.Controls.Add(this.textBox5);
            this.editPanel.Controls.Add(this.usernameLabel);
            this.editPanel.Controls.Add(this.usernameField);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.deleteStudButton);
            this.editPanel.Controls.Add(this.clearStudButton);
            this.editPanel.Controls.Add(this.updateStudButton);
            this.editPanel.Controls.Add(this.addStudButton);
            this.editPanel.Controls.Add(this.textBox1);
            this.editPanel.Controls.Add(this.phonenumLabel);
            this.editPanel.Controls.Add(this.genderField);
            this.editPanel.Controls.Add(this.textBox3);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.genderLabel);
            this.editPanel.Controls.Add(this.patronymicField);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.secnameField);
            this.editPanel.Controls.Add(this.secondNameLabel);
            this.editPanel.Controls.Add(this.firstnameField);
            this.editPanel.Controls.Add(this.nameLabel);
            this.editPanel.Location = new System.Drawing.Point(12, 383);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1275, 254);
            this.editPanel.TabIndex = 4;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.closeLabel.Location = new System.Drawing.Point(619, 223);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(92, 20);
            this.closeLabel.TabIndex = 22;
            this.closeLabel.Text = "закрыть х";
            this.closeLabel.UseWaitCursor = true;
            // 
            // passwField
            // 
            this.passwField.BackColor = System.Drawing.SystemColors.Window;
            this.passwField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.passwField.Location = new System.Drawing.Point(1074, 206);
            this.passwField.Name = "passwField";
            this.passwField.Size = new System.Drawing.Size(185, 24);
            this.passwField.TabIndex = 21;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.textBox5.Location = new System.Drawing.Point(1586, 143);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 24);
            this.textBox5.TabIndex = 20;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.2F);
            this.usernameLabel.Location = new System.Drawing.Point(1009, 156);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 21);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "Логин:";
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.SystemColors.Window;
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.usernameField.Location = new System.Drawing.Point(1074, 153);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(185, 24);
            this.usernameField.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.2F);
            this.label4.Location = new System.Drawing.Point(1000, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Пароль:";
            // 
            // deleteStudButton
            // 
            this.deleteStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.deleteStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStudButton.ForeColor = System.Drawing.Color.White;
            this.deleteStudButton.Location = new System.Drawing.Point(1115, 81);
            this.deleteStudButton.Name = "deleteStudButton";
            this.deleteStudButton.Size = new System.Drawing.Size(119, 32);
            this.deleteStudButton.TabIndex = 16;
            this.deleteStudButton.Text = "Удалить";
            this.deleteStudButton.UseVisualStyleBackColor = false;
            // 
            // clearStudButton
            // 
            this.clearStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.clearStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearStudButton.ForeColor = System.Drawing.Color.White;
            this.clearStudButton.Location = new System.Drawing.Point(1115, 33);
            this.clearStudButton.Name = "clearStudButton";
            this.clearStudButton.Size = new System.Drawing.Size(119, 32);
            this.clearStudButton.TabIndex = 15;
            this.clearStudButton.Text = "Очистить";
            this.clearStudButton.UseVisualStyleBackColor = false;
            // 
            // updateStudButton
            // 
            this.updateStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.updateStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStudButton.ForeColor = System.Drawing.Color.White;
            this.updateStudButton.Location = new System.Drawing.Point(963, 81);
            this.updateStudButton.Name = "updateStudButton";
            this.updateStudButton.Size = new System.Drawing.Size(119, 32);
            this.updateStudButton.TabIndex = 14;
            this.updateStudButton.Text = "Обновить";
            this.updateStudButton.UseVisualStyleBackColor = false;
            // 
            // addStudButton
            // 
            this.addStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.addStudButton.Enabled = false;
            this.addStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudButton.ForeColor = System.Drawing.Color.White;
            this.addStudButton.Location = new System.Drawing.Point(963, 33);
            this.addStudButton.Name = "addStudButton";
            this.addStudButton.Size = new System.Drawing.Size(119, 32);
            this.addStudButton.TabIndex = 13;
            this.addStudButton.Text = "Добавить";
            this.addStudButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addStudButton.UseVisualStyleBackColor = false;
            this.addStudButton.Click += new System.EventHandler(this.addStudButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.textBox1.Location = new System.Drawing.Point(623, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 24);
            this.textBox1.TabIndex = 12;
            // 
            // phonenumLabel
            // 
            this.phonenumLabel.AutoSize = true;
            this.phonenumLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.2F);
            this.phonenumLabel.Location = new System.Drawing.Point(484, 156);
            this.phonenumLabel.Name = "phonenumLabel";
            this.phonenumLabel.Size = new System.Drawing.Size(133, 21);
            this.phonenumLabel.TabIndex = 11;
            this.phonenumLabel.Text = "Номер телефона:";
            // 
            // genderField
            // 
            this.genderField.FormattingEnabled = true;
            this.genderField.Items.AddRange(new object[] {
            "женский",
            "мужской"});
            this.genderField.Location = new System.Drawing.Point(154, 208);
            this.genderField.Name = "genderField";
            this.genderField.Size = new System.Drawing.Size(240, 24);
            this.genderField.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.textBox3.Location = new System.Drawing.Point(623, 32);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 90);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(556, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Адрес:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(103, 208);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 23);
            this.genderLabel.TabIndex = 6;
            this.genderLabel.Text = "Пол:";
            // 
            // patronymicField
            // 
            this.patronymicField.BackColor = System.Drawing.SystemColors.Window;
            this.patronymicField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patronymicField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.patronymicField.Location = new System.Drawing.Point(154, 146);
            this.patronymicField.Name = "patronymicField";
            this.patronymicField.Size = new System.Drawing.Size(240, 24);
            this.patronymicField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.2F);
            this.label2.Location = new System.Drawing.Point(33, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Отчество \r\n(при наличии):";
            // 
            // secnameField
            // 
            this.secnameField.BackColor = System.Drawing.SystemColors.Window;
            this.secnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.secnameField.Location = new System.Drawing.Point(154, 81);
            this.secnameField.Name = "secnameField";
            this.secnameField.Size = new System.Drawing.Size(240, 24);
            this.secnameField.TabIndex = 3;
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameLabel.Location = new System.Drawing.Point(63, 81);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(85, 23);
            this.secondNameLabel.TabIndex = 2;
            this.secondNameLabel.Text = "Фамилия:";
            // 
            // firstnameField
            // 
            this.firstnameField.BackColor = System.Drawing.SystemColors.Window;
            this.firstnameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.firstnameField.Location = new System.Drawing.Point(154, 33);
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Size = new System.Drawing.Size(240, 24);
            this.firstnameField.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(100, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Имя:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.panel2.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).EndInit();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DataGridView studDataGridView;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.TextBox passwField;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteStudButton;
        private System.Windows.Forms.Button clearStudButton;
        private System.Windows.Forms.Button updateStudButton;
        private System.Windows.Forms.Button addStudButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label phonenumLabel;
        private System.Windows.Forms.ComboBox genderField;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox patronymicField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secnameField;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox firstnameField;
        private System.Windows.Forms.Label nameLabel;
    }
}