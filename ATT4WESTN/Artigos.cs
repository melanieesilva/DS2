using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATT4WESTN
{
    public class Artigos
    {
        public string tituloart {get;set;}
        public string palavrachaveart {get;set;}
        public string instituicaoart {get;set;}

        Autores autor = new Autores();
        public List<Autores> listaAutores {get;set;} = new List<Autores>();

        public void Cadastrar_Artigo(Autores autor, string titulo, string palavrachave, string instituicao){
            listaAutores.Add(autor);
            tituloart = titulo;
            palavrachaveart = palavrachave;
            instituicaoart = instituicao;
        }

        public void Exibir_Artigos(string palavrachave){
            System.Console.WriteLine("Título Artigo: "+tituloart);
            System.Console.WriteLine("Palavra Chave: "+palavrachaveart);
            System.Console.WriteLine("Instituição: "+instituicaoart);
            
            foreach (var item in listaAutores)
            {
                System.Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            return "Título Artigo: "+tituloart+"Palavra Chave: "+palavrachaveart+"Instituição: "+instituicaoart;
        }
    }
}