using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Att3Westn
{
    public class cachorro
    {
        public int idadedog { get; set; }
        public string vacinadodog {get;set;}
        public string nomedog {get;set;}
        public string racadog {get;set;}
        public string portedog {get;set;}

        public cachorro (int idade,string vacinado,string nome,string raca,string porte){
            idadedog = idade;
            vacinadodog = vacinado;
            nomedog = nome;
            racadog = raca;
            portedog = porte;
        }

        public override string ToString(){
            return "\nNome do dog: "+nomedog+"\nIdade do dog: "+idadedog+"\nVacinação: "+vacinadodog+"\nRaça: "+racadog+"\nPorte: "+portedog;
        }



    }
}