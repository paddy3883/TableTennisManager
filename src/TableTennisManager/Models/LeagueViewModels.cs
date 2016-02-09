using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableTennisManager.Models
{
    public class PlayerViewModel
    {
        public System.Guid Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Position { get; set; }
    }
}