using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materias_Alumnos
{
    public class Materias
    {
        public string _materiaId { get; set; }
        public List<Alumnos> _alumnos { get; set; }

        public List<Alumnos> retornodelista()
            {
            return _alumnos;
            }


        public Materias() 
        {
            _alumnos = new List<Alumnos>(); 
        }
    }
}
