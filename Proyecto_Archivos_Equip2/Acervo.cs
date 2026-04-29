using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos_Equip2
{
    internal class Acervo
    {
        // Atributos
        string tipo = "";
        string titulo = "";
        string disponible = "";

        // Propiedades
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        // Constructores
        // Vacio
        public Acervo()
        {
        }
        // Sobrecargado
        public Acervo(string ti,string d, string t)
        {
            tipo = ti;
            titulo = t;
            disponible = d;
        }
    }
}

       

    

