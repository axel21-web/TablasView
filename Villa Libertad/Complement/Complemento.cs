using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa_Libertad.Poco;

namespace Villa_Libertad.Complement
{  
    public class Complemento
    {
        private Estudiante[] Estudiantes;

        public Complemento() { }

        public void Add(Estudiante vpn)
        {
            if(Estudiantes == null)
            {
                Estudiantes = new Estudiante[1];
                Estudiantes[0] = vpn;
                return;

            }
            Estudiante[] temp = new Estudiante[Estudiantes.Length + 1];
            Array.Copy(Estudiantes, temp, Estudiantes.Length);
            temp[temp.Length - 1] = vpn;

            Estudiantes = temp;
        }
    }
}
