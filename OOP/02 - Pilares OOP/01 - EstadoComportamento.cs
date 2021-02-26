using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    /*Metodo seria o comportamento e a 
     * propriedade seria o estado*/
    public class Pessoa
    {
        //O estado esta representado atraves das propriedades dessa classe.
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //Comportamento é quando é gera uma nova informacao ou quando processa uma informacao
        //atraves da propria classe, a classe se comporta processando/transformando informaçoes e devolvendo outras. 
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
        //E o metodo tbm pode alterar o estado da classe. Pode ter um metodo que altera o estado do Nome.
    }
}