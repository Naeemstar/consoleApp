using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coremvc4_apps.Models
{
    public class employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is must")]
        [StringLength(10,MinimumLength =4,ErrorMessage ="the name must be greater than 4 and smllaer than 10")]
        public string Name{ get; set; }
        [Required(ErrorMessage ="Email is must")]
         [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]
           {1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)
             |(([a-zA-Z0-9\-]+\.)+))
           ([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "Please enter a valid e-mail adress")]
        public string email { get; set; }
        [Required(ErrorMessage ="password field must required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Compare("password")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }

    }
}
