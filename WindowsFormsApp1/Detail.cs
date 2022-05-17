using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                //int n = 1000;
                //string path = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/type.txt";
                //string[] workType = File.ReadAllLines(path);
                string filename = openFileDialog1.FileName;
                // считать строки из файла
                List<string[]> rows = File.ReadAllLines(filename).Select(x => x.Split('|')).ToList();
                //string[] type = new string[rows.Count];

                // добавить строки в  dataGridView
                for (int i = 0; i < rows.Count; i++)
                {
                    dataGridView1.Rows.Add(rows[i]);
                }

                //for (int i = 0; i < rows.Count; i++)
                //{
                //    type[i] = workType[new Random().Next(0, workType.Length)];
                //    dataGridView1.Rows[i].Cells[3].Value = type[i];
                //}
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void btnAddRand_Click(object sender, EventArgs e)
        {
            int j = 0;
            int count = 0;

            sqlConnection1.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sqlInsertCommand1.Parameters["@number"].Value = dataGridView1.Rows[i].Cells[j].Value;
                sqlInsertCommand1.Parameters["@detail_name"].Value = dataGridView1.Rows[i].Cells[j + 1].Value;
                sqlInsertCommand1.Parameters["@deliver_date"].Value = dataGridView1.Rows[i].Cells[j + 2].Value;
                sqlInsertCommand1.Parameters["@detail_type"].Value = dataGridView1.Rows[i].Cells[j + 3].Value;
                sqlInsertCommand1.ExecuteNonQuery();
                count++;
            }
            sqlConnection1.Close();

            MessageBox.Show("Добавлено 8000 деталей!");
        }
    }
}
