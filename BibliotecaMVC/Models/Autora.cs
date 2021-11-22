using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMVC
{
    public class Autora
    {
        private string _nome { get; set; }

        public Autora()
        {

        }

        public Autora(string nome)
        {
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public List<Autora> Model1 => new List<Autora>() { 
            this,
            new Autora("Djamila")
        };
    }
}
