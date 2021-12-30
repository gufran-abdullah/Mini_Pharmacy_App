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
    public partial class Company : Form
    {
        int edit = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSHN4BD;Initial Catalog=Pharmacy_DB;Integrated Security=True");
        public Company()
        {
            InitializeComponent();
        }

        public void reset()
        {
            compidtxt.Text = "";
            compnametxt.Text = "";
            compphtxt.Text = "";
            compadrtxt.Text = "";
            compidtxt.Focus();
        }

        public void LoadComp()
        {
            con.Open();
            string myquery = "select * from Company_tbl";
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
            if (compnametxt.Text == "" || compidtxt.Text == "" || compphtxt.Text == "" || compadrtxt.Text == "")
            {
                MessageBox.Show("Please fill all the information..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tbl values('" + compidtxt.Text + "','" + compnametxt.Text + "','" + compphtxt.Text + "','" + compadrtxt.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(compnametxt.Text + " added to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                LoadComp();
                reset();
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlquery = "update Company_tbl set CompanyName = '" + compnametxt.Text + "', ComapanyPhone = '" + compphtxt.Text + "', CompanyAddress = '" + compadrtxt.Text + "' where CompanyID = '" + compidtxt.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(compnametxt.Text + " update to record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            LoadComp();
            reset();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure that you want to delete " + compnametxt.Text + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (compnametxt.Text == "")
                    {
                        MessageBox.Show("Click on record to delete it..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        string sql = "delete from Company_tbl where CompanyID = '" + compidtxt.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(compnametxt.Text + " deleted from record successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        LoadComp();
                        reset();
                    }
                }
                else
                {
                    reset();
                    LoadComp();
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
                compidtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                compnametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                compphtxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                compadrtxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            LoadComp();
            reset();
        }
    }
}
