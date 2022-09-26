using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bazar_prg.Models
{

    [Table("t_cliente")]
    public class Cliente
    {
            
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name {get;set;}

        [Column("surname")]
        public string? Surname {get;set;}

        [Column("email")]
        public string? Email {get; set; } 
        
    }
}
