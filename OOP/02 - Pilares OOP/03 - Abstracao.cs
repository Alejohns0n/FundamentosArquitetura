using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    /*Abstracao: criar conceitos genericos que possam ser utilizado por outras classes*/

    /*Quando marcamos a classe como abstrata estamos proibindo que alguem estancie,
     * ela so pode ser herdada e nao estanciada
     */
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //Quando temos um metodo abstrato, nao é obrigado a implementar o comportamento dele.
        public abstract void Ligar();
        //A classe que for implmeta-lo vai definir o comportamento dele gerando assim a tal da especializacao.
        public abstract void Desligar();

        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}