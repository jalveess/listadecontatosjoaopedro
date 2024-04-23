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
    
}     //Propriedades. São os métodos "get" e "set"
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
            if (value.Lenght == 13)
            {
                telefone = value;
            }
            else
            {

            }




         

