using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketFlix.Commons.Entities;

namespace TicketFlix.Data.Persistence
{
    class PRODUCTOPersistence
    {
        public PRODUCTO Create(PRODUCTO entidad)
        {
            PRODUCTO respuesta = new PRODUCTO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    entidad.INVENTARIO = TicketFlixEntities.INVENTARIOs.Single(x => x.IDInventario == entidad.INVENTARIO.IDInventario);
                    TicketFlixEntities.PRODUCTOes.Add(entidad);
                    TicketFlixEntities.SaveChanges();
                    respuesta = TicketFlixEntities.PRODUCTOes.Single(x => x.IDProducto == entidad.IDProducto);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public PRODUCTO Read(int ID)
        {
            PRODUCTO respuesta = new PRODUCTO();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    respuesta = TicketFlixEntities.PRODUCTOes.Include("INVENTARIO").Single(x => x.IDProducto == ID);
                }
            }
            catch (Exception)
            {
                //MANEJO DE EXCEPCION
                throw;
            }
            return respuesta;
        }

        public bool Delete(PRODUCTO entidad)
        {
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    var deletion = TicketFlixEntities.PRODUCTOes.Include("INVENTARIO").Single(x => x.IDProducto == entidad.IDProducto);
                    TicketFlixEntities.PRODUCTOes.Remove(deletion);
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

        public List<PRODUCTO> GetList()
        {
            List<PRODUCTO> lista = new List<PRODUCTO>();
            try
            {
                using (var TicketFlixEntities = new TicketFlixEntities())
                {
                    lista = TicketFlixEntities.PRODUCTOes.Include("INVENTARIO").ToList<PRODUCTO>();
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
