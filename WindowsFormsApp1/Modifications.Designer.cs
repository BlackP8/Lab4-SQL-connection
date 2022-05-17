
namespace WindowsFormsApp1
{
    partial class Modifications
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.btnAddRand = new System.Windows.Forms.Button();
            this.modnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 435);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(220, 39);
            this.btnGenerate.TabIndex = 32;
            this.btnGenerate.Text = "Сгенерировать данные";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modnumber,
            this.modname,
            this.time,
            this.worktype,
            this.benchnumber,
            this.detailnumber});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 388);
            this.dataGridView1.TabIndex = 33;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Mod_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Мод_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@mod_name", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@creation_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@bench_number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@detail_number", System.Data.SqlDbType.SmallInt, 2)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Mod_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер модификации", "Номер модификации"),
                        new System.Data.Common.DataColumnMapping("Название модификации", "Название модификации"),
                        new System.Data.Common.DataColumnMapping("Время изготовления", "Время изготовления"),
                        new System.Data.Common.DataColumnMapping("Тип модификации", "Тип модификации"),
                        new System.Data.Common.DataColumnMapping("Номер станка", "Номер станка"),
                        new System.Data.Common.DataColumnMapping("Номер детали", "Номер детали")})});
            // 
            // btnAddRand
            // 
            this.btnAddRand.Location = new System.Drawing.Point(288, 433);
            this.btnAddRand.Name = "btnAddRand";
            this.btnAddRand.Size = new System.Drawing.Size(215, 41);
            this.btnAddRand.TabIndex = 34;
            this.btnAddRand.Text = "Добавить записи";
            this.btnAddRand.UseVisualStyleBackColor = true;
            this.btnAddRand.Click += new System.EventHandler(this.btnAddRand_Click);
            // 
            // modnumber
            // 
            this.modnumber.HeaderText = "Номер модификации";
            this.modnumber.MinimumWidth = 8;
            this.modnumber.Name = "modnumber";
            this.modnumber.ReadOnly = true;
            this.modnumber.Width = 189;
            // 
            // modname
            // 
            this.modname.HeaderText = "Название модификации";
            this.modname.MinimumWidth = 8;
            this.modname.Name = "modname";
            this.modname.ReadOnly = true;
            this.modname.Width = 211;
            // 
            // time
            // 
            this.time.HeaderText = "Время изготовления";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 187;
            // 
            // worktype
            // 
            this.worktype.HeaderText = "Вид работы";
            this.worktype.MinimumWidth = 8;
            this.worktype.Name = "worktype";
            this.worktype.ReadOnly = true;
            this.worktype.Width = 125;
            // 
            // benchnumber
            // 
            this.benchnumber.HeaderText = "Номер станка";
            this.benchnumber.MinimumWidth = 8;
            this.benchnumber.Name = "benchnumber";
            this.benchnumber.ReadOnly = true;
            this.benchnumber.Width = 139;
            // 
            // detailnumber
            // 
            this.detailnumber.HeaderText = "Номер детали";
            this.detailnumber.MinimumWidth = 8;
            this.detailnumber.Name = "detailnumber";
            this.detailnumber.ReadOnly = true;
            this.detailnumber.Width = 143;
            // 
            // Modifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 499);
            this.Controls.Add(this.btnAddRand);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Modifications";
            this.Text = "Modifications";
            this.Load += new System.EventHandler(this.Modifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button btnAddRand;
        private System.Windows.Forms.DataGridViewTextBoxColumn modnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn modname;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn benchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailnumber;
    }
}