using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Att3Westn
{
    public class Dono
    {
        private string nomedono { get; set; }
        private string enderecodono {get;set;}
        private int idadedono {get;set;}

        public List<cachorro> listaCachorro {get;set;} = new List<cachorro>();
        public List<gato> listaGato {get;set;} = new List<gato>();

        public Dono (string nome,string endereco,int idade){
            nomedono = nome;
            enderecodono = endereco;
            idadedono = idade;
        }


        public override string ToString(){
            return "\nNome do Dono: "+nomedono+"\nEndereço do Dono: "+enderecodono+"\nIdade do dono: "+idadedono;
        }



    }
}