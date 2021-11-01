using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimerParcial_JesusSivira
{
    class Pila
    {
        static void Main(string[] args)
        {

            int numeroMaximo;
            int codigo;
            string descripcion;
            float precio;
            int opcion = 0;

            do
            {
                    Console.WriteLine("Ingrese la cantidad de elementos a ingresar");
                    numeroMaximo = int.Parse(Console.ReadLine());
            } while (numeroMaximo < 0);

            Stack<Producto> productos = new Stack<Producto>();

            while (opcion != 5)
            {
                Console.WriteLine("Selecione una opcion en el menu: \n" +
                "\n Opcion 1: Ingresar productos (Push)" +
                "\n Opcion 2: Eliminar producto de la pila (Pop)" +
                "\n Opcion 3: Mostrar el top de la pila (Peek)" +
                "\n Opcion 4: Buscar por codigo un producto " +
                "\n Opcion 5: Salir"
                );

                opcion = int.Parse(Console.ReadLine());


                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        if (productos.Count() < numeroMaximo)
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el codigo del producto");
                                codigo = int.Parse(Console.ReadLine());
                            } while (codigo.GetType() != Type.GetType("System.Int32"));


                            Console.WriteLine("Ingrese la descripcion del producto");
                            descripcion = Console.ReadLine();

                            do
                            {
                                Console.WriteLine("Ingrese el precio del producto");
                                precio = int.Parse(Console.ReadLine());
                            } while (precio < 0);

                            productos.Push(new Producto(codigo, descripcion, precio));

                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("La pila esta llena...");
                        }

                        break;
                    case 2:
                        if (productos.Count() == 0)
                        {
                            Console.WriteLine("La pila de productos esta vacia...");
                            break;
                        }
                        else
                        {
                            productos.Pop();
                            Console.WriteLine("Se ha eliminado el elemento de la pila");
                        }
                        break;
                    case 3:
                        if (productos.Count() > 0)
                        {
                            Console.WriteLine("Elemento en el top de la pila: \n {0}", productos.Peek());
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("La pila de productos esta vacia...");
                        }
                        break;
                    case 4:
                        if (productos.Count() > 0)
                        {
                            Console.WriteLine("Ingrese un codigo a buscar en la pila: ");
                            int buscar = int.Parse(Console.ReadLine());

                            foreach (Producto p in productos)
                            {
                                if (buscar == p.GetCodigo())
                                {
                                    Console.WriteLine("Se encontro el siguiente articulo  \n {0}", p);
                                }
                                else
                                {
                                    Console.WriteLine("Elemento no encontrado");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("La pila de productos esta vacia...");
                        }
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida.");
                        break;
                }
            }

            


        }

    }

}
