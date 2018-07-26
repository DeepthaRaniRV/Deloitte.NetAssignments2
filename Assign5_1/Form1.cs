using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign5_1
{
    public partial class Form1 : Form
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int rollno = int.Parse(txtroll.Text);
            string name = txtname.Text;
            DateTime dob = DateTime.Parse(dtpdob.Value.ToString());
            string gender = " ";
            if (rbmale.Checked)
                gender = rbmale.Text;
            if (rbfemale.Checked)
                gender = rbfemale.Text;
            string dept = cmbdept.SelectedItem.ToString();
            string course = cmbcourse.SelectedItem.ToString();
            string semester = cmbsem.SelectedItem.ToString();
            string address = txtaddress.Text;
            string phone = txtphone.Text;
            MessageBox.Show(rollno + "\n" + name + "\n" + gender + "\n" + dept + "\n" + course + "\n" + semester + "\n" + address + "\n" + phone);

            StudentInfo st = new StudentInfo();
            st.Rollno = rollno;
            st.Name = name;
            st.DateOfBirth = dob;
            st.Gender = gender;
            st.Department = dept;
            st.Course = course;
            st.Semester = semester;
            st.Address = address;
            st.PhoneNo = phone;

            db.StudentInfoes.Add(st);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Inserted");
            
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var t in db.StudentInfoes)
            {
                listBox1.Items.Add(t.Rollno);
                listBox1.Items.Add(t.Name);
                listBox1.Items.Add(t.Gender);
                listBox1.Items.Add(t.DateOfBirth);
                listBox1.Items.Add(t.Department);
                listBox1.Items.Add(t.Course);
                listBox1.Items.Add(t.Semester);
                listBox1.Items.Add(t.Address);
                listBox1.Items.Add(t.PhoneNo);
                listBox1.Items.Add("****************");

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int rollno = int.Parse(txtroll.Text);
            string dept = cmbdept.SelectedItem.ToString();
            string course = cmbcourse.SelectedItem.ToString();
            string sem = cmbsem.SelectedItem.ToString();

            var s = db.StudentInfoes.Where(x => x.Rollno == rollno).SingleOrDefault();

            s.Rollno = rollno;
            s.Department = dept;
            s.Course = course;
            s.Semester = sem;
            
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Updated");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int rollno = int.Parse(txtroll.Text);
            StudentInfo ss = new StudentInfo();
            var w= db.StudentInfoes.Where(x => x.Rollno == rollno).SingleOrDefault();
            db.StudentInfoes.Remove(w);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Deleted");
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int rollno = int.Parse(txtroll.Text);
            StudentInfo ss = new StudentInfo();
            var w1 = db.StudentInfoes.Where(x => x.Rollno == rollno).SingleOrDefault();
                listBox1.Items.Add(w1.Rollno);
                listBox1.Items.Add(w1.Name);
                listBox1.Items.Add(w1.Gender);
                listBox1.Items.Add(w1.DateOfBirth);
                listBox1.Items.Add(w1.Department);
                listBox1.Items.Add(w1.Course);
                listBox1.Items.Add(w1.Semester);
                listBox1.Items.Add(w1.Address);
                listBox1.Items.Add(w1.PhoneNo);
                listBox1.Items.Add("****************");

           
        }
    }
}
