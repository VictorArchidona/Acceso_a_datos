using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorPages.Modelos; // Asegúrate de importar el namespace correcto para Calificacion

namespace RazorPages.Services
{
    public class CalificacionRepositorio
    {
        private ColegioDbContext Context;
        public CalificacionRepositorio(ColegioDbContext context)
        {
            Context = context;
        }

        public void Insertar(Calificacion calificacion)
        {
            Context.Calificaciones.Add(calificacion);
            Context.SaveChanges();
        }

        public IEnumerable<Calificacion> GetCalificacionesConvAsign(Convocatoria convocatoria, int asignatura)
        {
            return Context.Calificaciones.Where(c => c.asignaturaID == asignatura && c.convocatoria == convocatoria).ToList();


        }
    }
}
