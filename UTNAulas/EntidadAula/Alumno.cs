using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadAula
{
    public class Alumno
    {
        private int _legajo;
        private ESexo _sexo;
        private string _nombre;

        //Propiedades.
        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        
        public ESexo Sexo
        {
            get { return this._sexo; }
            set { this._sexo = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        
        //Creo Constructor que recibe los 3 párametros.
        public Alumno(int legajo, ESexo sexo, string nombre)
        {
            this.Legajo = legajo;
            this.Sexo = sexo;
            this.Nombre = nombre;
        }


    }
}
