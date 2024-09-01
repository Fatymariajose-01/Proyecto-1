using Proyecto_1;

class Program
{
    static List<Vehiculo> lugarescarro = new List<Vehiculo>();
    static List<Vehiculo> lugaresmoto = new List<Vehiculo>();
    static List<Vehiculo> lugarescamion = new List<Vehiculo>();
       static int espacioscarro = 20;
       static int espaciosmoto = 20;
       static int espacioscamion = 20;

    static void Main (string[] arg)
    {
    bool seguir = true;
    while (seguir)
    {
     
        mostrarMenu();

        
        Console.Write("Elija una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());   
        
        EjecutarOpcion(opcion);
        
     
    }

    Console.WriteLine("Gracias por usar el programa. ¡Adiós!");
}
int opcion;
static void mostrarMenu()
{
    Console.Clear();
    Console.WriteLine("...MENÚ...");
    Console.WriteLine("1. Registro de Vehículos");
    Console.WriteLine("2. Retiro de Vehículos");
    Console.WriteLine("3. Visualización de vehículos estacionados");
    Console.WriteLine("4. Visualización de espacios disponibles");
    Console.WriteLine("5. Salida del sistema");
}
    static (string, string, string, string, DateTime) ObtenerInformacionVehiculo()
    {
        Console.WriteLine("Ingrese las placas del vehículo: ");
        string placas = Console.ReadLine();
        Console.WriteLine("Ingrese la marca del vehículo: ");
        string marca = Console.ReadLine();
        Console.WriteLine("Ingrese el Modelo: ");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ingrese el Color: ");
        string color = Console.ReadLine();
        DateTime horaDeIngreso = DateTime.Now;

        // Mostrar la hora de ingreso
        Console.WriteLine("Hora de ingreso: " + horaDeIngreso);

        // Devolver los datos
        return (placas, marca, modelo, color, horaDeIngreso);
    }

    static void EjecutarOpcion(int opcion)
{
        Console.WriteLine("¿Qué tipo de vehículo desea registrar?");
        Console.WriteLine("1. Carro");
        Console.WriteLine("2. Motocicleta");
        Console.WriteLine("3. Camión");
        if (opcion == 1)
        {
            
        }


        switch (opcion)
    {
        case 1:
            Console.WriteLine(" Registro de Vehículos");
                Console.WriteLine("Ingrese las placas del vehículo: ");
                string placas = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehículo: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese el Modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese el Color: ");
                string color = Console.ReadLine();
                DateTime horaDeIngreso = DateTime.Now;
                Console.WriteLine("Hora de ingreso: "+horaDeIngreso);
                Console.WriteLine("Ingrese el Tipo");
                Console.WriteLine("1. Carro");
                Console.WriteLine("2. Motocicleta");
                Console.WriteLine("3. Camión");
                int opciontipo = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        ObtenerInformacionVehiculo();
                        if (espacioscarro <= 20)
                        {
                        string tipo = "Carro";
                        lugarescarro.Add(new Vehiculo(placas, marca, modelo, color, tipo, horaDeIngreso));
                            espacioscarro = espacioscarro - 1;
                        Console.WriteLine("Vehículo registrado exitsamente.");
                        }
                        else if (espacioscarro == 0)
                        {
                            Console.WriteLine("Ya no hay espacios disponibles");
                        }


                        Console.ReadKey();
                        break;

                }
                Console.ReadKey();
            
            break;
        case 2:
                Console.WriteLine(" Retiro de Vehículos ");
                Console.WriteLine("¿De qué tipo es el vehículo que desea retirar?");
                Console.WriteLine("1. Carro");
                Console.WriteLine("2. Motocicleta");
                Console.WriteLine("3. Camión");
                Console.WriteLine("Ingrese una opción.");
                int opcionretiro = Convert.ToInt32(Console.ReadLine());
                switch (opcionretiro)
                {
                    case 1:
                Console.WriteLine("Ingrese las placas del auto a retirar");
                string placasbuscar = Console.ReadLine();
                Vehiculo vehiculoeliminar = lugarescarro.Find(p => p.Placa == placasbuscar);
                if(placasbuscar != null)
                {
                    lugarescarro.Remove(vehiculoeliminar);
                    Console.WriteLine("Vehículo retirado");
                }
                else
                {
                        Console.WriteLine("Vehículo no encontrado");
                        Console.WriteLine("Presione Cualquier Tecla Para Regresar al Menú Principal");
                }                
                espacioscarro = espacioscarro + 1;
                Console.ReadKey();
                        break;
                }
                break;
        case 3:
            Console.WriteLine("Visualización de vehículos estacionados ");
                Console.WriteLine("¿Qué lista de vehículos desea visualizar?");
                Console.WriteLine("1. Carro");
                Console.WriteLine("2. Motocicleta");
                Console.WriteLine("3. Camión");
                Console.WriteLine("Ingrese una opción: ");
                int opcionver = Convert.ToInt32(Console.ReadLine());
                switch(opcionver) 
                { 
                    case 1:
                int numeroslistado = 1;
                        if (lugarescarro == null || lugarescarro.Count == 0)
                        {
                            Console.WriteLine("No hay carros en la lista.");
                        }
                        else
                        {
                            foreach (Vehiculo CarroMostrar in lugarescarro)
                            {
                                Console.WriteLine($"CARRO {numeroslistado}:");
                                Console.WriteLine($"Placas: " + CarroMostrar.Placa);
                                Console.WriteLine($"Marca: " + CarroMostrar.Marca);
                                Console.WriteLine($"Modelo: "+ CarroMostrar.Modelo);
                                Console.WriteLine($"Color: "+ CarroMostrar.Color);
                                Console.WriteLine($"Hora de entrada" +CarroMostrar.HoraEntrada);
                                Console.WriteLine($"Tipo de vehículo" + CarroMostrar.Tipo);
                                numeroslistado++;
                                Console.WriteLine("");
                            }
                        }
                        Console.WriteLine("Presione Cualquier Tecla Para Regresar al Menú Principal");
                        Console.ReadKey();
                        break;
                
                }
                Console.ReadKey();
                break;
        case 4:
            Console.WriteLine(" Visualización de espacios disponibles ");
                Console.WriteLine("¿Qué lista de espacios disponibles desea visualizar?");
                Console.WriteLine("1. Carro");
                Console.WriteLine("2. Motocicleta");
                Console.WriteLine("3. Camión");
                Console.WriteLine("Ingrese una opción: ");
                int opcionvisual = Convert.ToInt32(Console.ReadLine());
                switch (opcionvisual)
                {
                    case 1:
                        Console.WriteLine(espacioscarro);
                        break;
                    case 2:
                        Console.WriteLine(espaciosmoto);
                        break;
                    case 3:
                        Console.WriteLine(espaciosmoto);
                        break;
                }
                Console.ReadKey();
                break;
        case 5:
            Console.WriteLine(" Salida del sistema ");
                return;
                Console.ReadKey();
                break;
            default:
            Console.WriteLine(" Opción no válida. Por favor, elija una opción del 1 al 4. ");
            break;
    }
}

}