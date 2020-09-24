using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testesite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("server=N056; Database=siteteste;Integrated Security=true;");

            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios ORDER BY nome", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();

            string listaDeNomes = "";

            while (dr.Read())
            {
                listaDeNomes += dr["nome"] + System.Environment.NewLine;
            }

            textBox1.Text = listaDeNomes;
            

            sqlConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("server=N056; Database=siteteste;Integrated Security=true;");

            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios ORDER BY email", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();

            string listaDeEmail = "";

            while (dr.Read())
            {
                listaDeEmail += dr["email"] + System.Environment.NewLine;
            }

            textBox2.Text = listaDeEmail;


            sqlConn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("server=N056; Database=siteteste;Integrated Security=true;");

            sqlConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();

            string listaDeCidade = "";

            while (dr.Read())
            {
                listaDeCidade += dr["cidade"] + System.Environment.NewLine;
            }

            textBox3.Text = listaDeCidade;


            sqlConn.Close();
        }
    }
}
