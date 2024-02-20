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
    public partial class Form6 : Form
    {
        Empresa EmpresaManutencao = new Empresa();
        public Form6(Empresa empresa)
        {
            InitializeComponent();
            EmpresaManutencao = empresa;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                if (values[5] == "Maintenance")
                {
                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }

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

                if (values[5] == "Maintenance")
                {
                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }
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

                if (values[5] == "Maintenance")
                {
                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }
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

                if (values[5] == "Maintenance")
                {
                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }
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

                if (values[5] == "Maintenance")
                {
                    // Adiciona a linha ao DataTable
                    dt.Rows.Add(dr);
                }
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

        private void Form5_Load(object sender, EventArgs e)
        {
            ListsPlanes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
