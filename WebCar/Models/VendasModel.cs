using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WebCar.Models
{
    public class VendasModel
    {
        public int Id { get; set; }

        public string NomeCarro { get; set; }
        
        public string Km { get; set; }
       
        public string AnoCarro { get; set; }
       
        public string Localizacao { get; set; }
       
        public string ValorVenda { get; set; }

      



    }

}