﻿using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
namespace PedidosFacturacion
{
    public class Logic
    {
        private PedidosDBEntities context = new PedidosDBEntities();


        public int insertOrder(Local local)
        {
            Pedido order = new Pedido();
            try
            {
                order.Fecha = DateTime.Now;
                order.Descripcion_local = local.Descripcion;
                //Adhiero mi objeto pedido a la base
                context.Pedidos.Add(order);

                //guardo
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new NullReferenceException("Error al insertar una orden; " + e.Message);
            }

            return order.Id;
        }

        public void insertBasket(int IdOrder, Local local, Operario seller, String segment)
        {
            try
            {
                Estado[] state = context.Estadoes.ToArray();
                //creo mi objeto
                Canasto basket = new Canasto();

                basket.Id_local = local.Id;
                basket.Numero_local = local.Numero;
                basket.Descripcion_local = local.Descripcion;
                basket.Id_vendedor = seller.Id;
                basket.Legajo_vendedor = seller.Legajo;
                basket.Descripcion_vendedor = seller.Descripcion;
                basket.Estado = state[0].Descripcion;
                basket.Fecha = DateTime.Now;
                basket.Segmento = segment;
                basket.Id_pedido = IdOrder;

                context.Canastoes.Add(basket);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NullReferenceException("Error al insertar un canasto! " + e.Message);
            }
        }

        public void deleteOrder(int Id)
        {
            try
            {
                //Borra en la base y guarda los cambios
                Pedido orderDelete = (from q in context.Pedidos where q.Id == Id select q).First();
                context.Pedidos.Remove(orderDelete);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NullReferenceException("Error al borrar una orden! " + e.Message);
            }
        }

        public void deleteBasket(int Id)
        {
            Canasto basketDelete = (from q in context.Canastoes where q.Id == Id select q).First();
            context.Canastoes.Remove(basketDelete);
            context.SaveChanges();
        }

        public void setInvoces(int Id, Operario invoice, Operario assignment, DateTime date)
        {
            try
            {
                var BasketEdit = context.Canastoes.FirstOrDefault(x => x.Id == Id);
                BasketEdit.Id_facturista = invoice.Id;
                BasketEdit.Legajo_facturista = invoice.Legajo;
                BasketEdit.Descripcion_facturista = invoice.Descripcion;
                BasketEdit.Id_asignador = assignment.Id;
                BasketEdit.Legajo_asignador = assignment.Legajo;
                BasketEdit.Descripcion_asignador = assignment.Descripcion;
                BasketEdit.Fecha_asignacion = date;
                context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new NullReferenceException("Debe seleccionar un pedido y completar los campos! " + e.Message);
            }
        }

        public void setComentary(int Id, String comentary)
        {
            try
            {
                var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
                canastoEditar.Comentario = comentary;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new NullReferenceException("Ingrese un comentario! ");
            }

        }

        public void updateStates(int Id, String state)
        {
            var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
            canastoEditar.Estado = state;
            context.SaveChanges();
        }

        public void updateStateByDate(int Id, String state)
        {
            var canastoEditar = context.Canastoes.FirstOrDefault(x => x.Id == Id);
            canastoEditar.Estado = state;
            canastoEditar.Fecha_facturacion = DateTime.Now;
            context.SaveChanges();
        }

        public void setPriority(int Id)
        {
            try
            {
                var orderEdit = context.Canastoes.FirstOrDefault(x => x.Id == Id);
                orderEdit.Prioridad = "Prioridad";
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw new ArgumentOutOfRangeException("Seleccione un canasto para marcar! ");
            }

        }

        public Local getLocal(String descripcion)
        {
            return context.Locals.FirstOrDefault(q => q.Descripcion == descripcion);
        }

        public Canasto getBasketByOrder(int IdOrder)
        {
            return context.Canastoes.FirstOrDefault(x => x.Id_pedido == IdOrder);
        }

        public Pedido getOrder(int Id)
        {
            return context.Pedidos.Find(Id);
        }

        public String getComentary(int Id)
        {
            String comentary = context.Canastoes.FirstOrDefault(x => x.Id == Id).Comentario;

            return comentary;
        }

        public Segmento[] getSegments()
        {
            return context.Segmentoes.ToArray();
        }

