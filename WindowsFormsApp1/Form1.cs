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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenBench_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult res = openFileDialog1.ShowDialog();


            if (res == DialogResult.OK)
            {
                double workTime = 0;
                int modCount = 0;
                string path = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/type.txt";
                string[] workType = File.ReadAllLines(path);
                string path_gilds = @"D:/Универская шелуха/4 курс/Политех/УД/Лаб 4/gildsnum.txt";
                string[] gilds = File.ReadAllLines(path_gilds);
                string filename = openFileDialog1.FileName;

                //считать строки из файла
                List<string[]> rows = File.ReadAllLines(filename).Select(x => x.Split('|')).ToList();
                string[] workTimeArray = new string[rows.Count];
                string[] modCountArray = new string[rows.Count];
                string[] type = new string[rows.Count];
                string[] numbers = new string[rows.Count];

                // добавить строки в  dataGridView
                for (int i = 0; i < rows.Count ; i++)
                {
                    workTime = Convert.ToDouble(rnd.Next(10, 120) / 10.0);
                    modCount = rnd.Next(50, 500);
                    workTimeArray[i] = Convert.ToString(workTime);
                    modCountArray[i] = Convert.ToString(modCount);
                    dataGridView1.Rows.Add(rows[i]);
                }

                for (int i = 0; i < rows.Count; i++)
{
                    dataGridView1.Rows[i].Cells[1].Value = workTimeArray[i];
                    dataGridView1.Rows[i].Cells[2].Value = modCountArray[i];
                    type[i] = workType[new Random().Next(0, workType.Length)];
                    dataGridView1.Rows[i].Cells[3].Value = type[i];
                    numbers[i] = gilds[new Random().Next(0, gilds.Length)];
                    dataGridView1.Rows[i].Cells[4].Value = numbers[i];
                }
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void btnAddRand_Click(object sender, EventArgs e)
        {
            int randLength = rnd.Next(1, dataGridView1.RowCount);

            //Получить случайное число (в диапазоне количества строк)

            int countOfRecords = 0;

            int j = 0;
            sqlConnection1.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sqlInsertCommand1.Parameters["@number"].Value = dataGridView1.Rows[i].Cells[j].Value;
                sqlInsertCommand1.Parameters["@work_time"].Value = dataGridView1.Rows[i].Cells[j + 1].Value;
                sqlInsertCommand1.Parameters["@mod_count"].Value = dataGridView1.Rows[i].Cells[j + 2].Value;
                sqlInsertCommand1.Parameters["@work_type"].Value = dataGridView1.Rows[i].Cells[j + 3].Value;
                sqlInsertCommand1.Parameters["@gild_number"].Value = dataGridView1.Rows[i].Cells[j + 4].Value;
                sqlInsertCommand1.ExecuteNonQuery();
                countOfRecords++;
            }
            sqlConnection1.Close();

            MessageBox.Show("Добавлено " + countOfRecords + " станков!");
        }
    }
}
