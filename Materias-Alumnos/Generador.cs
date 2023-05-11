namespace Materias_Alumnos
{
    public class Generador
    {
        public List<Materias> GenerarAlumnos(int cantMateria, int cantAlumnos)
        {
            var ListaMaterias = new List<Materias>();
            
            for (int i = 0;i< cantMateria; i++)
            {
                var materia = new Materias();
                materia._materiaId = $"Materia n°{i}";

                for(int j = 0;j< cantAlumnos; j++)
                {
                    var alumno = new Alumnos();
                    alumno._alumnoID = j;
                    alumno._nombre = $"Nombre {j}";
                    alumno._apellido = $"Apellido{j}";
                    alumno.legajo = $"Legajo N° {j}/23 - {materia._materiaId}";
                    materia._alumnos.Add(alumno);
                }

                ListaMaterias.Add(materia);
            }
            return ListaMaterias;
        }

        }
}