        public List<Pedido> getOrdersByDate(DateTime date)
        {
            var ped = (from q in context.Pedidos.Where(q => q.Fecha == date.Date)
                       orderby q.Id
                       select q).ToList();
            return ped;
        }

        public List<Canasto> getBasketsByOrder(int IdOrder)
        {
            var ped = (from q in context.Canastoes.Where(q => q.Id_pedido == IdOrder)
                       orderby q.Id
                       select q).ToList();
            return ped;
        }

        public List<Operario> getOperators()
        {
            return context.Operarios.ToList();
        }

        public List<Estado> getStates()
        {
            return context.Estadoes.ToList();
        }

        public List<Local> getLocals()
        {
            return context.Locals.ToList();
        }

        public List<Canasto> getOrderByInvoce(Operario invoce)
        {
            List<Canasto> lista = (from q in context.Canastoes
                                   where (q.Descripcion_facturista == invoce.Descripcion
                                   && q.Estado.Trim() == "Asignado")
                                   orderby q.Id
                                   select q).ToList();
            return lista;
        }

        public List<Pedido> getOrderByAssignment(String date)
        {
            var ped = (from q in context.Pedidos orderby q.Id where q.Fecha.ToString() == date select q).ToList();
            return ped;
        }

        public IPagedList<Canasto> getOrderByPriority(DateTime dtpFecha, int actualPage, int sizePage)
        {
            IPagedList<Canasto> ret = (from p in context.Pedidos
                                       join c in context.Canastoes on p.Id equals c.Id_pedido
                                       where (p.Fecha == dtpFecha.Date)
                                       orderby c.Prioridad descending
                                       select c).ToPagedList(actualPage, sizePage);
            return ret;
        }

        public IPagedList<Canasto> getOrderByLocal(DateTime dtpFecha, int actualPage, int sizePage, Local local)
        {
            IPagedList<Canasto> ret = (from p in context.Pedidos
                                       join c in context.Canastoes on p.Id equals c.Id_pedido
                                       where (p.Fecha == dtpFecha.Date && c.Descripcion_local == local.Descripcion)
                                       orderby c.Descripcion_local
                                       select c).ToPagedList(actualPage, sizePage);
            return ret;
        }

        public IPagedList<Canasto> getOrdersByDate(DateTime date, int actualPage, int sizePage)
        {
            IPagedList<Canasto> lista2 = (from p in context.Pedidos
                                          join c in context.Canastoes on p.Id equals c.Id_pedido
                                          where (p.Fecha == date.Date)
                                          orderby p.Id
                                          select c).ToPagedList(actualPage, sizePage);
            return lista2;
        }


        public bool chackDataLoguin(string pUser, string pPass)
        {
            string user = pUser.Trim();
            string pass = pPass.Trim();
            try
            {
                string passEncoded = Encode(pass);

                var userDB = context.Usuarios.FirstOrDefault(x => x.UserName.Trim() == user);

                if (userDB.UserName == user)
                {
                    var passDB = context.Usuarios.FirstOrDefault(x => x.Password == passEncoded);
                    string pa = passDB.Password.ToString();
                    if (passDB.Password.ToString().Trim() == passEncoded)
                        return true;
                }
            }
            catch (Exception e)
            {
                throw new NullReferenceException("Datos ingresados incorrectos!");
            }
            return false;
        }


        internal string Encode(string pass)
        {
            string password = pass.ToLower();
            string encode = string.Empty;
            string encode2 = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                encode += (char)(password[i] + 10);
            }
            encode = encode + encode;
            for (int i = encode.Length - 1; i > 0; i--)
            {
                encode2 += (char)(encode[i]);
            }
            encode = encode + encode2;
            return encode;
        }

        internal string Decode(string pass)
        {
            string encode = string.Empty;
            string encode2 = string.Empty;
            for (int i = 0; i < pass.Length; i++)
            {
                encode += (char)(pass[i] - 10);
            }
            return encode;
        }

        internal void saveUserDB(string txtUsuario, string encode)
        {
            Usuario user = new Usuario();
            user.UserName = txtUsuario.Trim();
            user.Email = string.Empty;
            user.Password = encode;
            context.Usuarios.Add(user);
            context.SaveChanges();

        }
    }
}
