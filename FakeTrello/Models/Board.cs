using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(60)]
        public string URL { get; set; }

        public TrelloUser Owner { get; set; } //Can access the TrelloUser for this board with this reference

        public List<List> Lists{ get; set; }
    }
}