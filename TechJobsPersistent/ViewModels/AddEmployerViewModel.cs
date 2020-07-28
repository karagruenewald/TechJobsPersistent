using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage="This is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="This is required.")]
        public string Location { get; set; }


        public AddEmployerViewModel()
        {
        }
    }
}
