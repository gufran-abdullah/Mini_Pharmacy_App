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

namespace Pharmacy
{
    public partial class Employees : Form
    {
        int edit = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSHN4BD;Initial Catalog=Pharmacy_DB;Integrated Security=True");
        public Employees()
        {
            InitializeComponent();
        }

        public void reset()
        {
            empnametxt.Text = "";
            empagetxt.Text = "";
            empsalarytxt.Text = "";
            empidtxt.Text = "";
            empgenderDD.SelectedIndex = -1;
            empphtxt.Text = "";
            empunametxt.Text = "";
            emppasstxt.Text = "";
            empidtxt.Focus();
        }

        public void LoadEmp()
        {
            con.Open();
            string myquery = "select * from Employee_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (empnametxt.Text == "" || empagetxt.Text == "" || empsalarytxt.Text == "" || empidtxt.Text == "" || empgenderDD.SelectedItem == null || empphtxt.Text == "" || emppasstxt.Text == "" || empunametxt.Text == "")
            {
                MessageBox.Show("Please fill all the information..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee_tbl values('" + empidtxt.Text + "','" + empnametxt.Text + "','" + empgenderDD.SelectedItem.ToString() + "','" + empagetxt.Text + "','" + empsalarytxt.Text + "','" + empphtxt.Text + "','"+empunametxt.Text+"','"+emppasstxt.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(empnametxt.Text + " added to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                LoadEmp();
                reset();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlquery = "update Employee_tbl set EmpName = '"+ empnametxt.Text + "', EmpGender = '"+ empgenderDD.SelectedItem.ToString() + "', EmpAge = '"+ empagetxt.Text + "', EmpSalary = '"+ empsalarytxt.Text + "', EmpPhone = '"+ empphtxt.Text + "', EmpUserName = '"+empunametxt.Text+"', EmpPassword = '"+emppasstxt.Text+"' where EmpID = '"+ empidtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(empnametxt.Text + " update to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadEmp();
            reset();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure that you want to delete " + empnametxt.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (empnametxt.Text == "")
                    {
                        MessageBox.Show("Click on record to delete it..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        string sql = "delete from Employee_tbl where EmpID = '" + empidtxt.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(empnametxt.Text + " deleted from record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        LoadEmp();
                        reset();
                    }
                }
                else
                {
                    reset();
                    LoadEmp();
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainHomeForm mhf = new MainHomeForm();
            mhf.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                empidtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                empnametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                empgenderDD.SelectedItem = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                empagetxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                empsalarytxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                empphtxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                empunametxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                emppasstxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            LoadEmp();
            reset();
        }
    }
}
