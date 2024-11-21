using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCar.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        

        public string LastName { get; set; }
        

        public string Email { get; set; }
        

        public int Celular { get; set; }
        

        public string Password { get; set; }
        

        public string Gender { get; set; }
       
         
    }
}
