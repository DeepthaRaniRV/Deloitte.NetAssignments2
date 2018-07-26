namespace StudentsInfo4
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
            this.lblStud = new System.Windows.Forms.Label();
            this.lblroll = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.cmbsem = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud.Location = new System.Drawing.Point(374, 25);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(195, 22);
            this.lblStud.TabIndex = 0;
            this.lblStud.Text = "STUDENT PROFILE";
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Location = new System.Drawing.Point(82, 93);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(54, 13);
            this.lblroll.TabIndex = 1;
            this.lblroll.Text = "Roll No.  :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(85, 141);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name :";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(82, 196);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(74, 13);
            this.lbldob.TabIndex = 3;
            this.lbldob.Text = "Date Of Birth :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(82, 245);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(48, 13);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender :";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(82, 296);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(68, 13);
            this.lbldept.TabIndex = 5;
            this.lbldept.Text = "Department :";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(82, 353);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(46, 13);
            this.lblcourse.TabIndex = 6;
            this.lblcourse.Text = "Course :";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.Location = new System.Drawing.Point(82, 396);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(57, 13);
            this.lblsem.TabIndex = 7;
            this.lblsem.Text = "Semester :";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(82, 444);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(51, 13);
            this.lbladd.TabIndex = 8;
            this.lbladd.Text = "Address :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(88, 487);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(64, 13);
            this.lblphone.TabIndex = 9;
            this.lblphone.Text = "Phone No. :";
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(198, 93);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(100, 20);
            this.txtroll.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(198, 141);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 11;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(198, 444);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 12;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(198, 240);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(54, 17);
            this.rbmale.TabIndex = 13;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "MALE";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(316, 240);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(67, 17);
            this.rbfemale.TabIndex = 14;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "FEMALE";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Items.AddRange(new object[] {
            "Computer Science",
            "Civil ",
            "Mechanical",
            "Electronics",
            ""});
            this.cmbdept.Location = new System.Drawing.Point(198, 296);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(121, 21);
            this.cmbdept.TabIndex = 15;
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Items.AddRange(new object[] {
            "B.E",
            "B.Sc",
            "M.E",
            "M.Sc",
            "B.Tech",
            "M.Tech"});
            this.cmbcourse.Location = new System.Drawing.Point(198, 344);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(121, 21);
            this.cmbcourse.TabIndex = 16;
            // 
            // cmbsem
            // 
            this.cmbsem.FormattingEnabled = true;
            this.cmbsem.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI"});
            this.cmbsem.Location = new System.Drawing.Point(198, 396);
            this.cmbsem.Name = "cmbsem";
            this.cmbsem.Size = new System.Drawing.Size(121, 21);
            this.cmbsem.TabIndex = 17;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(198, 480);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 18;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(523, 102);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(523, 172);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 21;
            this.btnselect.Text = "SELECT ";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(523, 245);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "UPDATE ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(523, 328);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(348, 89);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 24;
            this.btnfind.Text = "FIND";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(198, 196);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(200, 20);
            this.dtpdob.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(625, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 407);
            this.listBox1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(948, 536);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.cmbsem);
            this.Controls.Add(this.cmbcourse);
            this.Controls.Add(this.cmbdept);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtroll);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lbladd);
            this.Controls.Add(this.lblsem);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lbldept);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblroll);
            this.Controls.Add(this.lblStud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStud;
        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.ComboBox cmbsem;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.ListBox listBox1;
    }
}

