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
        private PedidosDBEntities context = new PedidosDBEntities();

        public int insertarPedido(Local local)
    {
        Pedido pedido = new Pedido();
        pedido.Fecha = DateTime.Now;
        pedido.Descripcion_local = local.Descripcion;
        //Adhiero mi objeto pedido a la base
        context.Pedidos.Add(pedido);
 

        //guardo
        context.SaveChanges();
            return pedido.Id;
    }

        public int insertarCanasto(int IdPedido, Local local, Operario vendedor, String segmento)
        {
            Estado[] estado = context.Estadoes.ToArray();
            //creo mi objeto
            Canasto canasto = new Canasto();
            

            canasto.Id_local = local.Id;
            canasto.Numero_local = local.Numero;
            canasto.Descripcion_local = local.Descripcion;
            canasto.Id_vendedor = vendedor.Id;
            canasto.Legajo_vendedor = vendedor.Legajo;
            canasto.Descripcion_vendedor = vendedor.Descripcion;
            canasto.Estado = estado[0].Descripcion;
            canasto.Fecha = DateTime.Now;
            canasto.Segmento = segmento;
            canasto.Id_pedido = IdPedido;
            


            context.Canastoes.Add(canasto);
            
      
            context.SaveChanges();
            return canasto.Id;
        }
       
        //public void actualizarPedido(int Id, Local local, Operario vendedor, String txtLocal, String txtVenedor,
        //    String chkHombre, String chkMujer, String chkKids)
        //{
        //    //traigo el objeto desde la base de datos
        //    var pedido = context.Pedidos.FirstOrDefault(x => x.Id == Id);
        //    Estados[] estado = context.Estados.ToArray();
        //    pedido.id = local.Id;
        //    pedido.Id_Vendedor = vendedor.Id;
        //    pedido.Numero_Local = Convert.ToInt32(txtLocal);
        //    pedido.Descripcion_Local = local.Descripcion;
        //    pedido.Legajo_Vendedor = Convert.ToInt32(txtVenedor);
        //    pedido.Descripcion_Vendedor = vendedor.Descripcion;
        //    pedido.Estado = estado[0].Estado;
        //    pedido.Fecha_creacion = DateTime.Today;
        //    pedido.Hombre = chkHombre;
        //    pedido.Mujer = chkMujer;
        //    pedido.Kids = chkKids;
        //    context.SaveChanges();
        //}

        public void eliminarPedido(int Id)
        {
            //Borra en la base y guarda los cambios
            Pedido BorrarPedido = (from q in context.Pedidos where q.Id == Id select q).First();
            context.Pedidos.Remove(BorrarPedido);
            context.SaveChanges();
        }

        public void eliminarCanasto(int Id)
        {
            Canasto BorrarCanasto = (from q in context.Canastoes where q.Id == Id select q).First();
            context.Canastoes.Remove(BorrarCanasto);
            context.SaveChanges();
        }

        public void setFacturista(int Id, Operario facturista, Operario asignador, DateTime fechaAsignacion)
        {
            try
            {
                var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
                canastoEditar.Id_facturista = facturista.Id;
                canastoEditar.Legajo_facturista = facturista.Legajo;
                canastoEditar.Descripcion_facturista = facturista.Descripcion;
                canastoEditar.Id_asignador = asignador.Id;
                canastoEditar.Legajo_asignador = asignador.Legajo;
                canastoEditar.Descripcion_asignador = asignador.Descripcion;
                canastoEditar.Fecha_asignacion = fechaAsignacion;
                context.SaveChanges();

            }
            catch (Exception)
            {
                throw new NullReferenceException("Debe seleccionar un pedido y completar los campos! ");

            }

        }

        //public void setComentario(int Id, String comentario) 
        //{
        //    var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
        //    pedidoEditar.Comentario = comentario;
        //    context.SaveChanges();
        //}

        public void actualizarEstado(int Id, String estado)
        {
            var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
            canastoEditar.Estado = estado;
            context.SaveChanges();
        }

        public void actualizarEstadoPorFecha(int Id, String estado)
        {
            var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
            canastoEditar.Estado = estado;
            canastoEditar.Fecha_facturacion = DateTime.Now;
            context.SaveChanges();
        }
        
        public List<Operario> getOperarios()
        {
            return context.Operarios.ToList();
        }

        public List<Estado> getEstados()
        {
           return context.Estadoes.ToList();
        }

        public List<Local> getLocales()
        {
            return context.Locals.ToList();
        }

        public Local getLocal(String descripcion)
        {
            return context.Locals.FirstOrDefault(q => q.Descripcion == descripcion);
        }

        public IPagedList<Pedido> getPedidosPorFecha(DateTime dtpFecha, int paginaActual, int tamañoPagina)
        {
            //manejar excepcion
            IPagedList<Pedido> lista1 = (from q in context.Pedidos
                                          where (q.Fecha == dtpFecha.Date.Date)
                                          orderby
                                              q.Id
                                          select q ).ToPagedList(paginaActual, tamañoPagina);
            return lista1;
        }

        public List<Pedido> getPedidosPorFecha(DateTime fecha)
        {
            var ped = (from q in context.Pedidos.Where(q => q.Fecha == fecha.Date)
                       orderby q.Id
                       select q).ToList();
            return ped;
        }

        public List<Canasto> getCanastosPorIdPedido(int IdPedido)
        {
            var ped = (from q in context.Canastoes.Where(q => q.Id_pedido == IdPedido)
                       orderby q.Id
                       select q).ToList();
            return ped;
        }

        public Canasto getCanastoPorIdPedido(int IdPedido)
        {
    return context.Canastoes.FirstOrDefault(x => x.Id_pedido == IdPedido);
    }

        public List<Canasto> getPedidosPorFacturista(Operario facturista)
        {
            List<Canasto> lista = (from q in context.Canastoes
                                   where (q.Descripcion_facturista == facturista.Descripcion
                                   && q.Estado.Trim() == "Asignado")
                                   orderby q.Id
                                   select q).ToList();
            return lista;
        }

        public List<Pedido> getPedidosPorAsignador(String fecha)
        {
            var ped = (from q in context.Pedidos orderby q.Id where q.Fecha.ToString() == fecha select q).ToList();
            return ped;
        }

        public IQueryable<Pedido> getPedidos()
        {
            IQueryable<Pedido> pedidos = context.Pedidos;
            return pedidos;
        }

        public Pedido getPedido(int Id)
        {
            return context.Pedidos.Find(Id);
        }

        public String getComentario(int Id)
        {
            String comentarioPedido = context.Pedidos.FirstOrDefault(x => x.Id == Id).Comentario;

            return comentarioPedido;
        }

        public void setPrioridad(int Id)
        {
            var pedidoEditar = context.Pedidos.FirstOrDefault(x => x.Id == Id);
            //pedidoEditar.Prioridad_ = "Prioridad";
            context.SaveChanges();
        }

        public Segmento[] getSegmentos()
        {
            return context.Segmentoes.ToArray();
        }
        
    }


}
