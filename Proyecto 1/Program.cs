class Program
{
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
    Console.WriteLine("...MENÚ...");
    Console.WriteLine("1. Registro de Vehículos");
    Console.WriteLine("2. Retiro de Vehículos");
    Console.WriteLine("3. Visualización de vehículos estacionados");
    Console.WriteLine("4. Visualización de espacios disponibles");
    Console.WriteLine("5. Salida del sistema");
}

 static void EjecutarOpcion(int opcion)
{
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Has seleccionado la Opción 1.");
            
            break;
        case 2:
            Console.WriteLine("Has seleccionado la Opción 2.");
           
            break;
        case 3:
            Console.WriteLine("Has seleccionado la Opción 3.");
          
            break;
        case 4:
           // 
        default:
            Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 4.");
            break;
    }
}

}