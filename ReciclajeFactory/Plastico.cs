using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclajeFactory
{
   public class Plastico : IClasificar
    {
        public String Nombre { get; set; }

        public String TipoMaterial { get; set; }

        public Plastico(String TipoMaterial)
        {
            this.TipoMaterial = TipoMaterial;
        }

        public void Alamcenar()
        {
            Console.WriteLine("-Esto es Metal/ Almacenar()");
            Console.WriteLine("-Nombre" + this.Nombre);
            Console.WriteLine("-Tipo de Material" + this.TipoMaterial);

        }
    }
}
    

