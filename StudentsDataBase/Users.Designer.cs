namespace StudentsDataBase
{
    partial class Users
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
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tabPageUserReg = new System.Windows.Forms.TabPage();
            this.buttonUserReg = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelTitleAuth = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUserRole = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxUserRole = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserNameDel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUserDel = new System.Windows.Forms.Button();
            this.tabControlUsers.SuspendLayout();
            this.tabPageUserReg.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tabPageUserReg);
            this.tabControlUsers.Controls.Add(this.tabPage2);
            this.tabControlUsers.Controls.Add(this.tabPage1);
            this.tabControlUsers.Location = new System.Drawing.Point(-1, 1);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(418, 341);
            this.tabControlUsers.TabIndex = 0;
            // 
            // tabPageUserReg
            // 
            this.tabPageUserReg.Controls.Add(this.buttonUserReg);
            this.tabPageUserReg.Controls.Add(this.labelPassword);
            this.tabPageUserReg.Controls.Add(this.labelLogin);
            this.tabPageUserReg.Controls.Add(this.textBoxPassword);
            this.tabPageUserReg.Controls.Add(this.textBoxLogin);
            this.tabPageUserReg.Controls.Add(this.labelTitleAuth);
            this.tabPageUserReg.Location = new System.Drawing.Point(4, 25);
            this.tabPageUserReg.Name = "tabPageUserReg";
            this.tabPageUserReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserReg.Size = new System.Drawing.Size(410, 312);
            this.tabPageUserReg.TabIndex = 0;
            this.tabPageUserReg.Text = "Регистрация юзера";
            this.tabPageUserReg.UseVisualStyleBackColor = true;
            // 
            // buttonUserReg
            // 
            this.buttonUserReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserReg.Location = new System.Drawing.Point(93, 232);
            this.buttonUserReg.Name = "buttonUserReg";
            this.buttonUserReg.Size = new System.Drawing.Size(231, 45);
            this.buttonUserReg.TabIndex = 13;
            this.buttonUserReg.Text = "Регистрация";
            this.buttonUserReg.UseVisualStyleBackColor = true;
            this.buttonUserReg.Click += new System.EventHandler(this.buttonUserReg_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(89, 152);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 20);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(125, 102);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(61, 20);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Login:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(224, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(224, 100);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 8;
            // 
            // labelTitleAuth
            // 
            this.labelTitleAuth.AutoSize = true;
            this.labelTitleAuth.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAuth.Location = new System.Drawing.Point(114, 20);
            this.labelTitleAuth.Name = "labelTitleAuth";
            this.labelTitleAuth.Size = new System.Drawing.Size(194, 34);
            this.labelTitleAuth.TabIndex = 7;
            this.labelTitleAuth.Text = "Регистрация";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxUserName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxUserRole);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonUserRole);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дать роль";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название роли: ";
            // 
            // buttonUserRole
            // 
            this.buttonUserRole.Location = new System.Drawing.Point(134, 220);
            this.buttonUserRole.Name = "buttonUserRole";
            this.buttonUserRole.Size = new System.Drawing.Size(144, 48);
            this.buttonUserRole.TabIndex = 0;
            this.buttonUserRole.Text = "Дать";
            this.buttonUserRole.UseVisualStyleBackColor = true;
            this.buttonUserRole.Click += new System.EventHandler(this.buttonUserRole_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxUserNameDel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonUserDel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 312);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Удаление юзера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxUserRole
            // 
            this.textBoxUserRole.Location = new System.Drawing.Point(237, 114);
            this.textBoxUserRole.Name = "textBoxUserRole";
            this.textBoxUserRole.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserRole.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(237, 70);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин: ";
            // 
            // textBoxUserNameDel
            // 
            this.textBoxUserNameDel.Location = new System.Drawing.Point(235, 103);
            this.textBoxUserNameDel.Name = "textBoxUserNameDel";
            this.textBoxUserNameDel.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserNameDel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логин: ";
            // 
            // buttonUserDel
            // 
            this.buttonUserDel.Location = new System.Drawing.Point(133, 207);
            this.buttonUserDel.Name = "buttonUserDel";
            this.buttonUserDel.Size = new System.Drawing.Size(144, 48);
            this.buttonUserDel.TabIndex = 5;
            this.buttonUserDel.Text = "Удалить";
            this.buttonUserDel.UseVisualStyleBackColor = true;
            this.buttonUserDel.Click += new System.EventHandler(this.buttonUserDel_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 350);
            this.Controls.Add(this.tabControlUsers);
            this.Name = "Users";
            this.Text = "Управление пользователями";
            this.tabControlUsers.ResumeLayout(false);
            this.tabPageUserReg.ResumeLayout(false);
            this.tabPageUserReg.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tabPageUserReg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUserReg;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelTitleAuth;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserRole;
        private System.Windows.Forms.TextBox textBoxUserRole;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserNameDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUserDel;
    }
}