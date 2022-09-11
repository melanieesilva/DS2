using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Att3Westn
{
    public class gato
    {
        public int idadegato { get; set; }
        public string vacinadogato {get;set;}
        public string nomegato {get;set;}
        public string racagato {get;set;}

          public gato (int idade,string vacinado,string nome,string raca){
            idadegato = idade;
            vacinadogato = vacinado;
            nomegato = nome;
            racagato = raca;
        }

        public override string ToString(){
            return "\nNome do gato: "+nomegato+"\nIdade do gato: "+idadegato+"\nVacinação: "+vacinadogato+"\nRaça: "+racagato;
        }
    }
}