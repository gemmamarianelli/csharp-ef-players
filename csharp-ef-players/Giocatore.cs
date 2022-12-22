using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table("giocatore")]
    public class Giocatore
    {
        [Key]
        public int GiocatoreId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Column("Giocatore_Score")]
        public int Score { get; set; }
        [Column("Giocatore_Partite_Giocate")]
        public int PartiteGiocate { get; set; }
        [Column("Giocatore_Partite_Vinte")]
        public int PartiteVinte { get; set; }
    }    
}
