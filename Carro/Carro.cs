using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Criar uma classe Carro e declare os seguintes atributos 
 *  na classe: Modelo, Cor, Ano Marca, Chassi, Proprietário,
 *  Velocidade máxima, Velocidade atual, Nr de portas, tem teto
 *  solar? Nr Marchas, tem cambio automático? Volume de
 *  combustível
Faça o encapsulamento da classe Carro e seus atributos
Implemente o método acelera que aumenta a velocidade de 1 
em 1 km/h e não ultrapassando o limite máximo.
Implemente o método freia que para o carro – Velocidade =
0 km/h
Implemente o método troca marcha
Implemente o método reduz a marcha;*/
namespace Carro
{
    internal class Carro
    {
        public string Modelo;
        public string Cor;
        public string Ano;
        public string Marca;
        private string Chassi;
        private string Proprietario;
        public int VelMax;
        public int VelAtual;
        public string portas;
        public bool teto;
        public int marchas;
        public bool automatico;
        public int tanque;
        public Carro()
        {

        }

        public void setChassi(string chassi)
        {
            this.Chassi = chassi;
        }

        public void setProprietario(string proprietario)
        {
            this.Proprietario = proprietario;
        }

        public string getChassi()
        {
            return Chassi;
        }

        public string getProprietario()
        {
            return Proprietario;
        }

        public void acelera()
        {
            if (VelAtual < VelMax)
            {
                VelAtual++;
            }
            
        }

        public void freia()
        {
            if (VelAtual > 0)
            {
                VelAtual--;
            }
        }
    }
}
