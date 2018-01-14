namespace StudentsDataBase
{
    partial class AddForm
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
            this.tabPageAddOtd = new System.Windows.Forms.TabPage();
            this.labelOtdTitle = new System.Windows.Forms.Label();
            this.labelOtdManager = new System.Windows.Forms.Label();
            this.textBoxOtdManager = new System.Windows.Forms.TextBox();
            this.buttonAddOtdelenie = new System.Windows.Forms.Button();
            this.tabPageAddGrp = new System.Windows.Forms.TabPage();
            this.labelGrpOtdelenie = new System.Windows.Forms.Label();
            this.comboBoxGrpOtdelenie = new System.Windows.Forms.ComboBox();
            this.textBoxGrpFaculty = new System.Windows.Forms.TextBox();
            this.textBoxGrpName = new System.Windows.Forms.TextBox();
            this.labelGrpTitle = new System.Windows.Forms.Label();
            this.labelGrpName = new System.Windows.Forms.Label();
            this.labelGrpFaculty = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.tabPageAddStud = new System.Windows.Forms.TabPage();
            this.textBoxStudPatronymic = new System.Windows.Forms.TextBox();
            this.labelStudPatronymic = new System.Windows.Forms.Label();
            this.textBoxStudName = new System.Windows.Forms.TextBox();
            this.labelStudName = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.labelStudTitle = new System.Windows.Forms.Label();
            this.textBoxStudSurname = new System.Windows.Forms.TextBox();
            this.labelStudSurname = new System.Windows.Forms.Label();
            this.labelStudGroup = new System.Windows.Forms.Label();
            this.comboBoxStudGroup = new System.Windows.Forms.ComboBox();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.labelOtdTelephone = new System.Windows.Forms.Label();
            this.textBoxOtdTelephone = new System.Windows.Forms.TextBox();
            this.textBoxGrpCurator = new System.Windows.Forms.TextBox();
            this.labelGrpCurator = new System.Windows.Forms.Label();
            this.textBoxStudBirthday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAddOtd.SuspendLayout();
            this.tabPageAddGrp.SuspendLayout();
            this.tabPageAddStud.SuspendLayout();
            this.tabControlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageAddOtd
            // 
            this.tabPageAddOtd.Controls.Add(this.labelOtdTelephone);
            this.tabPageAddOtd.Controls.Add(this.textBoxOtdTelephone);
            this.tabPageAddOtd.Controls.Add(this.labelOtdTitle);
            this.tabPageAddOtd.Controls.Add(this.labelOtdManager);
            this.tabPageAddOtd.Controls.Add(this.textBoxOtdManager);
            this.tabPageAddOtd.Controls.Add(this.buttonAddOtdelenie);
            this.tabPageAddOtd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddOtd.Name = "tabPageAddOtd";
            this.tabPageAddOtd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddOtd.Size = new System.Drawing.Size(400, 343);
            this.tabPageAddOtd.TabIndex = 2;
            this.tabPageAddOtd.Text = "Отделения";
            this.tabPageAddOtd.UseVisualStyleBackColor = true;
            // 
            // labelOtdTitle
            // 
            this.labelOtdTitle.AutoSize = true;
            this.labelOtdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtdTitle.Location = new System.Drawing.Point(103, 46);
            this.labelOtdTitle.Name = "labelOtdTitle";
            this.labelOtdTitle.Size = new System.Drawing.Size(193, 18);
            this.labelOtdTitle.TabIndex = 31;
            this.labelOtdTitle.Text = "Добавление отделения";
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
            // buttonAddOtdelenie
            // 
            this.buttonAddOtdelenie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddOtdelenie.Location = new System.Drawing.Point(134, 253);
            this.buttonAddOtdelenie.Name = "buttonAddOtdelenie";
            this.buttonAddOtdelenie.Size = new System.Drawing.Size(107, 36);
            this.buttonAddOtdelenie.TabIndex = 26;
            this.buttonAddOtdelenie.Text = "Добавить";
            this.buttonAddOtdelenie.UseVisualStyleBackColor = false;
            this.buttonAddOtdelenie.Click += new System.EventHandler(this.buttonAddOtdelenie_Click);
            // 
            // tabPageAddGrp
            // 
            this.tabPageAddGrp.Controls.Add(this.textBoxGrpCurator);
            this.tabPageAddGrp.Controls.Add(this.labelGrpCurator);
            this.tabPageAddGrp.Controls.Add(this.labelGrpOtdelenie);
            this.tabPageAddGrp.Controls.Add(this.comboBoxGrpOtdelenie);
            this.tabPageAddGrp.Controls.Add(this.textBoxGrpFaculty);
            this.tabPageAddGrp.Controls.Add(this.textBoxGrpName);
            this.tabPageAddGrp.Controls.Add(this.labelGrpTitle);
            this.tabPageAddGrp.Controls.Add(this.labelGrpName);
            this.tabPageAddGrp.Controls.Add(this.labelGrpFaculty);
            this.tabPageAddGrp.Controls.Add(this.buttonAddGroup);
            this.tabPageAddGrp.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddGrp.Name = "tabPageAddGrp";
            this.tabPageAddGrp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddGrp.Size = new System.Drawing.Size(400, 343);
            this.tabPageAddGrp.TabIndex = 1;
            this.tabPageAddGrp.Text = "Группы";
            this.tabPageAddGrp.UseVisualStyleBackColor = true;
            // 
            // labelGrpOtdelenie
            // 
            this.labelGrpOtdelenie.AutoSize = true;
            this.labelGrpOtdelenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpOtdelenie.Location = new System.Drawing.Point(60, 201);
            this.labelGrpOtdelenie.Name = "labelGrpOtdelenie";
            this.labelGrpOtdelenie.Size = new System.Drawing.Size(99, 18);
            this.labelGrpOtdelenie.TabIndex = 25;
            this.labelGrpOtdelenie.Text = "Отделение:";
            // 
            // comboBoxGrpOtdelenie
            // 
            this.comboBoxGrpOtdelenie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrpOtdelenie.FormattingEnabled = true;
            this.comboBoxGrpOtdelenie.Location = new System.Drawing.Point(186, 201);
            this.comboBoxGrpOtdelenie.Name = "comboBoxGrpOtdelenie";
            this.comboBoxGrpOtdelenie.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGrpOtdelenie.TabIndex = 26;
            // 
            // textBoxGrpFaculty
            // 
            this.textBoxGrpFaculty.Location = new System.Drawing.Point(188, 130);
            this.textBoxGrpFaculty.Name = "textBoxGrpFaculty";
            this.textBoxGrpFaculty.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpFaculty.TabIndex = 24;
            // 
            // textBoxGrpName
            // 
            this.textBoxGrpName.Location = new System.Drawing.Point(188, 86);
            this.textBoxGrpName.Name = "textBoxGrpName";
            this.textBoxGrpName.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpName.TabIndex = 20;
            // 
            // labelGrpTitle
            // 
            this.labelGrpTitle.AutoSize = true;
            this.labelGrpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpTitle.Location = new System.Drawing.Point(120, 31);
            this.labelGrpTitle.Name = "labelGrpTitle";
            this.labelGrpTitle.Size = new System.Drawing.Size(164, 18);
            this.labelGrpTitle.TabIndex = 23;
            this.labelGrpTitle.Text = "Добавление группы";
            // 
            // labelGrpName
            // 
            this.labelGrpName.AutoSize = true;
            this.labelGrpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpName.Location = new System.Drawing.Point(60, 90);
            this.labelGrpName.Name = "labelGrpName";
            this.labelGrpName.Size = new System.Drawing.Size(88, 18);
            this.labelGrpName.TabIndex = 17;
            this.labelGrpName.Text = "Название:";
            // 
            // labelGrpFaculty
            // 
            this.labelGrpFaculty.AutoSize = true;
            this.labelGrpFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpFaculty.Location = new System.Drawing.Point(62, 130);
            this.labelGrpFaculty.Name = "labelGrpFaculty";
            this.labelGrpFaculty.Size = new System.Drawing.Size(97, 18);
            this.labelGrpFaculty.TabIndex = 18;
            this.labelGrpFaculty.Text = "Факультет:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddGroup.Location = new System.Drawing.Point(143, 254);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(107, 36);
            this.buttonAddGroup.TabIndex = 16;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = false;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // tabPageAddStud
            // 
            this.tabPageAddStud.Controls.Add(this.textBoxStudBirthday);
            this.tabPageAddStud.Controls.Add(this.label1);
            this.tabPageAddStud.Controls.Add(this.textBoxStudPatronymic);
            this.tabPageAddStud.Controls.Add(this.labelStudPatronymic);
            this.tabPageAddStud.Controls.Add(this.textBoxStudName);
            this.tabPageAddStud.Controls.Add(this.labelStudName);
            this.tabPageAddStud.Controls.Add(this.buttonAddStudent);
            this.tabPageAddStud.Controls.Add(this.labelStudTitle);
            this.tabPageAddStud.Controls.Add(this.textBoxStudSurname);
            this.tabPageAddStud.Controls.Add(this.labelStudSurname);
            this.tabPageAddStud.Controls.Add(this.labelStudGroup);
            this.tabPageAddStud.Controls.Add(this.comboBoxStudGroup);
            this.tabPageAddStud.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddStud.Name = "tabPageAddStud";
            this.tabPageAddStud.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStud.Size = new System.Drawing.Size(400, 343);
            this.tabPageAddStud.TabIndex = 0;
            this.tabPageAddStud.Text = "Студенты";
            this.tabPageAddStud.UseVisualStyleBackColor = true;
            // 
            // textBoxStudPatronymic
            // 
            this.textBoxStudPatronymic.Location = new System.Drawing.Point(194, 140);
            this.textBoxStudPatronymic.Name = "textBoxStudPatronymic";
            this.textBoxStudPatronymic.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudPatronymic.TabIndex = 19;
            // 
            // labelStudPatronymic
            // 
            this.labelStudPatronymic.AutoSize = true;
            this.labelStudPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudPatronymic.Location = new System.Drawing.Point(77, 140);
            this.labelStudPatronymic.Name = "labelStudPatronymic";
            this.labelStudPatronymic.Size = new System.Drawing.Size(88, 18);
            this.labelStudPatronymic.TabIndex = 18;
            this.labelStudPatronymic.Text = "Отчество:";
            // 
            // textBoxStudName
            // 
            this.textBoxStudName.Location = new System.Drawing.Point(194, 110);
            this.textBoxStudName.Name = "textBoxStudName";
            this.textBoxStudName.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudName.TabIndex = 17;
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudName.Location = new System.Drawing.Point(116, 110);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(46, 18);
            this.labelStudName.TabIndex = 16;
            this.labelStudName.Text = "Имя:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddStudent.Location = new System.Drawing.Point(149, 266);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(107, 36);
            this.buttonAddStudent.TabIndex = 15;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // labelStudTitle
            // 
            this.labelStudTitle.AutoSize = true;
            this.labelStudTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudTitle.Location = new System.Drawing.Point(110, 22);
            this.labelStudTitle.Name = "labelStudTitle";
            this.labelStudTitle.Size = new System.Drawing.Size(180, 18);
            this.labelStudTitle.TabIndex = 14;
            this.labelStudTitle.Text = "Добавление студента";
            // 
            // textBoxStudSurname
            // 
            this.textBoxStudSurname.Location = new System.Drawing.Point(194, 77);
            this.textBoxStudSurname.Name = "textBoxStudSurname";
            this.textBoxStudSurname.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudSurname.TabIndex = 7;
            // 
            // labelStudSurname
            // 
            this.labelStudSurname.AutoSize = true;
            this.labelStudSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudSurname.Location = new System.Drawing.Point(77, 77);
            this.labelStudSurname.Name = "labelStudSurname";
            this.labelStudSurname.Size = new System.Drawing.Size(85, 18);
            this.labelStudSurname.TabIndex = 0;
            this.labelStudSurname.Text = "Фамилия:";
            // 
            // labelStudGroup
            // 
            this.labelStudGroup.AutoSize = true;
            this.labelStudGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudGroup.Location = new System.Drawing.Point(99, 205);
            this.labelStudGroup.Name = "labelStudGroup";
            this.labelStudGroup.Size = new System.Drawing.Size(67, 18);
            this.labelStudGroup.TabIndex = 1;
            this.labelStudGroup.Text = "Группа:";
            // 
            // comboBoxStudGroup
            // 
            this.comboBoxStudGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudGroup.FormattingEnabled = true;
            this.comboBoxStudGroup.Location = new System.Drawing.Point(192, 205);
            this.comboBoxStudGroup.Name = "comboBoxStudGroup";
            this.comboBoxStudGroup.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudGroup.TabIndex = 8;
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabPageAddStud);
            this.tabControlAdd.Controls.Add(this.tabPageAddGrp);
            this.tabControlAdd.Controls.Add(this.tabPageAddOtd);
            this.tabControlAdd.Location = new System.Drawing.Point(2, 3);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(408, 372);
            this.tabControlAdd.TabIndex = 16;
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
            // textBoxGrpCurator
            // 
            this.textBoxGrpCurator.Location = new System.Drawing.Point(188, 162);
            this.textBoxGrpCurator.Name = "textBoxGrpCurator";
            this.textBoxGrpCurator.Size = new System.Drawing.Size(121, 22);
            this.textBoxGrpCurator.TabIndex = 28;
            // 
            // labelGrpCurator
            // 
            this.labelGrpCurator.AutoSize = true;
            this.labelGrpCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrpCurator.Location = new System.Drawing.Point(62, 162);
            this.labelGrpCurator.Name = "labelGrpCurator";
            this.labelGrpCurator.Size = new System.Drawing.Size(77, 18);
            this.labelGrpCurator.TabIndex = 27;
            this.labelGrpCurator.Text = "Куратор:";
            // 
            // textBoxStudBirthday
            // 
            this.textBoxStudBirthday.Location = new System.Drawing.Point(194, 172);
            this.textBoxStudBirthday.Name = "textBoxStudBirthday";
            this.textBoxStudBirthday.Size = new System.Drawing.Size(121, 22);
            this.textBoxStudBirthday.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дата рождения:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 366);
            this.Controls.Add(this.tabControlAdd);
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.tabPageAddOtd.ResumeLayout(false);
            this.tabPageAddOtd.PerformLayout();
            this.tabPageAddGrp.ResumeLayout(false);
            this.tabPageAddGrp.PerformLayout();
            this.tabPageAddStud.ResumeLayout(false);
            this.tabPageAddStud.PerformLayout();
            this.tabControlAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAddOtd;
        private System.Windows.Forms.Label labelOtdTitle;
        private System.Windows.Forms.Label labelOtdManager;
        private System.Windows.Forms.TextBox textBoxOtdManager;
        private System.Windows.Forms.Button buttonAddOtdelenie;
        private System.Windows.Forms.TabPage tabPageAddGrp;
        private System.Windows.Forms.TextBox textBoxGrpFaculty;
        private System.Windows.Forms.TextBox textBoxGrpName;
        private System.Windows.Forms.Label labelGrpTitle;
        private System.Windows.Forms.Label labelGrpName;
        private System.Windows.Forms.Label labelGrpFaculty;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TabPage tabPageAddStud;
        private System.Windows.Forms.TextBox textBoxStudPatronymic;
        private System.Windows.Forms.Label labelStudPatronymic;
        private System.Windows.Forms.TextBox textBoxStudName;
        private System.Windows.Forms.Label labelStudName;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label labelStudTitle;
        private System.Windows.Forms.TextBox textBoxStudSurname;
        private System.Windows.Forms.Label labelStudSurname;
        private System.Windows.Forms.Label labelStudGroup;
        private System.Windows.Forms.ComboBox comboBoxStudGroup;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.Label labelGrpOtdelenie;
        private System.Windows.Forms.ComboBox comboBoxGrpOtdelenie;
        private System.Windows.Forms.Label labelOtdTelephone;
        private System.Windows.Forms.TextBox textBoxOtdTelephone;
        private System.Windows.Forms.TextBox textBoxGrpCurator;
        private System.Windows.Forms.Label labelGrpCurator;
        private System.Windows.Forms.TextBox textBoxStudBirthday;
        private System.Windows.Forms.Label label1;
    }
}