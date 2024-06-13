using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2App.Properties
{
    internal class clsClientes
    {
        public void cli()
        {
            List<Cliente> clientes = new List<Cliente>();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el nombre del cliente:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el telefono del cliente:");
                int telefono = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el correo del cliente:");
                string correo = Console.ReadLine();

                Console.WriteLine("Ingrese la direccion del cliente:");
                string direccion = Console.ReadLine();

                Cliente nuevoCliente = new Cliente(nombre, correo, direccion, telefono);
                clientes.Add(nuevoCliente);

                Console.WriteLine("¿Desea agregar otro cliente? (si/no)");
                string respuesta = Console.ReadLine();
                continuar = respuesta.ToLower() == "si";
            }

            Console.WriteLine("Lista de clientes inscritos:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre}, Telefono: {cliente.Telefono}, Correo: {cliente.Correo}, Direccion: {cliente.Direccion}");
            }
        }

        

        class Cliente
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public int Telefono { get; set; }
            public string Direccion { get; set; }

            public Cliente(string nombre, string correo, string direccion, int telefono)
            {
                Nombre = nombre;
                Telefono = telefono;
                Correo= correo;
                Direccion=direccion;
            }
        }
    }
}

