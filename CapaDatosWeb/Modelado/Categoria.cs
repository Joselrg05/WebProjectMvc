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

    public partial class Categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoria()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Código es obligatorio.")]
        [StringLength(50, ErrorMessage = "El Código no puede exceder los 15 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El campo Descripción es obligatorio.")]
        [StringLength(50, ErrorMessage = "El Descripción no puede exceder los 50 caracteres.")]
        public string Descripcion { get; set; }

        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; } = DateTime.Today;
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
