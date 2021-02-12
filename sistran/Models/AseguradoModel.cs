using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistran.Models
{
    public class AseguradoModel
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public DateTime fecha_nacimiento { set; get; }
        public string edad { set; get; }
        public int estado_civil { set; get; }
    }
}
