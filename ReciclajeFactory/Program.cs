using System;
using System.Collections.Generic;

namespace ReciclajeFactory
{
    public class program
    {
        static void Main(String [] args)
        {
            List<Registro> lista = new List<Registro>();
            lista.Add(new RegistroPlastico("Botellas Gaseosa"));
            lista.Add(new RegistroPlastico("Botellas De Condimentos"));
            lista.Add(new RegistroPlastico("Plastico Invernaderos"));
            lista.Add(new RegistroMetal("Hierro Construccion"));
            lista.Add(new RegistroMetal("Cobre"));
            lista.Add(new RegistroMetal("Aluminio"));

             foreach(Registro registro in lista)
            {
                registro.SomeOperation();
            }
        }
    }
}
