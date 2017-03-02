using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//Entity is our Object Relational Mapper (ORM)

namespace FakeTrello.Models
{
    public class TrelloUser
    {
        [Key]
        public int TrelloUserId { get; set; } // Primary key

        //Stacking of properties applies multiple annotations to the following property
        [MinLength(10)]
        [MaxLength(60)]
        public string Email { get; set; }

        [MinLength(10)]
        [MaxLength(60)]
        public string Username { get; set; }

        [MinLength(10)]
        [MaxLength(60)]
        public string FullName { get; set; }

        public ApplicationUser BaseUser { get; set; }  // Creates 1 to 1 relationship

        public List<Board> Boards { get; set; }  // Creates 1 to many (boards) relationships
    }
}