using System.Security.Cryptography;

namespace Materias_Alumnos
{
    public class Generador
    {
        public List<Materias> GenerarAlumnos(int cantMateria, int cantAlumnos)
        {
            var ListaMaterias = new List<Materias>();
            var random = new Random();
            
            for (int i = 0;i< cantMateria; i++)
            {
                var materia = new Materias();
                materia._materiaId = $"Materia n°{i}";

                for(int j = 0;j< cantAlumnos; j++)
                {
                    int k = random.Next(1, 36);
                    var alumno = new Alumnos();
                    alumno._alumnoID = j;
                    alumno._nombre = $"Nombre: {k}{j}";
                    alumno._apellido = $"Apellido: {j}";
                    alumno.legajo = $"Legajo N°: 00{j}/23 - {materia._materiaId}";
                    materia._alumnos.Add(alumno);
                }

                ListaMaterias.Add(materia);
            }
            return ListaMaterias;
        }

        }
}