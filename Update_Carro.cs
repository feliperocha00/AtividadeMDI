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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Concessionaria
{
    public partial class Update_Carro : Form
    {
        Class_Carro uptcar = new Class_Carro();
        public Update_Carro()
        {
            InitializeComponent();
        }

        private void Update_Carro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Atualizar           
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''"); // Conexão - Server: porta / DB
            MySqlCommand sqlQuery = new MySqlCommand("UPDATE carro SET datafab = '" + maskedTextBox1.Text +
                                                                    "', placa = '" + textBox3.Text +
                                                                    "', modelo = '" + textBox4.Text +
                                                                    "', potencia = '" + textBox5.Text +
                                                                    "', renavam = '" + textBox6.Text +
                                                                    "', motor = '" + textBox7.Text +
                                                                    "', cor = '" + textBox8.Text +
                                                                    "', variacao = '" + textBox9.Text +
                                                                    "', combustivel = '" + textBox10.Text +
                                                                    "' WHERE chassi = "+ int.Parse(textBox1.Text), conexao); // Instr. SQL



            conexao.Open(); // Abrir Conexão

            var resp = MessageBox.Show("Identificador: " + textBox1.Text + "\n\nDeseja realmente alterar ? ", "Alterar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                sqlQuery.ExecuteNonQuery(); // Executa a instrução SQL; 
                MessageBox.Show("Dados alterados!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
