namespace Porquiado_Information_
{
    partial class Form1
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
            System.Windows.Forms.Label txtX;
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblhobbies = new System.Windows.Forms.Label();
            this.lblFavColor = new System.Windows.Forms.Label();
            this.lblsaying = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsaying = new System.Windows.Forms.TextBox();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.chkbasketball = new System.Windows.Forms.CheckBox();
            this.chkvolleyball = new System.Windows.Forms.CheckBox();
            this.chksoccer = new System.Windows.Forms.CheckBox();
            this.cmbFavColor = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            txtX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtX
            // 
            txtX.AutoSize = true;
            txtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtX.ForeColor = System.Drawing.Color.Red;
            txtX.Location = new System.Drawing.Point(856, 9);
            txtX.Name = "txtX";
            txtX.Size = new System.Drawing.Size(25, 24);
            txtX.TabIndex = 15;
            txtX.Text = "X";
            txtX.Click += new System.EventHandler(this.txtX_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(75, 67);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(75, 120);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(75, 18);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Gender:";
            // 
            // lblhobbies
            // 
            this.lblhobbies.AutoSize = true;
            this.lblhobbies.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhobbies.Location = new System.Drawing.Point(75, 163);
            this.lblhobbies.Name = "lblhobbies";
            this.lblhobbies.Size = new System.Drawing.Size(83, 18);
            this.lblhobbies.TabIndex = 2;
            this.lblhobbies.Text = "Hobbies:";
            // 
            // lblFavColor
            // 
            this.lblFavColor.AutoSize = true;
            this.lblFavColor.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavColor.Location = new System.Drawing.Point(75, 279);
            this.lblFavColor.Name = "lblFavColor";
            this.lblFavColor.Size = new System.Drawing.Size(134, 18);
            this.lblFavColor.TabIndex = 3;
            this.lblFavColor.Text = "Favorite Color:";
            // 
            // lblsaying
            // 
            this.lblsaying.AutoSize = true;
            this.lblsaying.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaying.Location = new System.Drawing.Point(499, 108);
            this.lblsaying.Name = "lblsaying";
            this.lblsaying.Size = new System.Drawing.Size(68, 18);
            this.lblsaying.TabIndex = 4;
            this.lblsaying.Text = "Saying:";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(142, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(281, 25);
            this.txtname.TabIndex = 5;
            // 
            // txtsaying
            // 
            this.txtsaying.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaying.Location = new System.Drawing.Point(503, 142);
            this.txtsaying.Multiline = true;
            this.txtsaying.Name = "txtsaying";
            this.txtsaying.Size = new System.Drawing.Size(300, 164);
            this.txtsaying.TabIndex = 6;
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.Location = new System.Drawing.Point(164, 120);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(60, 21);
            this.rdbmale.TabIndex = 7;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = true;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(245, 120);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(78, 21);
            this.rdbfemale.TabIndex = 8;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = true;
            // 
            // chkbasketball
            // 
            this.chkbasketball.AutoSize = true;
            this.chkbasketball.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbasketball.Location = new System.Drawing.Point(177, 161);
            this.chkbasketball.Name = "chkbasketball";
            this.chkbasketball.Size = new System.Drawing.Size(103, 21);
            this.chkbasketball.TabIndex = 9;
            this.chkbasketball.Text = "Basketball";
            this.chkbasketball.UseVisualStyleBackColor = true;
            // 
            // chkvolleyball
            // 
            this.chkvolleyball.AutoSize = true;
            this.chkvolleyball.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkvolleyball.Location = new System.Drawing.Point(177, 200);
            this.chkvolleyball.Name = "chkvolleyball";
            this.chkvolleyball.Size = new System.Drawing.Size(100, 21);
            this.chkvolleyball.TabIndex = 10;
            this.chkvolleyball.Text = "Valleyball";
            this.chkvolleyball.UseVisualStyleBackColor = true;
            // 
            // chksoccer
            // 
            this.chksoccer.AutoSize = true;
            this.chksoccer.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksoccer.Location = new System.Drawing.Point(177, 237);
            this.chksoccer.Name = "chksoccer";
            this.chksoccer.Size = new System.Drawing.Size(75, 21);
            this.chksoccer.TabIndex = 11;
            this.chksoccer.Text = "Soccer";
            this.chksoccer.UseVisualStyleBackColor = true;
            // 
            // cmbFavColor
            // 
            this.cmbFavColor.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFavColor.FormattingEnabled = true;
            this.cmbFavColor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Pink"});
            this.cmbFavColor.Location = new System.Drawing.Point(213, 281);
            this.cmbFavColor.Name = "cmbFavColor";
            this.cmbFavColor.Size = new System.Drawing.Size(210, 25);
            this.cmbFavColor.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(505, 400);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(132, 43);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(671, 400);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(132, 43);
            this.btndisplay.TabIndex = 14;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(505, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(164, 335);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(259, 25);
            this.txtAddress.TabIndex = 18;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(75, 337);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 18);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(142, 380);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 25);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(76, 382);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 18);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(74, 425);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(84, 18);
            this.lblBirthday.TabIndex = 21;
            this.lblBirthday.Text = "Birthday:";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(164, 423);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(259, 25);
            this.txtBirthday.TabIndex = 22;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(563, 69);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(240, 25);
            this.txtAge.TabIndex = 24;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(500, 69);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 18);
            this.lblAge.TabIndex = 23;
            this.lblAge.Text = "Age:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(606, 321);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 25);
            this.txtUsername.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(606, 354);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 25);
            this.txtPassword.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 534);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(txtX);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbFavColor);
            this.Controls.Add(this.chksoccer);
            this.Controls.Add(this.chkvolleyball);
            this.Controls.Add(this.chkbasketball);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.txtsaying);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsaying);
            this.Controls.Add(this.lblFavColor);
            this.Controls.Add(this.lblhobbies);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblhobbies;
        private System.Windows.Forms.Label lblFavColor;
        private System.Windows.Forms.Label lblsaying;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.RadioButton rdbmale;
        public System.Windows.Forms.RadioButton rdbfemale;
        public System.Windows.Forms.TextBox txtsaying;
        public System.Windows.Forms.CheckBox chkbasketball;
        public System.Windows.Forms.CheckBox chkvolleyball;
        public System.Windows.Forms.CheckBox chksoccer;
        public System.Windows.Forms.ComboBox cmbFavColor;
        public System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBirthday;
        public System.Windows.Forms.TextBox txtBirthday;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
    }
}

