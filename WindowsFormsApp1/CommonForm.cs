using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CommonForm : Form
    {
        public CommonForm()
        {
            InitializeComponent();
        }

        private void btnOpenBenches_Click(object sender, EventArgs e)
        {
            bool frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Form1");
            if (!frms)
            {
                Form1 benches = new Form1();
                benches.Show();
            }
        }

        private void btnOpenMods_Click(object sender, EventArgs e)
        {
            bool frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Modifications");
            if (!frms)
            {
                Modifications mods = new Modifications();
                mods.Show();
            }
        }

        private void btnOpenGilds_Click(object sender, EventArgs e)
        {
            bool frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Gilds");
            if (!frms)
            {
                Gilds gilds = new Gilds();
                gilds.Show();
            }
        }

        private void btnOpenDetails_Click(object sender, EventArgs e)
        {
            bool frms = Application.OpenForms.Cast<Form>().Select(x => x.Name).Contains("Detail");
            if (!frms)
            {
                Detail details = new Detail();
                details.Show();
            }
        }
    }
}
