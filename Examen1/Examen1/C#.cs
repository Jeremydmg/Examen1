using System;
using System.Collections.Generic;

namespace InventarioReciclaje
{
    class Producto
    {
        public int id;
        public string nombre;
        public string cedula;
        public string nombrePersona;
        public int cantidad;

        public Producto(int id, string nombre, string cedula, string nombrePersona, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
            this.nombrePersona = nombrePersona;
            this.cantidad = cantidad;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"ID: {id}, Nombre: {nombre}, Cedula: {cedula}, Nombre de la Persona: {nombrePersona}, Cantidad: {cantidad}");
        }
    }

    class Program
    {
        static List<Producto> inventario = new List<Producto>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sistema de Inventario de Reciclaje");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Ver Inventario");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarProducto();
                        break;
                    case "2":
                        VerInventario();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void AgregarProducto()
        {
            Console.Write("Nombre del Producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Cedula del Reciclador: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre del Reciclador: ");
            string nombrePersona = Console.ReadLine();

            Console.Write("Cantidad: ");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.Write("Por favor, ingrese un número válido para la cantidad: ");
            }

            Producto producto = new Producto(nextId++, nombre, cedula, nombrePersona, cantidad);
            inventario.Add(producto);
            Console.WriteLine("Producto agregado exitosamente.\n");
        }

        static void VerInventario()
        {
            Console.WriteLine("\nInventario:");
            if (inventario.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.\n");
            }
            else
            {
                foreach (Producto producto in inventario)
                {
                    producto.MostrarProducto();
                }
                Console.WriteLine();
            }
        }
    }
}
