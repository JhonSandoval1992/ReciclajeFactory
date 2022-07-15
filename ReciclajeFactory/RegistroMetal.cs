using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclajeFactory
{
    public class RegistroMetal : Registro
    {
        public RegistroMetal(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IClasificar CreateRegistro(String Nombre)
        {
            Console.WriteLine("--REGISTRO METAL / CreateRegistro()");

            Metal clasificar = new Metal("Acero galvanizado");
            clasificar.Nombre = Nombre;

            return clasificar;
        }
    }
}

