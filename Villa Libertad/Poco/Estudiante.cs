using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa_Libertad.Enums;

namespace Villa_Libertad.Poco
{
    
    public class Estudiante
    {
        public string Nombre { get; set; }
        public Seccion Aula { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
    }
}
