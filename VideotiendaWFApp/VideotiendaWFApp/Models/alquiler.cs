//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideotiendaWFApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class alquiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alquiler()
        {
            this.alq_videojuegos = new HashSet<alq_videojuegos>();
        }
    
        public decimal id_alquiler { get; set; }
        public System.DateTime fec_alquiler { get; set; }
        public System.DateTime fec_devolucion { get; set; }
        public decimal vlr_alquiler { get; set; }
        public Nullable<decimal> vlr_multas { get; set; }
        public Nullable<decimal> nro_doc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alq_videojuegos> alq_videojuegos { get; set; }
        public virtual personas personas { get; set; }
    }
}
