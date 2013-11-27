using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlix.Commons.Entities;

namespace TicketFlix.Data.Persistence
{
    class INVENTARIOPersistence
    {
        public INVENTARIO Create(INVENTARIO entidad)
        {
            INVENTARIO respuesta = new INVENTARIO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    TicketFlixEntities.INVENTARIOs.Add(entidad);
                    TicketFlixEntities.SaveChanges();
                    respuesta = TicketFlixEntities.INVENTARIOs.Single(x => x.IDInventario == entidad.IDInventario);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public INVENTARIO Read(int ID)
        {
            INVENTARIO respuesta = new INVENTARIO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    respuesta = TicketFlixEntities.INVENTARIOs.Single(x => x.IDInventario == ID);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public bool Delete(INVENTARIO entidad)
        {
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    TicketFlixEntities.INVENTARIOs.Attach(entidad);
                    TicketFlixEntities.INVENTARIOs.Remove(entidad);
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

        public List<INVENTARIO> GetList()
        {
            List<INVENTARIO> lista = new List<INVENTARIO>();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    lista = TicketFlixEntities.INVENTARIOs.ToList<INVENTARIO>();
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
