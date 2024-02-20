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
    public partial class Form9 : Form
    {
        public Form9(Empresa empresa)
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            string dias= ((dt1 - dt2).TotalDays).ToString();
            int daysNumber=int.Parse(dias);
            daysNumber=Math.Abs(daysNumber);

            Form10 form10 = new Form10(daysNumber);
            this.Hide();
            form10.Show();
        }
    }
}
