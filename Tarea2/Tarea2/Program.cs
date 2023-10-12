using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.");
                Console.WriteLine("1-Ejercicio 1 ");
                Console.WriteLine("2-Ejercicio 2 ");
                Console.WriteLine("3-Ejercicio 3 ");
                Console.WriteLine("4-Salir");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {

                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4:
                        Console.WriteLine("Gracias");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion es incorrecta");
                        Console.ReadLine();
                        break;

                }

            } while (opcion != 4);



        }
        static void Ejercicio1()
        {
            // de 2 a 5 camisas descuento del 15 
            // mas de 5 camisas DESCUENTO DEL 20 
            // solicitar cantidad de camiasa y el precio 
            // se multiplica primero y despues de resta 

           
            Console.WriteLine("Digite la cantidad de camisas a comprar");
            int Camisas = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite el precio de las camisas");
            float Precio1 = float.Parse(Console.ReadLine());

            float Precio = Precio1 * Camisas;



            if (Camisas > 2 && Camisas <= 5)
            {

                double Rebajo = Precio * 0.15;
                double Descuento = Precio - Rebajo;

                Console.WriteLine("___________DESGLOSE DE LA COMPRA___________");
                Console.WriteLine("El precio original de las camisas es de: " + Precio);
                Console.WriteLine($"El monto final a pagar es de {Descuento} , con un descuento del 15% en la compra");
                Console.WriteLine($"El rebajo en su compra es de:" + Rebajo);
                Console.WriteLine("______________________________________________________________________________________");
                Console.ReadLine();

            }
            else if (Camisas > 5)
            {
                double Rebajo = Precio * 0.20;
                double Descuento = Precio - Rebajo;


                Console.WriteLine("___________DESGLOSE DE LA COMPRA___________");
                Console.WriteLine("El precio original de las camisas es de: " + Precio);
                Console.WriteLine($"El monto final a pagar es de {Descuento} , con un descuento del 15% en la compra");
                Console.WriteLine($"El rebajo en su compra es de: " + Rebajo);
                Console.WriteLine("______________________________________________________________________________________");
                Console.ReadLine();



            }
            Console.ReadLine();

        }
        static void Ejercicio2()
        {
            //ingresar carnet, mobre quiz1,2,3 , tarea 1,2,3, examen1,2,3
            // Sumar los tres quices multiplicarlo por 25% y lo divido entre 100
            // Sumar las tres tareas multiplicarlo por 30% y lo divido entre 100
            // Sumar los tres examnes multiplicarlo por 45% y lo divido entre 100
            // mayor a 70 aprobado , igual a 50 o menor que 70 aplazado , menor que 50 reporbado 

            Console.WriteLine("Ingrese el numero de su carnet estudiantil");
            long carnet = long.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del primer quiz ");
            float quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo quiiz");
            float quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer quiz");
            float quiz3 = float.Parse(Console.ReadLine());


            float quicesS = quiz1 + quiz2 + quiz3;

            float quicesM = (float)(quicesS / 3 * 0.25f);



            Console.WriteLine("Ingrese la nota de la primera tarea");
            float tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la segunda tarea");
            float tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tercera tarea");
            float tarea3 = float.Parse(Console.ReadLine());


            float tareaS = tarea1 + tarea2 + tarea3;

            float tareaM = (float)(tareaS / 3 * 0.30f);


             
            Console.WriteLine("Ingrese la nota del primer examen");
            float examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo examen");
            float examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer examen");
            float examen3 = float.Parse(Console.ReadLine());


            float examenS = examen1 + examen2 + examen3;

            float examenM = (float)(examenS /3 * 0.45f);



            float Nota = quicesM + tareaM + examenM;



            // mayor a 70 aprobado , igual a 50 o menor que 70 aplazado , menor que 50 reporbado 
            //reporte del carnet, porcentaje de quices , tareas, examenes , promedio final , condicion 
            if (Nota > 70)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es APROBADO");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();

            }
            else if (Nota < 70 && Nota > 50)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es APLAZADO");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();






            }
            else if (Nota < 50)
            {
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine("El numero del carnet es:" + carnet);
                Console.WriteLine("El nombre del estudiante es:" + nombre);
                Console.WriteLine("El porcentaje de los quices del curso es de:" + quicesM);
                Console.WriteLine("El porcentaje de las tareas del curso es de:" + tareaM);
                Console.WriteLine("El porcentaje de los examnes del curso es de:" + examenM);
                Console.WriteLine("El pormedio final es de:" + Nota);
                Console.WriteLine($"La condicion del estudiante {nombre},de numero de carnet {carnet}, es REPROBADO ");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.DESGOLSE FINAL DEL PROMEDIO.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-..-.-.-.");
                Console.ReadLine();

            }

        }

        static void Ejercicio3()
        {
            // 10 productos o menos el precio es de 20 
            // mas de 10 el precio es de 15 
            //multiplicar la cantidad de productos por el precio 
            //Ingresar la cantidad de articulos y dar como resultado el precio el total 

            Console.WriteLine("Digite la cantidad de articulos a comprar");
            int articulos = int.Parse(Console.ReadLine());


            if (articulos <= 10)
            {
                float precio = articulos * 20;
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.WriteLine($"Por la compra de {articulos} articulos el precio es de 20$ por producto");
                Console.WriteLine($"El total a pagar es de {precio} $ ");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.ReadLine();





            }
            else if (articulos > 10)
            {
                float precio = articulos * 15;
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.WriteLine($"Por la compra de {articulos} articulos el precio es de 15$ por producto");
                Console.WriteLine($"El total a pagar es de {precio} $");
                Console.WriteLine(".-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.DESGLOSE.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.ReadLine();



            }
            Console.ReadLine();


        }
    
    }
}
