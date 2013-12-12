using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlix.Commons.Entities;

namespace TicketFlix.Data.Persistence
{
    public class SALAPersistence
    {
        public SALA Create(SALA entidad)
        {
            SALA respuesta = new SALA();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    TicketFlixEntities.SALAs.Add(entidad);
                    TicketFlixEntities.SaveChanges();
                    respuesta = TicketFlixEntities.SALAs.Single(x => x.IDSala == entidad.IDSala);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public SALA Read(int ID)
        {
            SALA respuesta = new SALA();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    respuesta = TicketFlixEntities.SALAs.Single(x => x.IDSala == ID);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public SALA Update(SALA entidad)
        {
            SALA updation;
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    updation = TicketFlixEntities.SALAs.Single(x => x.IDSala == entidad.IDSala);
                    TicketFlixEntities.Entry(updation).CurrentValues.SetValues(entidad);
                    TicketFlixEntities.SaveChanges();
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return updation;
        }

        public bool Delete(SALA entidad)
        {
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    TicketFlixEntities.SALAs.Attach(entidad);
                    TicketFlixEntities.SALAs.Remove(entidad);
                    TicketFlixEntities.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
        }

        public List<SALA> GetList()
        {
            List<SALA> lista = new List<SALA>();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    lista = TicketFlixEntities.SALAs.ToList<SALA>();
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return lista;
        }
    }
}
