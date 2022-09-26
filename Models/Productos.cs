using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace bazar_prg.Models
{

     [Table("t_producto")]
    public class Productos
    {
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Marca { get; set; }

        public string? Descripcion { get; set; }

        public Decimal Precio { get; set; }

        public string? ImageName { get; set; }

        public string? Status { get; set; }
    }
}