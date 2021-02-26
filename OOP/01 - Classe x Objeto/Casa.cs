using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    // Definição de Classe
    //Representacao de alguma coisa do mundo real.
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            // Definição de Objeto
            //Objeto é a classe estanciada e alocada na memoria, quando esta sendo declarada.
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}