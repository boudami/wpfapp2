using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Class1
    {
        public string nome;
        public string cognome;
        public Class1(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public Class1()
        {
        }

        public string getNome() { return nome; }
        public string getCognome() { return cognome; }
        public void setNome(string nome) { this.nome = nome; }
        public void setCognome(string cognome) { this.cognome = cognome;}
        public string toString() { return ("Il mio nome e' " +this.nome+ " il mio cognome e' " +this.cognome); }
    }
}
