using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentsInfo4
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        string constr = "Data Source=DESKTOP-NPFI0OK\\MSSQLSERVERR;Initial Catalog=AssignmentDB;Integrated Security=True;Pooling=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           int rollno = int.Parse(txtroll.Text);
            string name = txtname.Text;
            DateTime dob =DateTime.Parse(dtpdob.Value.ToString());
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
            MessageBox.Show(rollno + "\n" +name + "\n" + gender + "\n" + dept + "\n" + course + "\n" + semester + "\n" + address+"\n"+phone);
          try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "insert into StudentInfo values(@roll,@nm,@dob,@gen,@dpt,@course,@sem,@add,@phone)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", rollno);
                cmd.Parameters.AddWithValue("@nm", name);
                cmd.Parameters.AddWithValue("@gen", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@dpt",dept);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@sem", semester);
                cmd.Parameters.AddWithValue("@add", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data Inserted :" + res);
             //   this.rEgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.REgisterShopping);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.rEgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.REgisterShopping);
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo";
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        listBox1.Items.Add(r[i]);
                    }
                    listBox1.Items.Add("***********************");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = int.Parse(txtroll.Text);
                string dept = cmbdept.SelectedItem.ToString();
                string course = cmbcourse.SelectedItem.ToString();
                string sem = cmbsem.SelectedItem.ToString();
               
                con = new SqlConnection(constr);
                con.Open();
                string query = "update StudentInfo set Department=@dep,Course=@course,Semester=@sem where Rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dep", dept);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@sem", sem);
                cmd.Parameters.AddWithValue("@roll", rollno);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data Updated :" + res);
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtroll.Text);
                MessageBox.Show("ID is :" + id);
                con = new SqlConnection(constr);
                con.Open();
                string query = "delete from StudentInfo where Rollno=@roll";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roll", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    MessageBox.Show("Data Deleted :" + res);
           //     this.rEgisterShoppingTableAdapter.Fill(this.trainingDBDataSet.REgisterShopping);

            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {

            try
            {
                int id = int.Parse(txtroll.Text);
                con = new SqlConnection(constr);
                con.Open();
                string query = "select * from StudentInfo where Rollno=@id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                
                r = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        listBox1.Items.Add(r[i]);
                    }
                    listBox1.Items.Add("***********************");
                }
            }
            catch (SqlException sql)
            {
                MessageBox.Show(sql.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
