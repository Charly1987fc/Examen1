using Examen1Progra2App.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int op = 0;
            clsClientes cli = new clsClientes();
            
            while (op != 6)
            {
                Console.WriteLine("Bienvenido a Autosoluciones");
                Console.WriteLine("Favor elija una opcion");
                Console.WriteLine("1.Gestion de clientes");  //Esta opcion escogi "Gestion de clientes"
                Console.WriteLine("2.Gestion de vehiculos");
                Console.WriteLine("3.Gestion de servicios");
                Console.WriteLine("4.Gestion de citas");
                Console.WriteLine("5.Gestion de mecanicos");
                Console.WriteLine("6.Salir");
               
                op = int.Parse(Console.ReadLine());
                switch (op) 
                {
                    case 1:
                        
                            cli.cli();
                        
                        
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
