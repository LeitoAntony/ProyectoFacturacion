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
    
    public partial class Canasto
    {
        public int Id { get; set; }
        public Nullable<int> Id_local { get; set; }
        public Nullable<int> Numero_local { get; set; }
        public string Descripcion_local { get; set; }
        public Nullable<int> Id_vendedor { get; set; }
        public Nullable<int> Legajo_vendedor { get; set; }
        public string Descripcion_vendedor { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Segmento { get; set; }
    }
}
