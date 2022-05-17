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
    public partial class Gilds : Form
    {
        public Gilds()
        {
            InitializeComponent();
        }

        private void Gilds_Load(object sender, EventArgs e)
        {
        }

        private void btnAddGild_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult res = openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                // считать строки из файла
                List<string[]> rows = File.ReadAllLines(filename).Select(x => x.Split('|')).ToList();

                // добавить строки в  dataGridView
                for (int i = 0; i < rows.Count; i++)
                {
                    dataGridView1.Rows.Add(rows[i]);
                }
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void btnAddRand_Click(object sender, EventArgs e)
        {
            int j = 0;

            sqlConnection1.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sqlInsertCommand1.Parameters["@number"].Value = dataGridView1.Rows[i].Cells[j].Value;
                sqlInsertCommand1.Parameters["@boss"].Value = dataGridView1.Rows[i].Cells[j + 1].Value;
                sqlInsertCommand1.ExecuteNonQuery();
            }   
            sqlConnection1.Close();

            MessageBox.Show("Цеха добавлены!");
        }
    }
}
