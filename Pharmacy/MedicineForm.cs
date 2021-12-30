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
    public partial class MedicineForm : Form
    {
        int edit = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSHN4BD;Initial Catalog=Pharmacy_DB;Integrated Security=True");
        public MedicineForm()
        {
            InitializeComponent();
        }
        
        public void reset()
        {
            mednametxt.Text = ""; 
            medbptxt.Text = "";
            medsptxt.Text = "";
            medqtytxt.Text = "";
            medcompDD.SelectedIndex = -1;
            mednametxt.Focus();
        }

        public void LoadMed()
        {
            con.Open();
            string myquery = "select * from Medicine_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        public void LoadComp()
        {
            string sql = "select CompanyName from Company_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CompanyName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                medcompDD.ValueMember = "CompanyName";
                medcompDD.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
            if (mednametxt.Text == "" || medbptxt.Text == "" || medsptxt.Text == "" || medqtytxt.Text == "" || medcompDD.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the information..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + mednametxt.Text + "','" + medbptxt.Text + "','" + medsptxt.Text + "','" + medqtytxt.Text + "','" + dateTimePicker1.Text + "','" + medcompDD.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(mednametxt.Text + " added to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                LoadMed();
                reset();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string sqlquery = "update Medicine_tbl set BPrice = '" + medbptxt.Text + "', SPrice = '"+ medsptxt.Text + "', MedQty = '"+ medqtytxt.Text + "', ExpDate = '"+ dateTimePicker1.Text + "', Company = '"+ medcompDD.SelectedValue.ToString() + "' where MedName = '"+ mednametxt.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(mednametxt.Text + " update to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadMed();
            reset();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure that you want to delete "+ mednametxt.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    if (mednametxt.Text == "")
                    {
                        MessageBox.Show("Click on record to delete it..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        string sql = "delete from Medicine_tbl where MedName = '" + mednametxt.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(mednametxt.Text + " deleted from record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        LoadMed();
                        reset();
                    }
                }
                else
                {
                    reset();
                    LoadMed();
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainHomeForm mhf = new MainHomeForm();
            mhf.Show();
            this.Hide();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            LoadMed();
            LoadComp();
            reset();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                mednametxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                medbptxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                medsptxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                medqtytxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                medcompDD.SelectedValue = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
