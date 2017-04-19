using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAula
{
    public class Aula
    {
        private int _numero;

        List<Alumno> _listaAlumnos;

        public int Numero
        {
            get { return this._numero; }
            set { this._numero = value; }
        }



        public List<Alumno> ListaAlumnos
        {
            get { return this._listaAlumnos; }
            set { this._listaAlumnos = value; }
        }
        
        
        public Aula(int numero)
        {
            this._numero = numero;
            this._listaAlumnos = new List<Alumno>();
        }


    }
}
