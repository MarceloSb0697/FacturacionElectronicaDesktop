//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacturacionElectronicaDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_DocumentoElectronico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_DocumentoElectronico()
        {
            this.FacturacionElectronica = new HashSet<FacturacionElectronica>();
        }
    
        public string codigo_documentoElectronico { get; set; }
        public string descripcion_documento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturacionElectronica> FacturacionElectronica { get; set; }
    }
}
