
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.btnGenBench = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.btnAddRand = new System.Windows.Forms.Button();
            this.bench_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gild_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bench_number,
            this.work_time,
            this.mod_count,
            this.work_type,
            this.gild_number});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-JILB1LC\\SQLEXPRESS;Initial Catalog=ISTB-18-1_Romanov_Lab2;Int" +
    "egrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // btnGenBench
            // 
            this.btnGenBench.Location = new System.Drawing.Point(12, 395);
            this.btnGenBench.Name = "btnGenBench";
            this.btnGenBench.Size = new System.Drawing.Size(209, 38);
            this.btnGenBench.TabIndex = 1;
            this.btnGenBench.Text = "Сгенерировать данные";
            this.btnGenBench.UseVisualStyleBackColor = true;
            this.btnGenBench.Click += new System.EventHandler(this.btnGenBench_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.Bench_Select";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.Станок_добавление";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_time", System.Data.SqlDbType.Float, 8),
            new System.Data.SqlClient.SqlParameter("@mod_count", System.Data.SqlDbType.SmallInt, 2),
            new System.Data.SqlClient.SqlParameter("@work_type", System.Data.SqlDbType.VarChar, 100),
            new System.Data.SqlClient.SqlParameter("@gild_number", System.Data.SqlDbType.TinyInt, 1)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bench_Select", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Номер станка", "Номер станка"),
                        new System.Data.Common.DataColumnMapping("Время работы", "Время работы"),
                        new System.Data.Common.DataColumnMapping("Кол-во произвед. мод.", "Кол-во произвед. мод."),
                        new System.Data.Common.DataColumnMapping("Вид работы", "Вид работы"),
                        new System.Data.Common.DataColumnMapping("Номер цеха", "Номер цеха")})});
            // 
            // btnAddRand
            // 
            this.btnAddRand.Location = new System.Drawing.Point(280, 394);
            this.btnAddRand.Name = "btnAddRand";
            this.btnAddRand.Size = new System.Drawing.Size(211, 41);
            this.btnAddRand.TabIndex = 31;
            this.btnAddRand.Text = "Добавить записи";
            this.btnAddRand.UseVisualStyleBackColor = true;
            this.btnAddRand.Click += new System.EventHandler(this.btnAddRand_Click);
            // 
            // bench_number
            // 
            this.bench_number.HeaderText = "Номер станка";
            this.bench_number.MinimumWidth = 8;
            this.bench_number.Name = "bench_number";
            this.bench_number.ReadOnly = true;
            this.bench_number.Width = 151;
            // 
            // work_time
            // 
            this.work_time.HeaderText = "Время работы";
            this.work_time.MinimumWidth = 8;
            this.work_time.Name = "work_time";
            this.work_time.ReadOnly = true;
            this.work_time.Width = 154;
            // 
            // mod_count
            // 
            this.mod_count.HeaderText = "Кол-во произвед. мод.";
            this.mod_count.MinimumWidth = 8;
            this.mod_count.Name = "mod_count";
            this.mod_count.ReadOnly = true;
            this.mod_count.Width = 167;
            // 
            // work_type
            // 
            this.work_type.HeaderText = "Вид работы";
            this.work_type.MinimumWidth = 8;
            this.work_type.Name = "work_type";
            this.work_type.ReadOnly = true;
            this.work_type.Width = 125;
            // 
            // gild_number
            // 
            this.gild_number.HeaderText = "Номер цеха";
            this.gild_number.MinimumWidth = 8;
            this.gild_number.Name = "gild_number";
            this.gild_number.ReadOnly = true;
            this.gild_number.Width = 123;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 455);
            this.Controls.Add(this.btnAddRand);
            this.Controls.Add(this.btnGenBench);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Станки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button btnGenBench;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button btnAddRand;
        private System.Windows.Forms.DataGridViewTextBoxColumn bench_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn gild_number;
    }
}

