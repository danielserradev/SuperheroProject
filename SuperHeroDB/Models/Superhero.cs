using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroDB.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string primarySuperheroAbility { get; set; }
        public string secondarySuperheroAbility { get; set; }
        public string catchphrase { get; set; }


    }
}