using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlix.Commons.Entities;

namespace TicketFlix.Data.Persistence
{
    public class ASIENTOPersistence
    {
        public ASIENTO Create(ASIENTO entidad)
        {
            ASIENTO respuesta = new ASIENTO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    entidad.SALA = TicketFlixEntities.SALAs.Single(x => x.IDSala == entidad.SALA.IDSala);
                    TicketFlixEntities.ASIENTOes.Add(entidad);
                    TicketFlixEntities.SaveChanges();
                    respuesta = TicketFlixEntities.ASIENTOes.Single(x => x.IDAsiento == entidad.IDAsiento);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public ASIENTO Read(int ID)
        {
            ASIENTO respuesta = new ASIENTO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    respuesta = TicketFlixEntities.ASIENTOes.Include("SALA").Single(x => x.IDAsiento == ID);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public ASIENTO Update(ASIENTO entidad)
        {
            ASIENTO updation;
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    updation = TicketFlixEntities.ASIENTOes.Include("SALA").Single(x => x.IDAsiento == entidad.IDAsiento);
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

        public bool Delete(ASIENTO entidad)
        {
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    var deletion = TicketFlixEntities.ASIENTOes.Include("SALA").Single(x => x.IDAsiento == entidad.IDAsiento);
                    TicketFlixEntities.ASIENTOes.Remove(deletion);
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

        public List<ASIENTO> GetList()
        {
            List<ASIENTO> lista = new List<ASIENTO>();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    lista = TicketFlixEntities.ASIENTOes.Include("SALA").ToList<ASIENTO>();
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
