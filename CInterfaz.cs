using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBanco
{
    public class CInterfaz
    {

        static CInterfaz() 
        { 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public string MostrarInfo()
        {
            Console.Clear();
            Console.WriteLine("[1] AGREGAR UNA CUENTA");
            Console.WriteLine("[2] CONSULTAR EL SALDO DE UNA CUENTA");
            Console.WriteLine("[3] AGREGAR DINERO A UNA CUENTA");
            Console.WriteLine("[4] SACAR DINERO A UNA CUENTA");
            Console.WriteLine("[5] ELIMINAR  UNA CUENTA");
            Console.WriteLine("[6] MOSTRAR INFO DE LAS CUENTAS ");
            Console.WriteLine("[0] SALIR");

            return PedirDato(" La Opcion Elegida");
        }

        public string PedirDato(string dato)
        {
            Console.WriteLine("INGRESE  {0}",  dato);
            string result =Console.ReadLine();

            while (result == null)
            {
                Console.WriteLine("INGRESE  {0}" + dato);
                 result = Console.ReadLine();
            }

            return result;
        }

        

    }
}
