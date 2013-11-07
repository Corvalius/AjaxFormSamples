using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AjaxFormSample.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
