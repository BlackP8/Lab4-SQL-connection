
namespace WindowsFormsApp1
{
    partial class Gilds
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
            this.btnAddGild = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gild_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.btnAddRand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGild
            // 
            this.btnAddGild.Location = new System.Drawing.Point(12, 339);
            this.btnAddGild.Name = "btnAddGild";
            this.btnAddGild.Size = new System.Drawing.Size(218, 41);
            this.btnAddGild.TabIndex = 19;
            this.btnAddGild.Text = "Сгенерировать данные";
            this.btnAddGild.UseVisualStyleBackColor = true;
            this.btnAddGild.Click += new System.EventHandler(this.btnAddGild_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gild_number,
            this.boss});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(605, 283);
            this.dataGridView1.TabIndex = 23;
            // 
            // gild_number
            // 
            this.gild_number.HeaderText = "Номер цеха";
            this.gild_number.MinimumWidth = 8;
            this.gild_number.Name = "gild_number";
            this.gild_number.ReadOnly = true;
            this.gild_number.Width = 123;
            // 
            // boss
            // 
            this.boss.HeaderText = "ФИО начальника";
            this.boss.MinimumWidth = 8;
            this.boss.Name = "boss";
            this.boss.ReadOnly = true;
            this.boss.Width = 162;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Gild_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Цех_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.TinyInt, 1),
            new System.Data.SqlClient.SqlParameter("@boss", System.Data.SqlDbType.VarChar, 50)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Gild_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха"),
                        new System.Data.Common.DataColumnMapping("ФИО начальника", "ФИО начальника")})});
            // 
            // btnAddRand
            // 
            this.btnAddRand.Location = new System.Drawing.Point(270, 339);
            this.btnAddRand.Name = "btnAddRand";
            this.btnAddRand.Size = new System.Drawing.Size(226, 41);
            this.btnAddRand.TabIndex = 30;
            this.btnAddRand.Text = "Добавить записи";
            this.btnAddRand.UseVisualStyleBackColor = true;
            this.btnAddRand.Click += new System.EventHandler(this.btnAddRand_Click);
            // 
            // Gilds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnAddRand);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddGild);
            this.Name = "Gilds";
            this.Text = "Gilds";
            this.Load += new System.EventHandler(this.Gilds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddGild;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gild_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn boss;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button btnAddRand;
    }
}