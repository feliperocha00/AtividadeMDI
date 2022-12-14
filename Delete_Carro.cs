using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concessionaria
{
    public partial class Delete_Carro : Form
    {
        public Delete_Carro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Database
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("DELETE FROM carro WHERE chassi = " + int.Parse(textBox1.Text), conexao); // Instr. SQL
            conexao.Open(); // Abrir Conexão

            var resp = MessageBox.Show("Identificador: " + textBox1.Text + "\n\nDeseja realmente excluir?", "EXCLUIR?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                sqlQuery.ExecuteNonQuery(); // Executa a instrução SQL; 
                MessageBox.Show("Dados excluidos!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Carro_Load(object sender, EventArgs e)
        {

        }
    }
}
