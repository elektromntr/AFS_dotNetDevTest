using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFS_dotNetDevTest.Models
{
    public class Sentence
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Tekst")]
        [Required(ErrorMessage = "Prosze wprowadzić tekst do przetłumaczenia")]
        public string Text { get; set; }

        [DisplayName("Tekst przetłumaczony")]
        public string Translated { get; set; }
    }
}