namespace StudentsDataBase
{
    partial class EditForm
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
            this.tabControlEdit = new System.Windows.Forms.TabControl();
            this.tabPageEditStud = new System.Windows.Forms.TabPage();
            this.textBoxStudBirthday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudPatronymic = new System.Windows.Forms.TextBox();
            this.labelStudPatronymic = new System.Windows.Forms.Label();
            this.textBoxStudName = new System.Windows.Forms.TextBox();
            this.labelStudName = new System.Windows.Forms.Label();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.labelStudTitle = new System.Windows.Forms.Label();
            this.textBoxStudSurname = new System.Windows.Forms.TextBox();
            this.labelStudSurname = new System.Windows.Forms.Label();
            this.labelStudGroup = new System.Windows.Forms.Label();
            this.comboBoxStudGroup = new System.Windows.Forms.ComboBox();
            this.tabPageEditGrp = new System.Windows.Forms.TabPage();
            this.comboBoxChooseGrp = new System.Windows.Forms.ComboBox();
            this.textBoxGrpCurator = new System.Windows.Forms.TextBox();
            this.labelGrpCurator = new System.Windows.Forms.Label();
            this.labelGrpOtdelenie = new System.Windows.Forms.Label();
            this.comboBoxGrpOtdelenie = new System.Windows.Forms.ComboBox();
            this.textBoxGrpFaculty = new System.Windows.Forms.TextBox();
            this.textBoxGrpName = new System.Windows.Forms.TextBox();
            this.labelGrpTitle = new System.Windows.Forms.Label();
            this.labelGrpName = new System.Windows.Forms.Label();
            this.labelGrpFaculty = new System.Windows.Forms.Label();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.tabPageEditOtd = new System.Windows.Forms.TabPage();
            this.comboBoxChooseOtd = new System.Windows.Forms.ComboBox();
            this.labelOtdTelephone = new System.Windows.Forms.Label();
            this.textBoxOtdTelephone = new System.Windows.Forms.TextBox();
            this.labelOtdTitle = new System.Windows.Forms.Label();
            this.labelOtdManager = new System.Windows.Forms.Label();
            this.textBoxOtdManager = new System.Windows.Forms.TextBox();
            this.buttonEditOtdelenie = new System.Windows.Forms.Button();
            this.tabControlEdit.SuspendLayout();
            this.tabPageEditStud.SuspendLayout();
            this.tabPageEditGrp.SuspendLayout();
            this.tabPageEditOtd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEdit
            // 
            this.tabControlEdit.Controls.Add(this.tabPageEditStud);
            this.tabControlEdit.Controls.Add(this.tabPageEditGrp);
            this.tabControlEdit.Controls.Add(this.tabPageEditOtd);
            this.tabControlEdit.Location = new System.Drawing.Point(-1, -2);
            this.tabControlEdit.Name = "tabControlEdit";
            this.tabControlEdit.SelectedIndex = 0;
            this.tabControlEdit.Size = new System.Drawing.Size(408, 372);
            this.tabControlEdit.TabIndex = 17;
            // 
            // tabPageEditStud
            // 
            this.tabPageEditStud.Controls.Add(this.textBoxStudBirthday);
            this.tabPageEditStud.Controls.Add(this.label1);
            this.tabPageEditStud.Controls.Add(this.textBoxStudPatronymic);
            this.tabPageEditStud.Controls.Add(this.labelStudPatronymic);
            this.tabPageEditStud.Controls.Add(this.textBoxStudName);
            this.tabPageEditStud.Controls.Add(this.labelStudName);
            this.tabPageEditStud.Controls.Add(this.buttonEditStudent);
            this.tabPageEditStud.Controls.Add(this.labelStudTitle);
            this.tabPageEditStud.Controls.Add(this.textBoxStudSurname);
            this.tabPageEditStud.Controls.Add(this.labelStudSurname);
            this.tabPageEditStud.Controls.Add(this.labelStudGroup);
            this.tabPageEditStud.Controls.Add(this.comboBoxStudGroup);
            this.tabPageEditStud.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditStud.Name = "tabPageEditStud";
            this.tabPageEditStud.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditStud.Size = new System.Drawing.Size(400, 343);
            this.tabPageEditStud.TabIndex = 0;
            this.tabPageEditStud.Text = "Студенты";
            this.tabPageEditStud.UseVisualStyleBackColor = true;
            // 
            // textBoxStudBirthday
            // 
            this.textBoxStudBirthday.Location = new System.Drawing.Point(194, 174);
            this.textBoxStudBirthday.Name = "textBoxStudBirthday";
            this.textBoxStudBirthday.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudBirthday.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дата рождения:";
            // 
            // textBoxStudPatronymic
            // 
            this.textBoxStudPatronymic.Location = new System.Drawing.Point(194, 142);
            this.textBoxStudPatronymic.Name = "textBoxStudPatronymic";
            this.textBoxStudPatronymic.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudPatronymic.TabIndex = 19;
            // 
            // labelStudPatronymic
            // 
            this.labelStudPatronymic.AutoSize = true;
            this.labelStudPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudPatronymic.Location = new System.Drawing.Point(77, 142);
            this.labelStudPatronymic.Name = "labelStudPatronymic";
            this.labelStudPatronymic.Size = new System.Drawing.Size(88, 18);
            this.labelStudPatronymic.TabIndex = 18;
            this.labelStudPatronymic.Text = "Отчество:";
            // 
            // textBoxStudName
            // 
            this.textBoxStudName.Location = new System.Drawing.Point(194, 112);
            this.textBoxStudName.Name = "textBoxStudName";
            this.textBoxStudName.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudName.TabIndex = 17;
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudName.Location = new System.Drawing.Point(116, 112);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(46, 18);
            this.labelStudName.TabIndex = 16;
            this.labelStudName.Text = "Имя:";
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditStudent.Location = new System.Drawing.Point(149, 274);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(107, 36);
            this.buttonEditStudent.TabIndex = 15;
            this.buttonEditStudent.Text = "Изменить";
            this.buttonEditStudent.UseVisualStyleBackColor = false;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // labelStudTitle
            // 
            this.labelStudTitle.AutoSize = true;
            this.labelStudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudTitle.Location = new System.Drawing.Point(99, 22);
            this.labelStudTitle.Name = "labelStudTitle";
            this.labelStudTitle.Size = new System.Drawing.Size(212, 18);
            this.labelStudTitle.TabIndex = 14;
            this.labelStudTitle.Text = "Редактирование студента";
            // 
            // textBoxStudSurname
            // 
            this.textBoxStudSurname.Location = new System.Drawing.Point(194, 79);
            this.textBoxStudSurname.Name = "textBoxStudSurname";
            this.textBoxStudSurname.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudSurname.TabIndex = 7;
            // 
            // labelStudSurname
            // 
            this.labelStudSurname.AutoSize = true;
            this.labelStudSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudSurname.Location = new System.Drawing.Point(77, 79);
            this.labelStudSurname.Name = "labelStudSurname";
            this.labelStudSurname.Size = new System.Drawing.Size(85, 18);
            this.labelStudSurname.TabIndex = 0;
            this.labelStudSurname.Text = "Фамилия:";
            // 
            // labelStudGroup
            // 
            this.labelStudGroup.AutoSize = true;
            this.labelStudGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudGroup.Location = new System.Drawing.Point(99, 207);
            this.labelStudGroup.Name = "labelStudGroup";
            this.labelStudGroup.Size = new System.Drawing.Size(67, 18);
            this.labelStudGroup.TabIndex = 1;
            this.labelStudGroup.Text = "Группа:";
            // 
            // comboBoxStudGroup
            // 
            this.comboBoxStudGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudGroup.FormattingEnabled = true;
            this.comboBoxStudGroup.Location = new System.Drawing.Point(192, 207);
            this.comboBoxStudGroup.Name = "comboBoxStudGroup";
            this.comboBoxStudGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudGroup.TabIndex = 8;
            // 
            // tabPageEditGrp
            // 
            this.tabPageEditGrp.Controls.Add(this.comboBoxChooseGrp);
            this.tabPageEditGrp.Controls.Add(this.textBoxGrpCurator);
            this.tabPageEditGrp.Controls.Add(this.labelGrpCurator);
            this.tabPageEditGrp.Controls.Add(this.labelGrpOtdelenie);
            this.tabPageEditGrp.Controls.Add(this.comboBoxGrpOtdelenie);
            this.tabPageEditGrp.Controls.Add(this.textBoxGrpFaculty);
            this.tabPageEditGrp.Controls.Add(this.textBoxGrpName);
            this.tabPageEditGrp.Controls.Add(this.labelGrpTitle);
            this.tabPageEditGrp.Controls.Add(this.labelGrpName);
            this.tabPageEditGrp.Controls.Add(this.labelGrpFaculty);
            this.tabPageEditGrp.Controls.Add(this.buttonEditGroup);
            this.tabPageEditGrp.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditGrp.Name = "tabPageEditGrp";
            this.tabPageEditGrp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditGrp.Size = new System.Drawing.Size(400, 343);
            this.tabPageEditGrp.TabIndex = 1;
            this.tabPageEditGrp.Text = "Группы";
            this.tabPageEditGrp.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseGrp
            // 
            this.comboBoxChooseGrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseGrp.FormattingEnabled = true;
            this.comboBoxChooseGrp.Location = new System.Drawing.Point(129, 55);
            this.comboBoxChooseGrp.Name = "comboBoxChooseGrp";
            this.comboBoxChooseGrp.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChooseGrp.TabIndex = 35;
            // 
            // textBoxGrpCurator
            // 
            this.textBoxGrpCurator.Location = new System.Drawing.Point(188, 185);
            this.textBoxGrpCurator.Name = "textBoxGrpCurator";
            this.textBoxGrpCurator.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpCurator.TabIndex = 28;
            // 
            // labelGrpCurator
            // 
            this.labelGrpCurator.AutoSize = true;
            this.labelGrpCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpCurator.Location = new System.Drawing.Point(62, 185);
            this.labelGrpCurator.Name = "labelGrpCurator";
            this.labelGrpCurator.Size = new System.Drawing.Size(77, 18);
            this.labelGrpCurator.TabIndex = 27;
            this.labelGrpCurator.Text = "Куратор:";
            // 
            // labelGrpOtdelenie
            // 
            this.labelGrpOtdelenie.AutoSize = true;
            this.labelGrpOtdelenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpOtdelenie.Location = new System.Drawing.Point(60, 224);
            this.labelGrpOtdelenie.Name = "labelGrpOtdelenie";
            this.labelGrpOtdelenie.Size = new System.Drawing.Size(99, 18);
            this.labelGrpOtdelenie.TabIndex = 25;
            this.labelGrpOtdelenie.Text = "Отделение:";
            // 
            // comboBoxGrpOtdelenie
            // 
            this.comboBoxGrpOtdelenie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrpOtdelenie.FormattingEnabled = true;
            this.comboBoxGrpOtdelenie.Location = new System.Drawing.Point(186, 224);
            this.comboBoxGrpOtdelenie.Name = "comboBoxGrpOtdelenie";
            this.comboBoxGrpOtdelenie.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGrpOtdelenie.TabIndex = 26;
            // 
            // textBoxGrpFaculty
            // 
            this.textBoxGrpFaculty.Location = new System.Drawing.Point(188, 153);
            this.textBoxGrpFaculty.Name = "textBoxGrpFaculty";
            this.textBoxGrpFaculty.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpFaculty.TabIndex = 24;
            // 
            // textBoxGrpName
            // 
            this.textBoxGrpName.Location = new System.Drawing.Point(188, 109);
            this.textBoxGrpName.Name = "textBoxGrpName";
            this.textBoxGrpName.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpName.TabIndex = 20;
            // 
            // labelGrpTitle
            // 
            this.labelGrpTitle.AutoSize = true;
            this.labelGrpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpTitle.Location = new System.Drawing.Point(101, 19);
            this.labelGrpTitle.Name = "labelGrpTitle";
            this.labelGrpTitle.Size = new System.Drawing.Size(196, 18);
            this.labelGrpTitle.TabIndex = 23;
            this.labelGrpTitle.Text = "Редактирование группы";
            // 
            // labelGrpName
            // 
            this.labelGrpName.AutoSize = true;
            this.labelGrpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpName.Location = new System.Drawing.Point(60, 113);
            this.labelGrpName.Name = "labelGrpName";
            this.labelGrpName.Size = new System.Drawing.Size(88, 18);
            this.labelGrpName.TabIndex = 17;
            this.labelGrpName.Text = "Название:";
            // 
            // labelGrpFaculty
            // 
            this.labelGrpFaculty.AutoSize = true;
            this.labelGrpFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpFaculty.Location = new System.Drawing.Point(62, 153);
            this.labelGrpFaculty.Name = "labelGrpFaculty";
            this.labelGrpFaculty.Size = new System.Drawing.Size(97, 18);
            this.labelGrpFaculty.TabIndex = 18;
            this.labelGrpFaculty.Text = "Факультет:";
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditGroup.Location = new System.Drawing.Point(143, 271);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(107, 36);
            this.buttonEditGroup.TabIndex = 16;
            this.buttonEditGroup.Text = "Изменить";
            this.buttonEditGroup.UseVisualStyleBackColor = false;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // tabPageEditOtd
            // 
            this.tabPageEditOtd.Controls.Add(this.comboBoxChooseOtd);
            this.tabPageEditOtd.Controls.Add(this.labelOtdTelephone);
            this.tabPageEditOtd.Controls.Add(this.textBoxOtdTelephone);
            this.tabPageEditOtd.Controls.Add(this.labelOtdTitle);
            this.tabPageEditOtd.Controls.Add(this.labelOtdManager);
            this.tabPageEditOtd.Controls.Add(this.textBoxOtdManager);
            this.tabPageEditOtd.Controls.Add(this.buttonEditOtdelenie);
            this.tabPageEditOtd.Location = new System.Drawing.Point(4, 25);
            this.tabPageEditOtd.Name = "tabPageEditOtd";
            this.tabPageEditOtd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditOtd.Size = new System.Drawing.Size(400, 343);
            this.tabPageEditOtd.TabIndex = 2;
            this.tabPageEditOtd.Text = "Отделения";
            this.tabPageEditOtd.UseVisualStyleBackColor = true;
            // 
            // comboBoxChooseOtd
            // 
            this.comboBoxChooseOtd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseOtd.FormattingEnabled = true;
            this.comboBoxChooseOtd.Location = new System.Drawing.Point(134, 79);
            this.comboBoxChooseOtd.Name = "comboBoxChooseOtd";
            this.comboBoxChooseOtd.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChooseOtd.TabIndex = 34;
            // 
            // labelOtdTelephone
            // 
            this.labelOtdTelephone.AutoSize = true;
            this.labelOtdTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtdTelephone.Location = new System.Drawing.Point(57, 163);
            this.labelOtdTelephone.Name = "labelOtdTelephone";
            this.labelOtdTelephone.Size = new System.Drawing.Size(84, 18);
            this.labelOtdTelephone.TabIndex = 32;
            this.labelOtdTelephone.Text = "Телефон:";
            // 
            // textBoxOtdTelephone
            // 
            this.textBoxOtdTelephone.Location = new System.Drawing.Point(202, 161);
            this.textBoxOtdTelephone.Name = "textBoxOtdTelephone";
            this.textBoxOtdTelephone.Size = new System.Drawing.Size(121, 22);
            this.textBoxOtdTelephone.TabIndex = 33;
            // 
            // labelOtdTitle
            // 
            this.labelOtdTitle.AutoSize = true;
            this.labelOtdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtdTitle.Location = new System.Drawing.Point(85, 37);
            this.labelOtdTitle.Name = "labelOtdTitle";
            this.labelOtdTitle.Size = new System.Drawing.Size(225, 18);
            this.labelOtdTitle.TabIndex = 31;
            this.labelOtdTitle.Text = "Редактирование отделения";
            // 
            // labelOtdManager
            // 
            this.labelOtdManager.AutoSize = true;
            this.labelOtdManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtdManager.Location = new System.Drawing.Point(57, 121);
            this.labelOtdManager.Name = "labelOtdManager";
            this.labelOtdManager.Size = new System.Drawing.Size(111, 18);
            this.labelOtdManager.TabIndex = 27;
            this.labelOtdManager.Text = "Заведующая:";
            // 
            // textBoxOtdManager
            // 
            this.textBoxOtdManager.Location = new System.Drawing.Point(202, 119);
            this.textBoxOtdManager.Name = "textBoxOtdManager";
            this.textBoxOtdManager.Size = new System.Drawing.Size(121, 22);
            this.textBoxOtdManager.TabIndex = 30;
            // 
            // buttonEditOtdelenie
            // 
            this.buttonEditOtdelenie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditOtdelenie.Location = new System.Drawing.Point(134, 253);
            this.buttonEditOtdelenie.Name = "buttonEditOtdelenie";
            this.buttonEditOtdelenie.Size = new System.Drawing.Size(107, 36);
            this.buttonEditOtdelenie.TabIndex = 26;
            this.buttonEditOtdelenie.Text = "Изменить";
            this.buttonEditOtdelenie.UseVisualStyleBackColor = false;
            this.buttonEditOtdelenie.Click += new System.EventHandler(this.buttonEditOtdelenie_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 362);
            this.Controls.Add(this.tabControlEdit);
            this.Name = "EditForm";
            this.Text = "Редактирование";
            this.tabControlEdit.ResumeLayout(false);
            this.tabPageEditStud.ResumeLayout(false);
            this.tabPageEditStud.PerformLayout();
            this.tabPageEditGrp.ResumeLayout(false);
            this.tabPageEditGrp.PerformLayout();
            this.tabPageEditOtd.ResumeLayout(false);
            this.tabPageEditOtd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEdit;
        private System.Windows.Forms.TabPage tabPageEditStud;
        private System.Windows.Forms.TextBox textBoxStudBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudPatronymic;
        private System.Windows.Forms.Label labelStudPatronymic;
        private System.Windows.Forms.TextBox textBoxStudName;
        private System.Windows.Forms.Label labelStudName;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Label labelStudTitle;
        private System.Windows.Forms.TextBox textBoxStudSurname;
        private System.Windows.Forms.Label labelStudSurname;
        private System.Windows.Forms.Label labelStudGroup;
        private System.Windows.Forms.ComboBox comboBoxStudGroup;
        private System.Windows.Forms.TabPage tabPageEditGrp;
        private System.Windows.Forms.TextBox textBoxGrpCurator;
        private System.Windows.Forms.Label labelGrpCurator;
        private System.Windows.Forms.Label labelGrpOtdelenie;
        private System.Windows.Forms.ComboBox comboBoxGrpOtdelenie;
        private System.Windows.Forms.TextBox textBoxGrpFaculty;
        private System.Windows.Forms.TextBox textBoxGrpName;
        private System.Windows.Forms.Label labelGrpTitle;
        private System.Windows.Forms.Label labelGrpName;
        private System.Windows.Forms.Label labelGrpFaculty;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.TabPage tabPageEditOtd;
        private System.Windows.Forms.Label labelOtdTelephone;
        private System.Windows.Forms.TextBox textBoxOtdTelephone;
        private System.Windows.Forms.Label labelOtdTitle;
        private System.Windows.Forms.Label labelOtdManager;
        private System.Windows.Forms.TextBox textBoxOtdManager;
        private System.Windows.Forms.Button buttonEditOtdelenie;
        private System.Windows.Forms.ComboBox comboBoxChooseGrp;
        private System.Windows.Forms.ComboBox comboBoxChooseOtd;
    }
}