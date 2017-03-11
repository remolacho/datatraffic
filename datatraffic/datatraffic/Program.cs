using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datatraffic.family;
using datatraffic.tree;

namespace prueba_datatraffic
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Ingrese 1 si desea ver la funvcion Fibonacci:");
          Console.WriteLine("Ingrese 2 si desea ver las clases:");
          Console.WriteLine("Ingrese 3 si desea ver los nodos:");

          int selected = int.Parse(Console.ReadLine());
          
          switch (selected)
          {
              case 1:
                  fibonacci();
                  break;
              case 2:
                  actions();
                  break;
			  default:
				  readTree ();
                  break;
          }
		  
		  Console.ReadKey();

        }

        static void fibonacci()
        {
            int a, b, n, i, aux;
            Console.WriteLine("¿Cuantos números fibonacci?");
            n = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < n; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                Console.WriteLine(a);
            }
        }
         
        static void actions() {

            Console.WriteLine("Ingrese el miembro de familia Hijo = h, Padre = p , Madre = m");
            string member = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre:");
            string n = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido:");
            string ln = Console.ReadLine();
       

            Console.WriteLine("Seleccione la accion a ejecutar:");
            Console.WriteLine("1 dormir");
            Console.WriteLine("2 despertar");
            Console.WriteLine("3 desayunar");
            Console.WriteLine("4 almorzar");
            Console.WriteLine("5 cenar");
			Console.WriteLine("Ingrse el numero");
			int action = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la hora ejm 9:00 PM/AM");
            string hour = Console.ReadLine();

            switch (member) {
                case "p":
                    Father father = new Father(n, ln);
				    Console.WriteLine("Es el padre de la casa:");
                    Console.WriteLine("Nombre: " + father.name);
                    Console.WriteLine("Apellido: " + father.last_name);
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine(father.sleep(hour));
                            break;
                        case 2:
                            Console.WriteLine(father.wake(hour));
                            break;
                        case 3:
                            Console.WriteLine(father.have_breakfast(hour));
                            break;
                        case 4:
                            Console.WriteLine(father.to_have_lunch(hour));
                            break;
                        case 5:
                            Console.WriteLine(father.dine(hour));
                            break;
                        default:
                            Console.WriteLine("No hay lectura");
                            break;
                    }
                    Console.WriteLine("¿En que trabaja?");
                    Console.WriteLine(father.work());
                    break;
                case "m":
                    Mother mother = new Mother(n, ln);
			     	Console.WriteLine("Es la Madre de la casa:");
                    Console.WriteLine("Nombre: " + mother.name);
                    Console.WriteLine("Apellido: " + mother.last_name);
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine(mother.sleep(hour));
                            break;
                        case 2:
                            Console.WriteLine(mother.wake(hour));
                            break;
                        case 3:
                            Console.WriteLine(mother.have_breakfast(hour));
                            break;
                        case 4:
                            Console.WriteLine(mother.to_have_lunch(hour));
                            break;
                        case 5:
                            Console.WriteLine(mother.dine(hour));
                            break;
                        default:
                            Console.WriteLine("No hay lectura");
                            break;
                    }
                    Console.WriteLine("¿En que trabaja?");
                    Console.WriteLine(mother.work());
                    break;
                default:
                    Child child = new Child(n, ln);
			    	Console.WriteLine("Es un hijo de la familia:");
                    Console.WriteLine("Nombre: " + child.name);
                    Console.WriteLine("Apellido: " + child.last_name);
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine(child.sleep(hour));
                            break;
                        case 2:
                            Console.WriteLine(child.wake(hour));
                            break;
                        case 3:
                            Console.WriteLine(child.have_breakfast(hour));
                            break;
                        case 4:
                            Console.WriteLine(child.to_have_lunch(hour));
                            break;
                        case 5:
                            Console.WriteLine(child.dine(hour));
                            break;
                        default:
                            Console.WriteLine("No hay lectura");
                            break;
                    }
                    Console.WriteLine("¿En que trabaja?");
                    Console.WriteLine(child.work());
                    break;
            }
        }

		static void readTree(){
			BinaryTree tree = new BinaryTree ();
			tree.Add ("H");
			tree.Add ("I");
			tree.Add ("J");
			tree.Add ("K");
			tree.Add ("L");
			Console.WriteLine ("Impresion preorden: ");
			tree.PrintPre ();
			Console.WriteLine ("Impresion entreorden: ");
			tree.PrintIn ();
			Console.WriteLine ("Impresion postorden: ");
			tree.PrintPost ();
			Console.WriteLine("Cantidad de nodos hoja: "+tree.CountNodeSheet());
			Console.Write ("Artura del arbol: " + tree.Height());
			Console.ReadKey();
		}
    }
}
