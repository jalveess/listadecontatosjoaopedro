using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
namespace lista_de_contato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private contato[] listadecontato = new contato[1];

        private void Escrever(contato contato)
        {
            StreamWriter escrever = new StreamWriter("Contatos.txt");

            escrever.WriteLine(listaDeContatos.Lenght + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listaDeContatos.Lenght; x++)
            {
                escrever.WriteLine(listadecontato[x].Nome);
                escrever.WriteLine(listadecontato[x].Sobrenome);
                escrever.WriteLine(listaDeContatos[x].Telefone);
            }

            escrever.Close();
        }


        private void Ler()
        {
            StreamReader ler = new StreamReader("Contatos.txt");


        }

        private void Form1_Load(object sender, EventArgs e) 

        
       
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um objeto da classe contato.
            contato contato = new contato();

            contato.Nome = TextBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.telefone = textBoxTelefone.Text;

            ListBoxContatos.Items.Add(contato); 




        }
    }
}
