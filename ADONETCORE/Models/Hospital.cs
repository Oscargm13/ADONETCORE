using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETCORE.Models
{
    internal class Hospital
    {
        public int IdHospital { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }
        public int NumCama { get; set; }
    }
}
