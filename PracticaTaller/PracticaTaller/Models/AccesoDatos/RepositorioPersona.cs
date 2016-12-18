using PracticaTaller.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaTaller.Models
{
    public class RepositorioPersona
    {
        PracticaJonathanDB taller = new PracticaJonathanDB();
        public void Guardar(Persona persona)
        {
            taller.Persona.Add(persona);
            taller.SaveChanges();
        }
    }
}