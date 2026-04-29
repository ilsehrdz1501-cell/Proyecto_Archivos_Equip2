using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto {
    internal class Acervo {
        //atributos
        int numero;
        string titulo;
        string editorial;

        //propiedades
        public int Numero {
            get { return numero; }
            set { numero = value; }
        }
        public string Titulo {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Editorial {
            get { return editorial; }
            set { editorial = value; }
        }

        //constructores
        public Acervo() { }
        public Acervo(int numero, string titulo, string editorial) {
            Numero = numero;
            Titulo = titulo;
            Editorial = editorial;
        }

        //metodos

    }
}
