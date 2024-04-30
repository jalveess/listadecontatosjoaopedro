using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_contato
{
    internal class contato
    {
        //Declaração de variáveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades. São os métodos "get" e "set"
        // get = leitura.
        // set= definição
        // é possível ser somente leitura, ou somente definição..
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;

            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {

                }
            }
        }
        //Construtor de classe.
        
        public contato()
        {
            Nome = "Cláudio";
            Sobrenome = "Genésio II";
            telefone = "(11) 98888 - 7777";
        }   
        // Sobrecarga do método construtor
        public contato (string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            telefone = telefone;
        }



    }//ToString() pertence a classe object.
    //Todas as classes são filhas de object (Herança).
    // "override" sobrescreve o método da classe pai (polímorfísmo).

    public override string tostring()
    {
        //Inicializa a variável como vazia.
        string saída = string.Empty;
        saída += String.Format("{0} {1} ", Nome, Sobrenome);
        saída += String.Format("({0}) {1}-{2} ",
            Telefone.Substring(0, 2),
            Telefone.Substring(3, 5),
            Telefone.Substring(7, 4);

        return saída;
    
      
        
       
        
    }
}




         

