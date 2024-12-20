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

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.FacturaVenta = new HashSet<FacturaVenta>();
        }

        [Key]    
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio.")]
        [StringLength(10, ErrorMessage = "El código del cliente no puede tener más de 10 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre del cliente no puede tener más de 50 caracteres.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El primer apellido del cliente es obligatorio.")]
        [StringLength(50, ErrorMessage = "El primer apellido del cliente no puede tener más de 50 caracteres.")]
        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        [EmailAddress(ErrorMessage = "Correo electrónico inválido.")]
        public string Correo { get; set; }

        [Phone(ErrorMessage = "Número de teléfono inválido.")]
        public string Telefono { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; } = DateTime.Now;
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaVenta> FacturaVenta { get; set; }
    }
}
