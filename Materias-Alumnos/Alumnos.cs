using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_Alumnos
{
    public class Alumnos
    {
        public int _alumnoID {  get; set; }
        public string _apellido { get; set; }
        public string _nombre { get; set; }
        public string legajo { get; set; }
        public string _nota { get; set; }


        public string _nombreCompleto () 
        {
            return $"{ _nombre}, { _apellido}";
        }


        public Alumnos() {}
    }
}
