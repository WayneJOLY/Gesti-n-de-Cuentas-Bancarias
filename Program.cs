namespace MiniBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //--------------------------
            string nombre, numeroCuenta;
            int  opcion;
            float dinero;
            List<CCuenta> listaDeCuentas= new List<CCuenta>(); Random rand= new Random();
            /***************************/
            CInterfaz interfaz = new CInterfaz();
            /***************************/
            //--------------------------

            do
            {
                opcion = int.Parse(interfaz.MostrarInfo());

                switch (opcion)
                {
                    case 1:
                        //Console.WriteLine("Ingrese El Nombre");
                        nombre = GenerarNombreAleatorio(); //Console.ReadLine();
                                                           // Console.WriteLine("Ingrese El Numero de cuenta");
                        numeroCuenta = rand.Next(1000, 9999).ToString();//Console.ReadLine();
                        //Console.WriteLine("Ingrese El Saldo de la Cuenta");
                        dinero = rand.Next(0, 15999); //float.Parse(Console.ReadLine());
                        CCuenta nuevacuenta=new CCuenta(nombre,numeroCuenta,dinero);
                        if (BuscarCuenta(numeroCuenta)== null)
                        {
                            listaDeCuentas.Add(nuevacuenta);
                            Console.WriteLine("Cuenta agregado con exito !");
                        }
                        break;
                    case 2:

                        Console.WriteLine("Ingrese El Numero de cuenta A BUSCAR");
                        numeroCuenta = Console.ReadLine();
                       CCuenta cuenta= BuscarCuenta(numeroCuenta);

                        if (cuenta != null)
                        {
                            Console.WriteLine(cuenta.ToString());
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese El Numero de cuenta Agregar Dinero");
                        numeroCuenta = Console.ReadLine();
                        cuenta = BuscarCuenta(numeroCuenta);


                        if (cuenta != null)
                        {
                            Console.WriteLine("Ingrese El Monto A agregar a la Cuenta");
                            dinero = float.Parse( Console.ReadLine());
                            cuenta.Depositar(dinero);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese El Numero de cuenta Sacar Dinero");
                        numeroCuenta = Console.ReadLine();
                        cuenta = BuscarCuenta(numeroCuenta);


                        if (cuenta != null)
                        {
                            Console.WriteLine("Ingrese El Monto Sacar de la Cuenta");
                            dinero = float.Parse(Console.ReadLine());
                            cuenta.SacarDinero(dinero);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Ingrese El Numero de cuenta Sacar Dinero");
                        numeroCuenta = Console.ReadLine();
                        cuenta = BuscarCuenta(numeroCuenta);

                        if (cuenta != null)
                        {
                            listaDeCuentas.Remove(cuenta);
                        }
                        break;

                    case 6:
                        Console.Clear();
                        foreach(CCuenta cuent in listaDeCuentas)
                        {
                            Console.WriteLine(cuent.ToString());
                        }
                        Console.ReadLine();
                        break;
                }


            }while (opcion != 0);



             CCuenta BuscarCuenta(string numeroDeCuenta)
            {
                foreach (CCuenta cuenta in listaDeCuentas)
                {
                    if(cuenta.getNumeroDeCuenta()==numeroDeCuenta)
                    {
                        return cuenta;
                    }
                }
                return null;
             }

            static string GenerarNombreAleatorio()
            {
                string[] apellidos = { "García", "Martínez", "López", "González", "Rodríguez", "Fernández", "Pérez", "Gómez", "Sánchez", "Díaz", "Sofía", "Mateo", "Lucía", "Alejandro", "Valentina", "Sebastián", "Isabella", "Emiliano", "Martina", "Joaquín", "Camila", "Santiago", "Valeria", "Nicolás", "Julieta" };
                Random rnd = new Random();
                return apellidos[rnd.Next(apellidos.Length)];
            }
        }
        
        
    }
}
