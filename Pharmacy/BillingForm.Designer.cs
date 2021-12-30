namespace Pharmacy
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mednameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medqtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medtotpriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addbillbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.stocklbl = new System.Windows.Forms.Label();
            this.mednameDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalamtlbl = new System.Windows.Forms.Label();
            this.printbillbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qtytxt
            // 
            this.qtytxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qtytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytxt.ForeColor = System.Drawing.Color.White;
            this.qtytxt.Location = new System.Drawing.Point(160, 253);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(152, 26);
            this.qtytxt.TabIndex = 74;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGV,
            this.mednameGV,
            this.medqtyGV,
            this.medpriceGV,
            this.medtotpriceGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(468, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(561, 432);
            this.dataGridView1.TabIndex = 73;
            // 
            // idGV
            // 
            this.idGV.HeaderText = "Medicine ID";
            this.idGV.Name = "idGV";
            this.idGV.ReadOnly = true;
            // 
            // mednameGV
            // 
            this.mednameGV.HeaderText = "Medicine Name";
            this.mednameGV.Name = "mednameGV";
            this.mednameGV.ReadOnly = true;
            // 
            // medqtyGV
            // 
            this.medqtyGV.HeaderText = "QTY";
            this.medqtyGV.Name = "medqtyGV";
            this.medqtyGV.ReadOnly = true;
            // 
            // medpriceGV
            // 
            this.medpriceGV.HeaderText = "Unit Price";
            this.medpriceGV.Name = "medpriceGV";
            this.medpriceGV.ReadOnly = true;
            // 
            // medtotpriceGV
            // 
            this.medtotpriceGV.HeaderText = "Total Price";
            this.medtotpriceGV.Name = "medtotpriceGV";
            this.medtotpriceGV.ReadOnly = true;
            // 
            // addbillbtn
            // 
            this.addbillbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addbillbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbillbtn.FlatAppearance.BorderSize = 0;
            this.addbillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbillbtn.ForeColor = System.Drawing.Color.White;
            this.addbillbtn.Location = new System.Drawing.Point(43, 360);
            this.addbillbtn.Name = "addbillbtn";
            this.addbillbtn.Size = new System.Drawing.Size(180, 33);
            this.addbillbtn.TabIndex = 70;
            this.addbillbtn.Text = "Add to Bill";
            this.addbillbtn.UseVisualStyleBackColor = false;
            this.addbillbtn.Click += new System.EventHandler(this.addbillbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(198, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Select Medicine";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 54);
            this.label1.TabIndex = 62;
            this.label1.Text = "Billing Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(282, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Available Stock";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(146, 423);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(180, 33);
            this.backbtn.TabIndex = 77;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // stocklbl
            // 
            this.stocklbl.AutoSize = true;
            this.stocklbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocklbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stocklbl.Location = new System.Drawing.Point(337, 136);
            this.stocklbl.Name = "stocklbl";
            this.stocklbl.Size = new System.Drawing.Size(18, 18);
            this.stocklbl.TabIndex = 78;
            this.stocklbl.Text = "0";
            // 
            // mednameDD
            // 
            this.mednameDD.BackColor = System.Drawing.Color.White;
            this.mednameDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mednameDD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mednameDD.ForeColor = System.Drawing.Color.Black;
            this.mednameDD.FormattingEnabled = true;
            this.mednameDD.Location = new System.Drawing.Point(52, 132);
            this.mednameDD.Name = "mednameDD";
            this.mednameDD.Size = new System.Drawing.Size(152, 26);
            this.mednameDD.TabIndex = 79;
            this.mednameDD.SelectionChangeCommitted += new System.EventHandler(this.mednameDD_SelectionChangeCommitted_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(461, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 54);
            this.label3.TabIndex = 80;
            this.label3.Text = "Total Amount :  Rs.";
            // 
            // totalamtlbl
            // 
            this.totalamtlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamtlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalamtlbl.Location = new System.Drawing.Point(779, 446);
            this.totalamtlbl.Name = "totalamtlbl";
            this.totalamtlbl.Size = new System.Drawing.Size(93, 46);
            this.totalamtlbl.TabIndex = 81;
            this.totalamtlbl.Text = "0";
            this.totalamtlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalamtlbl.Visible = false;
            // 
            // printbillbtn
            // 
            this.printbillbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printbillbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printbillbtn.FlatAppearance.BorderSize = 0;
            this.printbillbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbillbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbillbtn.ForeColor = System.Drawing.Color.White;
            this.printbillbtn.Location = new System.Drawing.Point(250, 360);
            this.printbillbtn.Name = "printbillbtn";
            this.printbillbtn.Size = new System.Drawing.Size(180, 33);
            this.printbillbtn.TabIndex = 82;
            this.printbillbtn.Text = "Print Bill";
            this.printbillbtn.UseVisualStyleBackColor = false;
            this.printbillbtn.Click += new System.EventHandler(this.printbillbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 501);
            this.Controls.Add(this.printbillbtn);
            this.Controls.Add(this.totalamtlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mednameDD);
            this.Controls.Add(this.stocklbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addbillbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addbillbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mednameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medqtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medpriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn medtotpriceGV;
        private System.Windows.Forms.Label stocklbl;
        private System.Windows.Forms.ComboBox mednameDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalamtlbl;
        private System.Windows.Forms.Button printbillbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}