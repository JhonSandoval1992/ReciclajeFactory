using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclajeFactory
{
    public class RegistroPlastico : Registro
    {
        public RegistroPlastico(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IClasificar CreateRegistro(String Nombre)
        {
            Console.WriteLine("--REGISTRO PLASTICO / CreateRegistro()");

            Plastico clasificar = new Plastico("Pet");
            clasificar.Nombre = Nombre;

            return clasificar;
        }
    }
}
