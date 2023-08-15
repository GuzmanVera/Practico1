using DataAccessLayer.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class DAL_Persona : IDAL_Persona
    {

        private List<Persona> personaList = new List<Persona>();

        List<Persona> IDAL_Persona.GetPersonas()
        {
            return personaList;
        }

        void IDAL_Persona.Insert(Persona persona)
        {
            personaList.Add(persona);
        }

        public List<Persona> GetPersonasOrdenadasPorFechaNacimiento()
        {
            return personaList.OrderBy(persona => persona.fechaNac).ToList();
        }
    }
}

