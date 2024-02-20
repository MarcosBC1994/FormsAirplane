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
    public partial class Form4 : Form
    {
        Empresa empresaState = new Empresa();

        public Form4(Empresa empresa)
        {
            InitializeComponent();
            empresaState.ReadAeronaveComercial();
            empresaState.ReadAeronaveMercadorias();
            empresaState.ReadAeronaveParticular();
            empresaState.ReadAviao();
            empresaState.ReadAvioneta();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            empresaState.ChangeAviaoState(int.Parse(textBox1.Text), comboBox1.Text);
        }
    }
}
