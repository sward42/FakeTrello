using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set;}

        [MaxLength(60)]
        public string Title { get; set; }

        [MaxLength(60)]
        public string Contents { get; set; }

        // Auxillary: given a card instance, return the list it belongs to.
        public List ListParent { get; set; }

        public List<TrelloUser> AllUsers { get; set; }
    }
}