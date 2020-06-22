using System;
using System.Collections.Generic;
using System.Text;

namespace List_Exercicio1
{
    class Funcionario
    {
        private int _id;
        private string _nome;
        private double _salario;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public Funcionario(int id, string nome, double salario)
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }
     

        public void Aumento(double porcent) {
                        
            Salario += Salario * porcent / 100;           
        }

        public override string ToString()
        {
            return "Id: " + Id + " Nome: " + Nome + " Salario: R$" + Salario.ToString("F2");
        }
    }
}
