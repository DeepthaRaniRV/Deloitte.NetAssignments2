namespace Assign5_1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cmbsem = new System.Windows.Forms.ComboBox();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.lblsem = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lbldept = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblroll = new System.Windows.Forms.Label();
            this.lblStud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(597, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 407);
            this.listBox1.TabIndex = 52;
            // 
            // dtpdob
            // 
            this.dtpdob.Location = new System.Drawing.Point(170, 195);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(200, 20);
            this.dtpdob.TabIndex = 51;
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(320, 88);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(75, 23);
            this.btnfind.TabIndex = 50;
            this.btnfind.Text = "FIND";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(495, 327);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(495, 244);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 48;
            this.btnupdate.Text = "UPDATE ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(495, 171);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 47;
            this.btnselect.Text = "SELECT ";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(495, 101);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 46;
            this.btnadd.Text = "ADD NEW";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(170, 479);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 45;
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
            this.cmbsem.Location = new System.Drawing.Point(170, 395);
            this.cmbsem.Name = "cmbsem";
            this.cmbsem.Size = new System.Drawing.Size(121, 21);
            this.cmbsem.TabIndex = 44;
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
            this.cmbcourse.Location = new System.Drawing.Point(170, 343);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(121, 21);
            this.cmbcourse.TabIndex = 43;
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
            this.cmbdept.Location = new System.Drawing.Point(170, 295);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(121, 21);
            this.cmbdept.TabIndex = 42;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(288, 239);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(67, 17);
            this.rbfemale.TabIndex = 41;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "FEMALE";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(170, 239);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(54, 17);
            this.rbmale.TabIndex = 40;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "MALE";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(170, 443);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 39;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(170, 140);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 38;
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(170, 92);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(100, 20);
            this.txtroll.TabIndex = 37;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(60, 486);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(64, 13);
            this.lblphone.TabIndex = 36;
            this.lblphone.Text = "Phone No. :";
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Location = new System.Drawing.Point(54, 443);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(51, 13);
            this.lbladd.TabIndex = 35;
            this.lbladd.Text = "Address :";
            // 
            // lblsem
            // 
            this.lblsem.AutoSize = true;
            this.lblsem.Location = new System.Drawing.Point(54, 395);
            this.lblsem.Name = "lblsem";
            this.lblsem.Size = new System.Drawing.Size(57, 13);
            this.lblsem.TabIndex = 34;
            this.lblsem.Text = "Semester :";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(54, 352);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(46, 13);
            this.lblcourse.TabIndex = 33;
            this.lblcourse.Text = "Course :";
            // 
            // lbldept
            // 
            this.lbldept.AutoSize = true;
            this.lbldept.Location = new System.Drawing.Point(54, 295);
            this.lbldept.Name = "lbldept";
            this.lbldept.Size = new System.Drawing.Size(68, 13);
            this.lbldept.TabIndex = 32;
            this.lbldept.Text = "Department :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(54, 244);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(48, 13);
            this.lblgender.TabIndex = 31;
            this.lblgender.Text = "Gender :";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(54, 195);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(74, 13);
            this.lbldob.TabIndex = 30;
            this.lbldob.Text = "Date Of Birth :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(57, 140);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 13);
            this.lblname.TabIndex = 29;
            this.lblname.Text = "Name :";
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Location = new System.Drawing.Point(54, 92);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(54, 13);
            this.lblroll.TabIndex = 28;
            this.lblroll.Text = "Roll No.  :";
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud.Location = new System.Drawing.Point(346, 24);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(195, 22);
            this.lblStud.TabIndex = 27;
            this.lblStud.Text = "STUDENT PROFILE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(946, 522);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ComboBox cmbsem;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lbladd;
        private System.Windows.Forms.Label lblsem;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lbldept;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Label lblStud;
    }
}

