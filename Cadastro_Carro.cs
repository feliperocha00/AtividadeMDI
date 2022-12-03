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
    public partial class Cadastro_Carro : Form
    {
        Class_Carro cadcar = new Class_Carro();
        public Cadastro_Carro()
        {
            InitializeComponent();
        }

        private void Cadastro_Carro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //informações textBox
            cadcar.setChassi(int.Parse(textBox1.Text));
            cadcar.setDatafab(maskedTextBox1.Text);
            cadcar.setPlaca(textBox3.Text);
            cadcar.setModelo(textBox4.Text);
            cadcar.setPotencia(float.Parse(textBox5.Text));
            cadcar.setRenavam(textBox6.Text);
            cadcar.setMotor(float.Parse(textBox7.Text));
            cadcar.setCor(textBox8.Text);
            cadcar.setVariacao(textBox9.Text);
            cadcar.setCombustivel(textBox10.Text);



            //Conexao com Db para enviar as informações 
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=conce; password=''");
            MySqlCommand sqlQuery = new MySqlCommand($"INSERT INTO carro VALUE ('{cadcar.getChassi()}'," +
                                                                                $"'{cadcar.getDatafab()}'," +
                                                                                $"'{cadcar.getPlaca()}'," +
                                                                                $"'{cadcar.getModelo()}'," +
                                                                                $"'{cadcar.getPotencia()}'," +
                                                                                $"'{cadcar.getRenavam()}'," +
                                                                                $"'{cadcar.getMotor()}'," +
                                                                                $"'{cadcar.getCor()}'," +
                                                                                $"'{cadcar.getVariacao()}'," +
                                                                                $"'{cadcar.getCombustivel()}') ", conexao);

            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados enviado com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR Atençao!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fecha conexao
                conexao.Close();
            }
        }
    }
}
