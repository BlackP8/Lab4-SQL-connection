using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Modifications : Form
    {
        Random rnd = new Random();

        public Modifications()
        {
            InitializeComponent();
        }

        private void Modifications_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                //double creationTime = 0;
                //string path = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/type.txt";
                //string[] workType = File.ReadAllLines(path);
                //string path_det = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/detnum.txt";
                //string[] details = File.ReadAllLines(path_det);
                //string path_benches = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/be.txt";
                //string[] benches = File.ReadAllLines(path_benches);
                //int n = 1000;
                string filename = openFileDialog1.FileName;
                // считать строки из файла
                List<string[]> rows = File.ReadAllLines(filename).Select(x => x.Split('|')).ToList();
                //string[] type = new string[n];
                //string[] modTime = new string[n];
                //string[] b = new string[n];


                // добавить строки в  dataGridView
                for (int i = 0; i < rows.Count; i++)
                {
                    //creationTime = Convert.ToDouble(rnd.Next(10, 240) / 10.0);
                    //modTime[i] = Convert.ToString(creationTime);
                    dataGridView1.Rows.Add(rows[i]);
                }

                //for (int i = 0; i < n; i++)
                //{
                //    dataGridView1.Rows[i].Cells[2].Value = modTime[i];
                //    type[i] = workType[new Random().Next(0, workType.Length)];
                //    dataGridView1.Rows[i].Cells[3].Value = type[i];
                //    b[i] = benches[new Random().Next(70, benches.Length)];
                //    dataGridView1.Rows[i].Cells[4].Value = b[i];
                //    dataGridView1.Rows[i].Cells[5].Value = details[i];
                //}
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void btnAddRand_Click(object sender, EventArgs e)
        {

            ////Получить случайное число (в диапазоне количества строк)
            //int i = rnd.Next(0, dataGridView1.RowCount);

            int j = 0;

            sqlConnection1.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sqlInsertCommand1.Parameters["@number"].Value = dataGridView1.Rows[i].Cells[j].Value;
                sqlInsertCommand1.Parameters["@mod_name"].Value = dataGridView1.Rows[i].Cells[j + 1].Value;
                sqlInsertCommand1.Parameters["@creation_time"].Value = dataGridView1.Rows[i].Cells[j + 2].Value;
                sqlInsertCommand1.Parameters["@mod_type"].Value = dataGridView1.Rows[i].Cells[j + 3].Value;
                sqlInsertCommand1.Parameters["@bench_number"].Value = dataGridView1.Rows[i].Cells[j + 4].Value;
                sqlInsertCommand1.Parameters["@detail_number"].Value = dataGridView1.Rows[i].Cells[j + 5].Value;
                sqlInsertCommand1.ExecuteNonQuery();
            }
            sqlConnection1.Close();

            MessageBox.Show("Добавлено 35000 модификаций!");
        }
    }
}
