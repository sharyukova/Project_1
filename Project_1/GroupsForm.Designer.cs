namespace Project_1
{
    partial class GroupsForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.enterPic = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.scoresPic = new System.Windows.Forms.PictureBox();
            this.openScoresButton = new System.Windows.Forms.Button();
            this.groupsPic = new System.Windows.Forms.PictureBox();
            this.openGroupsButton = new System.Windows.Forms.Button();
            this.schedulePic = new System.Windows.Forms.PictureBox();
            this.openSchedButton = new System.Windows.Forms.Button();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.studDataGridView = new System.Windows.Forms.DataGridView();
            this.addStudButton = new System.Windows.Forms.Button();
            this.updateStudButton = new System.Windows.Forms.Button();
            this.editStudButton = new System.Windows.Forms.Button();
            this.deleteStudButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePic)).BeginInit();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.enterPic);
            this.panel3.Controls.Add(this.returnButton);
            this.panel3.Controls.Add(this.scoresPic);
            this.panel3.Controls.Add(this.openScoresButton);
            this.panel3.Controls.Add(this.groupsPic);
            this.panel3.Controls.Add(this.openGroupsButton);
            this.panel3.Controls.Add(this.schedulePic);
            this.panel3.Controls.Add(this.openSchedButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1299, 91);
            this.panel3.TabIndex = 7;
            // 
            // enterPic
            // 
            this.enterPic.Image = global::Project_1.Properties.Resources._8725510_angle_left_b_icon;
            this.enterPic.Location = new System.Drawing.Point(61, 22);
            this.enterPic.Name = "enterPic";
            this.enterPic.Size = new System.Drawing.Size(51, 50);
            this.enterPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enterPic.TabIndex = 7;
            this.enterPic.TabStop = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.White;
            this.returnButton.BackgroundImage = global::Project_1.Properties.Resources._8726310_notes_icon;
            this.returnButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.returnButton.Location = new System.Drawing.Point(119, 22);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(128, 51);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Студенты";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.returnButton_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.returnButton_MouseLeave);
            // 
            // scoresPic
            // 
            this.scoresPic.Image = global::Project_1.Properties.Resources._8725409_book_open_icon;
            this.scoresPic.Location = new System.Drawing.Point(958, 20);
            this.scoresPic.Name = "scoresPic";
            this.scoresPic.Size = new System.Drawing.Size(51, 50);
            this.scoresPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scoresPic.TabIndex = 5;
            this.scoresPic.TabStop = false;
            // 
            // openScoresButton
            // 
            this.openScoresButton.BackColor = System.Drawing.Color.White;
            this.openScoresButton.BackgroundImage = global::Project_1.Properties.Resources._8726310_notes_icon;
            this.openScoresButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openScoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.openScoresButton.Location = new System.Drawing.Point(1016, 20);
            this.openScoresButton.Name = "openScoresButton";
            this.openScoresButton.Size = new System.Drawing.Size(128, 51);
            this.openScoresButton.TabIndex = 4;
            this.openScoresButton.Text = "Баллы";
            this.openScoresButton.UseVisualStyleBackColor = false;
            this.openScoresButton.Click += new System.EventHandler(this.openScoresButton_Click);
            this.openScoresButton.MouseEnter += new System.EventHandler(this.openScoresButton_MouseEnter);
            this.openScoresButton.MouseLeave += new System.EventHandler(this.openScoresButton_MouseLeave);
            // 
            // groupsPic
            // 
            this.groupsPic.Image = global::Project_1.Properties.Resources._8725474_book_reader_icon;
            this.groupsPic.Location = new System.Drawing.Point(716, 21);
            this.groupsPic.Name = "groupsPic";
            this.groupsPic.Size = new System.Drawing.Size(51, 50);
            this.groupsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groupsPic.TabIndex = 3;
            this.groupsPic.TabStop = false;
            // 
            // openGroupsButton
            // 
            this.openGroupsButton.BackColor = System.Drawing.Color.White;
            this.openGroupsButton.BackgroundImage = global::Project_1.Properties.Resources._8726310_notes_icon;
            this.openGroupsButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openGroupsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.openGroupsButton.Location = new System.Drawing.Point(774, 21);
            this.openGroupsButton.Name = "openGroupsButton";
            this.openGroupsButton.Size = new System.Drawing.Size(128, 51);
            this.openGroupsButton.TabIndex = 2;
            this.openGroupsButton.Text = "Группы";
            this.openGroupsButton.UseVisualStyleBackColor = false;
            this.openGroupsButton.Click += new System.EventHandler(this.openGroupsButton_Click);
            this.openGroupsButton.MouseEnter += new System.EventHandler(this.openGroupsButton_MouseEnter);
            this.openGroupsButton.MouseLeave += new System.EventHandler(this.openGroupsButton_MouseLeave);
            // 
            // schedulePic
            // 
            this.schedulePic.Image = global::Project_1.Properties.Resources._8725528_calendar_alt_icon;
            this.schedulePic.Location = new System.Drawing.Point(434, 20);
            this.schedulePic.Name = "schedulePic";
            this.schedulePic.Size = new System.Drawing.Size(51, 50);
            this.schedulePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.schedulePic.TabIndex = 1;
            this.schedulePic.TabStop = false;
            // 
            // openSchedButton
            // 
            this.openSchedButton.BackColor = System.Drawing.Color.White;
            this.openSchedButton.BackgroundImage = global::Project_1.Properties.Resources._8726310_notes_icon;
            this.openSchedButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openSchedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.openSchedButton.Location = new System.Drawing.Point(491, 22);
            this.openSchedButton.Name = "openSchedButton";
            this.openSchedButton.Size = new System.Drawing.Size(148, 51);
            this.openSchedButton.TabIndex = 0;
            this.openSchedButton.Text = "Расписание";
            this.openSchedButton.UseVisualStyleBackColor = false;
            this.openSchedButton.Click += new System.EventHandler(this.openSchedButton_Click);
            this.openSchedButton.MouseEnter += new System.EventHandler(this.openSchedButton_MouseEnter);
            this.openSchedButton.MouseLeave += new System.EventHandler(this.openSchedButton_MouseLeave);
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataPanel.Controls.Add(this.closeLabel);
            this.dataPanel.Controls.Add(this.dataLabel);
            this.dataPanel.Controls.Add(this.studDataGridView);
            this.dataPanel.Controls.Add(this.addStudButton);
            this.dataPanel.Controls.Add(this.updateStudButton);
            this.dataPanel.Controls.Add(this.editStudButton);
            this.dataPanel.Controls.Add(this.deleteStudButton);
            this.dataPanel.Location = new System.Drawing.Point(12, 106);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(1275, 650);
            this.dataPanel.TabIndex = 8;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.closeLabel.Location = new System.Drawing.Point(596, 620);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(92, 20);
            this.closeLabel.TabIndex = 17;
            this.closeLabel.Text = "закрыть х";
            this.closeLabel.UseWaitCursor = true;
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.dataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.dataLabel.Location = new System.Drawing.Point(15, 21);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(197, 38);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "Список групп";
            // 
            // studDataGridView
            // 
            this.studDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.studDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studDataGridView.Location = new System.Drawing.Point(21, 78);
            this.studDataGridView.Name = "studDataGridView";
            this.studDataGridView.RowHeadersWidth = 51;
            this.studDataGridView.RowTemplate.Height = 24;
            this.studDataGridView.Size = new System.Drawing.Size(1234, 539);
            this.studDataGridView.TabIndex = 0;
            // 
            // addStudButton
            // 
            this.addStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.addStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudButton.ForeColor = System.Drawing.Color.White;
            this.addStudButton.Location = new System.Drawing.Point(838, 29);
            this.addStudButton.Name = "addStudButton";
            this.addStudButton.Size = new System.Drawing.Size(119, 32);
            this.addStudButton.TabIndex = 13;
            this.addStudButton.Text = "Добавить";
            this.addStudButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addStudButton.UseVisualStyleBackColor = false;
            // 
            // updateStudButton
            // 
            this.updateStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.updateStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateStudButton.ForeColor = System.Drawing.Color.White;
            this.updateStudButton.Location = new System.Drawing.Point(689, 29);
            this.updateStudButton.Name = "updateStudButton";
            this.updateStudButton.Size = new System.Drawing.Size(119, 32);
            this.updateStudButton.TabIndex = 14;
            this.updateStudButton.Text = "Обновить";
            this.updateStudButton.UseVisualStyleBackColor = false;
            // 
            // editStudButton
            // 
            this.editStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.editStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStudButton.ForeColor = System.Drawing.Color.White;
            this.editStudButton.Location = new System.Drawing.Point(989, 29);
            this.editStudButton.Name = "editStudButton";
            this.editStudButton.Size = new System.Drawing.Size(119, 32);
            this.editStudButton.TabIndex = 15;
            this.editStudButton.Text = "Изменить";
            this.editStudButton.UseVisualStyleBackColor = false;
            // 
            // deleteStudButton
            // 
            this.deleteStudButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.deleteStudButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStudButton.ForeColor = System.Drawing.Color.White;
            this.deleteStudButton.Location = new System.Drawing.Point(1137, 29);
            this.deleteStudButton.Name = "deleteStudButton";
            this.deleteStudButton.Size = new System.Drawing.Size(119, 32);
            this.deleteStudButton.TabIndex = 16;
            this.deleteStudButton.Text = "Удалить";
            this.deleteStudButton.UseVisualStyleBackColor = false;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_1.Properties.Resources.background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 768);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupsForm";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulePic)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox enterPic;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.PictureBox scoresPic;
        private System.Windows.Forms.Button openScoresButton;
        private System.Windows.Forms.PictureBox groupsPic;
        private System.Windows.Forms.Button openGroupsButton;
        private System.Windows.Forms.PictureBox schedulePic;
        private System.Windows.Forms.Button openSchedButton;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.DataGridView studDataGridView;
        private System.Windows.Forms.Button addStudButton;
        private System.Windows.Forms.Button updateStudButton;
        private System.Windows.Forms.Button editStudButton;
        private System.Windows.Forms.Button deleteStudButton;
    }
}