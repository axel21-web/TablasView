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
            if (Estudiantes == null)
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

        public Estudiante[] GetAll() {
            return Estudiantes;
        }

        public void Remove(int index)
        {
            if (index < 0)
            {
                return;
            }
            if (Estudiantes == null)
            {
                return;
            }
            if (index >= Estudiantes.Length)
            {
                throw new IndexOutOfRangeException($"El index {index} esta fuera del rango");
            }
            if (index == 0 && Estudiantes.Length == 1)
            {
                Estudiantes = null;
                return;
            }

            Estudiante[] tmp = new Estudiante[Estudiantes.Length - 1];
            if (index == 0)
            {
                Array.Copy(Estudiantes, index + 1, tmp, 0, tmp.Length);
                Estudiantes = tmp;
                return;
            }
            if (index == Estudiantes.Length - 1)
            {
                Array.Copy(Estudiantes, 0, tmp, 0, tmp.Length);
                Estudiantes = tmp;
                return;
            }

            Array.Copy(Estudiantes, 0, tmp, 0, index);
            Array.Copy(Estudiantes, index + 1, tmp, index, (tmp.Length - index - 1));
        }
    }
}
