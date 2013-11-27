using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlix.Commons.Entities;

namespace TicketFlix.Data.Persistence
{
    public class HORARIOPersistence
    {

        public HORARIO Create(HORARIO entidad)
        {
            HORARIO respuesta = new HORARIO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    entidad.SALA = TicketFlixEntities.SALAs.Single(x => x.IDSala == entidad.SALA.IDSala);
                    TicketFlixEntities.HORARIOs.Add(entidad);
                    TicketFlixEntities.SaveChanges();
                    respuesta = TicketFlixEntities.HORARIOs.Single(x => x.IDHorario == entidad.IDHorario);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public HORARIO Read(int ID)
        {
            HORARIO respuesta = new HORARIO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    respuesta = TicketFlixEntities.HORARIOs.Include("SALA").Single(x => x.IDHorario == ID);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public bool Delete(HORARIO entidad)
        {
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    var deletion = TicketFlixEntities.HORARIOs.Include("SALA").Single(x => x.IDHorario == entidad.IDHorario);
                    TicketFlixEntities.HORARIOs.Remove(deletion);
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

        public List<HORARIO> GetList()
        {
            List<HORARIO> lista = new List<HORARIO>();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    lista = TicketFlixEntities.HORARIOs.Include("SALA").ToList<HORARIO>();
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

