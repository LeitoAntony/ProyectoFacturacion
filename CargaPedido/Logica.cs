using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using PagedList;
namespace PedidosFacturacion
{
    public class Logica 
    {
        private CargaPedidoDBEntities context = new CargaPedidoDBEntities();

        public int insertarPedido(Local local, Operario vendedor, String txtLocal, String txtVenedor,
            String chkHombre, String chkMujer, String chkKids)
    {
            Estados[] estado = context.Estados.ToArray();
            //creo mi objeto
            Pedidos pedido = new Pedidos();
            
            // completo mi objeto pedido con los datos de objetos seleccionados
            pedido.Id_Local = local.Id;
            pedido.Id_Vendedor = vendedor.Id;
            pedido.Numero_Local = Convert.ToInt32(txtLocal);
            pedido.Descripcion_Local = local.Descripcion;
            pedido.Legajo_Vendedor = Convert.ToInt32(txtVenedor);
            pedido.Descripcion_Vendedor = vendedor.Descripcion;
            pedido.Estado = estado[0].Estado;
            pedido.Fecha_creacion = DateTime.Today;
            pedido.Hombre = chkHombre;
            pedido.Mujer = chkMujer;
            pedido.Kids = chkKids;

            //Adhiero mi objeto pedido a la base
            context.Pedidos.Add(pedido);
            
            //guardo
            context.SaveChanges();
            return pedido.Id;
    }
        public void actualizarPedido(int Id, Local local, Operario vendedor, String txtLocal, String txtVenedor,
            String chkHombre, String chkMujer, String chkKids)
        {
            //traigo el objeto desde la base de datos
            var pedido = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            Estados[] estado = context.Estados.ToArray();
            pedido.Id_Local = local.Id;
            pedido.Id_Vendedor = vendedor.Id;
            pedido.Numero_Local = Convert.ToInt32(txtLocal);
            pedido.Descripcion_Local = local.Descripcion;
            pedido.Legajo_Vendedor = Convert.ToInt32(txtVenedor);
            pedido.Descripcion_Vendedor = vendedor.Descripcion;
            pedido.Estado = estado[0].Estado;
            pedido.Fecha_creacion = DateTime.Today;
            pedido.Hombre = chkHombre;
            pedido.Mujer = chkMujer;
            pedido.Kids = chkKids;
            context.SaveChanges();
        }


        public void eliminarPedido(int Id)
        {
            //Borra en la base y guarda los cambios
            Pedidos BorrarPedido = (from q in context.Pedidos where q.Id == Id select q).First();
            context.Pedidos.Remove(BorrarPedido);
            context.SaveChanges();
        }

        public void actualizarPedido(int Id)
        {
            Pedidos actualizarPedido = context.Pedidos.Find(Id);

        }

        public List<Operario> getOperarios()
        {
            return context.Operario.ToList();
        }

        public List<Estados> getEstados()
        {
           return context.Estados.ToList();
        }

        public List<Local> getLocales()
        {
            return context.Local.ToList();
        }
        
        public IPagedList<Pedidos> getPedidosPorFecha(DateTime dtpFecha, int paginaActual, int tamañoPagina)
        {

            //maneja excepcion
            IPagedList<Pedidos> lista1 = ( from q in context.Pedidos where (q.Fecha_creacion == dtpFecha.Date) orderby 
                                               q.Id select q).ToPagedList(paginaActual, tamañoPagina);
            return lista1;
        }

        public List<Pedidos> listaPedidosPorFacturista(Operario facturista)
        {
            List<Pedidos> lista = (from q in context.Pedidos
                                          where (q.Descripcion_Facturista == facturista.Descripcion)
                                          //&& q.Estado.Trim() == "Asignado")// && q.Estado.Trim() == "Prioridad")
                                          orderby
                                              q.Id
                                          select q).ToList();
            return lista;
        }

        public List<Pedidos> pedidosAsignador(String fecha)
        { 
            var ped = (from q in context.Pedidos orderby q.Id where q.Fecha_creacion.ToString() == fecha select q).ToList();
            return ped;
        }

        public List<Pedidos> getPedidosFecha(DateTime fecha)
        {
            var ped = (from q in context.Pedidos.Where(q => q.Fecha_creacion == fecha.Date) 
                       orderby q.Id select q).ToList();
            return ped;
        }

        public IQueryable<Pedidos> getPedidos()
        {
            IQueryable<Pedidos> pedidos = context.Pedidos;
            return pedidos;
        }

        public void cambiarEstado(int Id, String estado)
        {
            var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            pedidoEditar.Estado = estado;
            context.SaveChanges();
        }

        public void cambiarEstadoFecha(int Id, String estado)
        {
            var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            pedidoEditar.Estado = estado;
            pedidoEditar.Fecha_Facturacion = DateTime.Today.Date;
            context.SaveChanges();
        }

        public void setPrioridad(int Id)
        {
            var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            pedidoEditar.Prioridad_ = "Prioridad";
            context.SaveChanges();
        }

        public String getComentario(int Id)
        {
            String comentarioPedido = context.Pedidos.FirstOrDefault(x => x.Id == Id).Comentario;

            return comentarioPedido;
        }


        public void asignarFacturista(int Id, Operario facturista, Operario asignador, DateTime fechaAsignacion)
        {
            try
            {
                var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            pedidoEditar.Id_Facturista = facturista.Id;
            pedidoEditar.Legajo_Facturista = facturista.Legajo;
            pedidoEditar.Descripcion_Facturista = facturista.Descripcion;
            pedidoEditar.Id_Asignador = asignador.Id;
            pedidoEditar.Legajo_Asignador = asignador.Legajo;
            pedidoEditar.Descripcion_Asignador = asignador.Descripcion;
            pedidoEditar.Fecha_Asignacion = fechaAsignacion;
            context.SaveChanges();

            }
            catch (Exception)
            {
                throw new NullReferenceException("Debe seleccionar un pedido y completar los campos! ");
               
            }
            
        }

        public void comentar(int Id, String comentario) 
        {
            var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            pedidoEditar.Comentario = comentario;
            context.SaveChanges();
        }
    }


}
