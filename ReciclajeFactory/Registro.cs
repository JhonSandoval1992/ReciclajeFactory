using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclajeFactory
{
 public abstract class Registro
    {
        public String Nombre { get; set; }

        public Registro(String Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SomeOperation()
        {
            Console.WriteLine("Aqui se ejecuta SomeOperation()");
            IClasificar clasificar = CreateRegistro(Nombre);
            clasificar.Almacenar();
        }
        public abstract IClasificar CreateRegistro(String Nombre);
    }
}
