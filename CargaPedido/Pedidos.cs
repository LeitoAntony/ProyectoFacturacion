//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosFacturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedidos
    {
        public int Id { get; set; }
        public int Id_Local { get; set; }
        public int Id_Vendedor { get; set; }
        public int Numero_Local { get; set; }
        public string Descripcion_Local { get; set; }
        public int Legajo_Vendedor { get; set; }
        public string Descripcion_Vendedor { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_creacion { get; set; }
        public Nullable<System.DateTime> Fecha_Asignacion { get; set; }
        public Nullable<System.DateTime> Fecha_Facturacion { get; set; }
        public string Hombre { get; set; }
        public string Mujer { get; set; }
        public string Kids { get; set; }
        public Nullable<int> Id_Asignador { get; set; }
        public Nullable<int> Legajo_Asignador { get; set; }
        public string Descripcion_Asignador { get; set; }
        public Nullable<int> Id_Facturista { get; set; }
        public Nullable<int> Legajo_Facturista { get; set; }
        public string Descripcion_Facturista { get; set; }
        public string Comentario { get; set; }
        public string Prioridad_ { get; set; }
    }
}
