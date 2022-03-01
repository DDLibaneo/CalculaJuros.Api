using System;
using System.Collections.Generic;
using System.Text;

namespace CalculaJuros.Models
{
    public class JuroDto
    {
        public int Id { get; set; }
        
        public decimal Taxa { get; set; }
        
        public DateTime CreationDate { get; set; }
    }
}
