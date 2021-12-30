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
    public partial class BillingForm : Form
    {
        int x;
        int gvtotal;
        int unitprice;
        Bitmap bm;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TSHN4BD;Initial Catalog=Pharmacy_DB;Integrated Security=True");
        public BillingForm()
        {
            InitializeComponent();
        }

        public void UpdateMed()
        {
            con.Open();
            int newQty = x- Convert.ToInt32(qtytxt.Text);
            string sqlquery = "update Medicine_tbl set MedQty = '" + newQty + "' where MedName = '" + mednameDD.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LoadMedName()
        {
            string sql = "select * from Medicine_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                mednameDD.ValueMember = "MedName";
                mednameDD.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FetchStock()
        {

            con.Open();
            string sql = "select * from Medicine_tbl where MedName = '" + mednameDD.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["MedQty"].ToString());
                unitprice = Convert.ToInt32(dr["SPrice"].ToString());
                stocklbl.Text = dr["MedQty"].ToString();
            }
            con.Close();
        }

        private void addbillbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (qtytxt.Text == "" || Convert.ToInt32(qtytxt.Text) > x)
            {
                MessageBox.Show("Insufficient Stock. Please Check Stock Details..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int total = Convert.ToInt32(qtytxt.Text) * unitprice;
                DataGridViewRow gvr = new DataGridViewRow();
                gvr.CreateCells(dataGridView1);
                gvr.Cells[0].Value = n + 1;
                gvr.Cells[1].Value = mednameDD.SelectedValue.ToString();
                gvr.Cells[2].Value = qtytxt.Text;
                gvr.Cells[3].Value = unitprice;
                gvr.Cells[4].Value = unitprice * Convert.ToInt32(qtytxt.Text);
                dataGridView1.Rows.Add(gvr);

                gvtotal = gvtotal + total;
                totalamtlbl.Text = gvtotal + " Rs.";
                totalamtlbl.Visible = true;

                UpdateMed();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainHomeForm mhf = new MainHomeForm();
            mhf.Show();
            this.Hide();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            LoadMedName();
        }

        private void mednameDD_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            FetchStock();
        }

        private void printbillbtn_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            this.Controls.Add(p);
            Graphics g = p.CreateGraphics();
            Size s = this.ClientSize;
            bm = new Bitmap(s.Width, s.Height, g);
            g = Graphics.FromImage(bm);
            Point pt = PointToScreen(p.Location);
            g.CopyFromScreen(pt.X, pt.Y, 0, 0, s);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
