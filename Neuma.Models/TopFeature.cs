using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuma.Models
{
    public class TopFeature
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title {  get; set; }

        [Required]
        public string Description { get; set; }

        public string Image {  get; set; }


    }
}
