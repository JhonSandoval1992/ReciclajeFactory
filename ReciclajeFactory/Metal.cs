using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciclajeFactory
{
    public class Metal: IClasificar
    {
     public String Nombre { get; set; }

        public String TipoMaterial { get; set; }

        public Metal(String TipoMaterial)
        {
            this.TipoMaterial = TipoMaterial;
        }

        public void Alamcenar()
        {
            Console.WriteLine("-Esto es Metal/ Almacenar()");
            Console.WriteLine("-Nombre"+this.Nombre);
            Console.WriteLine("-TipoMaterial"+this.TipoMaterial);

        }
    }
}
