using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyStore.Models
{
    public class User
    {

        static int count = 0;
        public User()
        {
            count++;
            ID = count;
        }

        public User(string UserName, string Password, int permission)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = permission;
        }

        [Key]
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }


        public int Permission { get; set; }  //regular=1 ,admin=2




    }
}