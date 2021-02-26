using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //Funcionario é uma pessoa, esse é o pensamento da base da oop mas nem sempre é recomendado.
    //É um? se nao fazer sentido é melhor nao herdar.
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }
    //Quando herdamos uma classe nos tbm herdamos os estados e comportamentos daquela classe.
    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            funcionario.CalcularIdade();
        }
    }
}