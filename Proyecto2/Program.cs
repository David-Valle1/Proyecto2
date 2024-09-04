class program
{
    static void Main(string[] args)
    {
        bool Continuar = true;

        while (Continuar)
        {
            Console.Clear();
            Console.WriteLine("===Ventas varias===");
            Console.WriteLine("1 Transistores");
            Console.WriteLine("2 Capasitores");
            Console.WriteLine("3 Leds");
            Console.WriteLine("4 Salir");
            Console.WriteLine("===============");
            Console.Write("Seleccione una opción: ");
            string option = Console.ReadLine(); 
            
            switch (option)
            {
                case "1":
                    Console.WriteLine("Has seleccionado la opcion uno");
                    break;

                case "2":
                    Console.WriteLine("Has seleccionado la opcion dos");
                    break;

                case "3":
                    Console.WriteLine("Has seleccionado la opcion tres");
                    break;

                case "4":
                    Console.WriteLine("Saliendo del programa.....");
                    Continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no valida intente de nuevo");
                    break;


                if (Continuar)
                {
                    Console.WriteLine("presione cualquier tecla para continuar");
                    Console.ReadKey();
                }

            }

        }

    }
    
}
