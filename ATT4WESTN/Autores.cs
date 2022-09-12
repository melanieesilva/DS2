using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATT4WESTN
{
    public class Autores
    {
        public string nomeautor {get;set;}
        public string email {get;set;}

        public Autores (string nome, string emailautor){
            nomeautor = nome;
            email = emailautor;
        }

        public Autores (){

        }

        public override string ToString()
        {
            return "Nome do Autor: "+nomeautor+"\nE-mail: "+email;
        }
    }
}