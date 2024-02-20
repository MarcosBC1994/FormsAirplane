using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Empresa empresa = new Empresa();
        public Form1()
        {
            InitializeComponent();
            empresa.ReadAeronaveComercial();
            empresa.ReadAeronaveMercadorias();
            empresa.ReadAeronaveParticular();
            empresa.ReadAviao();
            empresa.ReadAvioneta();
            timer1.Start();
            label2.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }




        private void Form1_btn1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(empresa);
            this.Hide();
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListsPlanes();
        }

        private void Form1_btn2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(empresa);
            this.Hide();
            form4.Show();
        }

        //FILTERS THE TABLE

        private void ListsPlanes()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"planes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length - 2; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsComercials()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"comercial.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "No. Flights per Day", "Company" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsCargos()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"cargos.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Cargo capacity", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsJets()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"jets.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Number of Owners", "Freight rate" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void ListsSmallPlanes()
        {
            //Clears the list
            //Reads from the file adding the Header and The content to the task DataGridView
            System.IO.StreamReader file = new System.IO.StreamReader(@"smallPlanes.csv");
            DataTable dt = new DataTable();
            List<string> columns = new List<string> { "Id", "Model", "Passengers", "Autonomy", "Last Maintenance", "State", "No.Motors", "Brand", "Year Production", "Minimum Takeoff Area", "Minimum Landing Area" };

            //Adds the Header to the Table
            foreach (string c in columns)
            {
                dt.Columns.Add(c);
            }
            string newline;
            string[] values;

            //Adds the lines to the Table and Uodates the Task List
            while ((newline = file.ReadLine()) != null)
            {
                values = newline.Split(';');

                DataRow dr = dt.NewRow();

                // Adiciona os valores à linha
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }

                // Adiciona a linha ao DataTable
                dt.Rows.Add(dr);
            }
            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Planes")
            {
                ListsPlanes();
            }
            if (comboBox1.Text == "Comercials")
            {
                ListsComercials();
            }
            if (comboBox1.Text == "Cargos")
            {
                ListsCargos();
            }
            if (comboBox1.Text == "Jets")
            {
                ListsJets();
            }
            if (comboBox1.Text == "SmallPlanes")
            {
                ListsSmallPlanes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(empresa);
            this.Hide();
            form5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(empresa);
            this.Hide();
            form6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(empresa);
            this.Hide();
            form7.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(empresa);
            this.Hide();
            form9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(empresa);
            this.Hide();
            form11.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = empresa.AdvanceOneDay(label2.Text);
            empresa.PlaneStatusBeginS(label2.Text);
            empresa.PlaneStatusEndS(label2.Text);
            empresa.PlaneStatusBeginC(label2.Text);
            empresa.PlaneStatusEndC(label2.Text);
            empresa.PlaneStatusBeginM(label2.Text);
            empresa.PlaneStatusEndM(label2.Text);
            empresa.PlaneStatusBeginJ(label2.Text);
            empresa.PlaneStatusEndJ(label2.Text);
            empresa.PlaneStatusBeginA(label2.Text);
            empresa.PlaneStatusEndA(label2.Text);

        }

       
    }
}
