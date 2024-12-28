//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatosWeb.Modelado
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FacturaCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacturaCompra()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Código es obligatorio.")]
        [StringLength(15, ErrorMessage = "El Código no puede exceder los 15 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El campo Descripción es obligatorio.")]
        [StringLength(50, ErrorMessage = "La Descripción no puede exceder los 50 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo MontoCompra es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El MontoCompra debe ser mayor a 0.")]
        public Nullable<decimal> MontoCompra { get; set; }

        [Required(ErrorMessage = "El campo ProveedorId es obligatorio.")]
        public Nullable<int> ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo UsuarioId es obligatorio.")]
        public Nullable<int> UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo FechaFactura es obligatorio.")]
        [DataType(DataType.Date, ErrorMessage = "La FechaFactura debe ser una fecha válida.")]
        public Nullable<System.DateTime> FechaFactura { get; set; }

        [Required(ErrorMessage = "El campo TipoEntradaId es obligatorio.")]
        public Nullable<int> TipoEntradaId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }

        public virtual Proveedor Proveedor { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
