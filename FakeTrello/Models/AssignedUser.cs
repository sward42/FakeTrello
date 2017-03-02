using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeTrello.Models
{
    public class AssignedUser  //??
    {
        [Key]
        public int AssignedUserId { get; set; }

        public List<TrelloUser> TrelloUsers { get; set; }  //??

        public int CardId { get; set; }
    }
}