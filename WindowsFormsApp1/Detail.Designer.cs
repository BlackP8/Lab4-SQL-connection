
namespace WindowsFormsApp1
{
    partial class Detail
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
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detail_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddRand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(13, 374);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(209, 41);
            this.btnAddDetail.TabIndex = 15;
            this.btnAddDetail.Text = "Сгенерировать данные";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail_number,
            this.detail_name,
            this.date,
            this.detail_type});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(894, 325);
            this.dataGridView1.TabIndex = 28;
            // 
            // detail_number
            // 
            this.detail_number.HeaderText = "Номер детали";
            this.detail_number.MinimumWidth = 8;
            this.detail_number.Name = "detail_number";
            this.detail_number.ReadOnly = true;
            this.detail_number.Width = 143;
            // 
            // detail_name
            // 
            this.detail_name.HeaderText = "Название детали";
            this.detail_name.MinimumWidth = 8;
            this.detail_name.Name = "detail_name";
            this.detail_name.ReadOnly = true;
            this.detail_name.Width = 165;
            // 
            // date
            // 
            this.date.HeaderText = "Дата привоза";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 138;
            // 
            // detail_type
            // 
            this.detail_type.HeaderText = "Вид детали";
            this.detail_type.MinimumWidth = 8;
            this.detail_type.Name = "detail_type";
            this.detail_type.ReadOnly = true;
            this.detail_type.Width = 126;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Detail_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Деталь_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@deliver_date", System.Data.SqlDbType.DateTime, 8),
            new System.Data.SqlClient.SqlParameter("@detail_type", System.Data.SqlDbType.VarChar, 100)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.Деталь_удаление";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Detail_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер детали", "Номер детали"),
                        new System.Data.Common.DataColumnMapping("Название детали", "Название детали"),
                        new System.Data.Common.DataColumnMapping("Дата привоза", "Дата привоза"),
                        new System.Data.Common.DataColumnMapping("Вид детали", "Вид детали")})});
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddRand
            // 
            this.btnAddRand.Location = new System.Drawing.Point(269, 374);
            this.btnAddRand.Name = "btnAddRand";
            this.btnAddRand.Size = new System.Drawing.Size(216, 41);
            this.btnAddRand.TabIndex = 29;
            this.btnAddRand.Text = "Добавить записи";
            this.btnAddRand.UseVisualStyleBackColor = true;
            this.btnAddRand.Click += new System.EventHandler(this.btnAddRand_Click);
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 433);
            this.Controls.Add(this.btnAddRand);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddDetail);
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail_type;
        private System.Windows.Forms.Button btnAddRand;
    }
}