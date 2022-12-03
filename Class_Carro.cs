using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    internal class Class_Carro
    {
        // declarações
        private int chassi;
        private string datafab;
        private string placa;
        private string modelo;
        private float potencia;
        private string renavam;
        private float motor;
        private string cor;
        private string variacao;
        private string combustivel;

        // Métodos
        public Class_Carro()
        {
            this.chassi = 0;
            this.datafab = "";
            this.placa = "";
            this.modelo = "";
            this.potencia = 0;
            this.renavam = "";
            this.motor = 0;
            this.cor = "";
            this.variacao = "";
            this.combustivel = "";
        }

        public Class_Carro(
            int p_chassi,
            string p_datafab,
            string p_placa,
            string p_modelo,
            float p_potencia,
            string p_renavam,
            float p_motor,
            string p_cor,
            string p_variacao,
            string p_combustivel
            )
        {
            this.chassi = p_chassi;
            this.datafab = p_datafab;
            this.placa = p_placa;
            this.modelo = p_modelo;
            this.potencia = p_potencia;
            this.renavam = p_renavam;
            this.cor = p_cor;
            this.variacao = p_variacao;
            this.combustivel = p_combustivel;

        }

        // Get || Set

        //Chassi / ID
        public int getChassi() { return this.chassi; }
        public void setChassi(int p_chassi) { this.chassi = p_chassi; }
        

        public string getDatafab() { return this.datafab; }
        public void setDatafab(string p_datafab) { this.datafab = p_datafab; }
        

        public string getPlaca() { return this.placa; }
        public void setPlaca(string p_placa) { this.placa = p_placa; }
        
        
        public string getModelo() { return this.modelo; }
        public void setModelo(string p_modelo) { this.modelo = p_modelo; }
        
        
        public float getPotencia() { return this.potencia; }
        public void setPotencia(float p_potencia) { this.potencia = p_potencia; }

        public string getRenavam() { return this.renavam; }
        public void setRenavam(string p_renavam) { this.renavam = p_renavam; }
        
        
        public float getMotor() { return this.motor; }
        public void setMotor(float p_motor) { this.motor = p_motor; }

        public string getCor() { return this.cor; }
        public void setCor(string p_cor) { this.cor = p_cor; }
        
        public string getVariacao() { return this.variacao; }
        public void setVariacao(string p_variacao) { this.variacao = p_variacao; }
        
        
        public string getCombustivel() { return this.combustivel; }
        public void setCombustivel(string p_combustivel) { this.combustivel = p_combustivel; }
    }
}
