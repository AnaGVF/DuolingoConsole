using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Proyecto Final - Basic English
 * Ana Graciela Vassallo Fedotkin
 * Introducción a la Programación
 * Ingeniería de Software
 * Grupo 70
 * 5 de Diciembre de 2018
 */

namespace BasicEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

                //Mensaje de Bienvenida
                Console.ForegroundColor = ConsoleColor.Cyan; // Cambia las primeras 2 líneas de asteriscos a un color Cyan
                Console.WriteLine("\n\n\n\t\t\t\t\t****************************");
                Console.WriteLine("\t\t\t\t\t****************************");
                Console.ResetColor(); // Resetea los colores de texto a su valor default
                Console.WriteLine("\n\t\t\t\t\t¡BIENVENID@ A BASIC ENGLISH!");
                Console.ForegroundColor = ConsoleColor.DarkRed; // Cambia las primeras 2 líneas de asteriscos a un color Rojo Oscuro
                Console.WriteLine("\n\n\t\t\t\t\t****************************");
                Console.WriteLine("\t\t\t\t\t****************************");
                Console.ResetColor();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("\t\t\t\t\tPresione ENTER para comenzar...");
                Console.ReadLine();
                Console.Clear();

            do {

                //Menú Principal del Programa
                Console.Clear();
                Console.WriteLine("\n\t          MAIN MENU");
                Console.WriteLine("\n");
                Console.WriteLine("Escribe el número de la opción que desees hacer: ");
                Console.WriteLine('\n');
                Console.WriteLine("1. Theory Section - Sección de Teoría.");
                Console.WriteLine("2. Exercises Section - Sección de Ejercicios.");
                Console.WriteLine("3. Score Section - Sección de Puntajes.");
                Console.WriteLine("4. Exit - Salida.");

                Console.WriteLine("\n");
                opcion = int.Parse(Console.ReadLine()); // Se le la opción a la cual el usuario desea acceder
                Console.WriteLine("\n");

                switch (opcion)
                {
                    case 1: // SECCIÓN DE TEORÍA 
                        { 

                            int opcion1 = 0;

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tWelcome to the Theory Section! - ¡Bienvenido a la sección de Teoría!");
                                Console.WriteLine("\n");
                                Console.WriteLine("Escribe el número de la opción que desees hacer: ");
                                Console.WriteLine("\n");
                                Console.WriteLine("1. Basics.");
                                Console.WriteLine("2. Present Tense.");
                                Console.WriteLine("3. Past Tense.");
                                Console.WriteLine("4. Future Tense.");
                                Console.WriteLine("5. Exit - Salida.");

                                Console.WriteLine("\n");
                                opcion1 = int.Parse(Console.ReadLine()); // Se le la opción a la cual el usuario desea acceder
                                Console.WriteLine("\n");

                                switch (opcion1)
                                {
                                    case 1: // SECCIÓN BASICS
                                        {
                                            int opcion2 = 0;

                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n\t          BASICS");
                                                Console.WriteLine("\n");
                                                Console.WriteLine("Escribe el número del tema que desees revisar: ");
                                                Console.WriteLine("\n");
                                                Console.WriteLine("1. Frases Básicas.");
                                                Console.WriteLine("2. Colores.");
                                                Console.WriteLine("3. Números.");
                                                Console.WriteLine("4. Exit - Salida.");

                                                Console.WriteLine("\n");
                                                opcion2 = int.Parse(Console.ReadLine()); // Se le la opción a la cual el usuario desea acceder
                                                Console.WriteLine("\n");

                                                switch(opcion2)
                                                {
                                                    case 1: // Primer Caso para la Sección de FRASES BÁSICAS
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("\n\tPresiona Enter para ver las frases básicas del idioma inglés junto con su traducción...");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Good morning --------- Buenos días");
                                                            Console.ReadKey(); // Sirve para que el usuario pueda esperarse cuánto tiempo desee antes de presionar una tecla y ver la siguiente frase
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Good afternoon --------- Buenas tardes");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Hello --------- Hola");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Good night --------- Buenas noches");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Goodbye --------- Adiós");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           See you later --------- Hasta luego");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Please --------- Por favor");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Thank you --------- Gracias");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           You are welcome --------- De nada");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Excuse me --------- Disculpe");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           It doesn't matter --------- No importa");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           How are you? --------- ¿Cómo estás?");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Fine, thank you --------- Bien, gracias");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           What's your name? --------- ¿Cómo te llamas?");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           My name is ____ --------- Me llamo ____");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Nice to meet you --------- Gusto en conocerte");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           I'm sorry --------- Perdón");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Help! --------- ¡Ayuda!");
                                                            Console.ReadKey();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t                           Where is the toilet? --------- ¿Dónde está el baño?");
                                                            Console.ReadKey();

                                                            break;
                                                        }
                                                    case 2: // Segundo Caso para la Sección de COLORES
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Presiona Enter para ver los colores en el idioma inglés...");
                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            Console.BackgroundColor = ConsoleColor.White; // Se configurarán los colores y el fondo de la consola para mostrar el color BLANCO
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             WHITE");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Black; // Se configurarán los colores y el fondo de la consola para mostrar el color NEGRO
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             BLACK");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Red; // Se configurarán los colores y el fondo de la consola para mostrar el color ROJO
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             RED");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Gray; // Se configurarán los colores y el fondo de la consola para mostrar el color GRIS
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             GRAY");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Green; // Se configurarán los colores y el fondo de la consola para mostrar el color VERDE
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             GREEN");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Blue; // Se configurarán los colores y el fondo de la consola para mostrar el color AZUL
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t                             BLUE");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.Magenta; // Se configurarán los colores y el fondo de la consola para mostrar el color PÚRPURA
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t\t                               PURPLE");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            Console.BackgroundColor = ConsoleColor.DarkYellow; // Se configurarán los colores y el fondo de la consola para mostrar el color AMARILLO
                                                            Console.ForegroundColor = ConsoleColor.Black;
                                                            Console.Clear();
                                                            Console.WriteLine("\n\n\n\n\n\n\t\t\t                               YELLOW");
                                                            Console.ReadKey();
                                                            Console.ResetColor(); // Se restauran los colores a sus valores predeterminados

                                                            break;
                                                        }
                                                    
                                                    case 3: // Tercer Caso para la Sección de NÚMEROS
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Presiona Enter para ver los números en el idioma inglés...");
                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            Console.WriteLine("\n\n\n\n\n\n                           ONE\n\n"); // Número UNO
                                                            Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                            Console.WriteLine();
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           TWO\n\n"); // Número DOS
                                                            for (int i = 0; i < 2; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                          THREE\n\n"); // Número TRES
                                                            for (int i = 0; i < 3; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                         FOUR\n\n"); // Número CUATRO
                                                            for (int i = 0; i < 4; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           FIVE\n\n"); // Número CINCO
                                                            for (int i = 0; i < 5; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           SIX\n\n"); // Número SEIS
                                                            for (int i = 0; i < 6; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           SEVEN\n\n"); // Número SIETE
                                                            for (int i = 0; i < 7; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           EIGHT\n\n"); // Número OCHO
                                                            for (int i = 0; i < 8; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           NINE\n\n"); // Número NUEVE
                                                            for (int i = 0; i < 9; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            Console.WriteLine("\n\n                           TEN\n\n"); // Número DIEZ
                                                            for (int i = 0; i < 10; i++)
                                                            {
                                                                Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                Console.WriteLine();
                                                            }
                                                            Console.WriteLine("________________________________________________");
                                                            Console.WriteLine();
                                                            Console.ReadKey();

                                                            break;
                                                        }
                                                    case 4: // Cuarto Caso para Salir de la Sección BASICS
                                                        {
                                                            Console.Clear();
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            Console.WriteLine("This option is not valid - Esta opción no es válida.");
                                                            break;
                                                        }
                                                }

                                            } while (opcion2 != 4);

                                            break;
                                        }
                                    case 2: // SECCIÓN PRESENT TENSE
                                        {
                                            Console.Clear();
                                            StreamReader lectura = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Present_Tense_Teoria.txt"); // Se abre el archivo
                                            string contenido = lectura.ReadToEnd(); // Se lee todo el archivo con el contenido de la sección
                                            Console.WriteLine(contenido); // Se escribe en la consola el contenido del archivo
                                            lectura.Close(); // Se cierra el archivo
                                            Console.SetCursorPosition(0, 0); // Se posiciona el cursor hasta el principio de la consola para un manejo más fácil de la información
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3: // SECCIÓN PAST TENSE
                                        {
                                            Console.Clear();
                                            StreamReader lectura = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Past_Tense_Teoria.txt"); // Se abre el archivo
                                            string contenido = lectura.ReadToEnd(); // Se lee todo el archivo con el contenido de la sección
                                            Console.WriteLine(contenido); // Se escribe en la consola el contenido del archivo
                                            lectura.Close(); // Se cierra el archivo
                                            Console.SetCursorPosition(0, 0); // Se posiciona el cursor hasta el principio de la consola para un manejo más fácil de la información
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4: // SECCIÓN FUTURE TENSE
                                        {
                                            Console.Clear();
                                            StreamReader lectura = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Future_Tense_Teoria.txt"); // Se abre el archivo
                                            string contenido = lectura.ReadToEnd(); // Se lee todo el archivo con el contenido de la sección
                                            Console.WriteLine(contenido); // Se escribe en la consola el contenido del archivo
                                            lectura.Close(); // Se cierra el archivo
                                            Console.SetCursorPosition(0, 0); // Se posiciona el cursor hasta el principio de la consola para un manejo más fácil de la información
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5: // SECCIÓN EXIT
                                        {
                                            Console.Clear();
                                            Salir();
                                            break;
                                        }
                                    default: // CASO DEFAULT
                                        {
                                            Console.WriteLine("This option is not valid - Esta opción no es válida.");
                                            break;
                                        }
                                }

                            } while (opcion1 != 5);

                            break;
                        }

                    case 2: // SECCIÓN DE EJERCICIOS
                        { 

                            int opcion1 = 0;

                            do
                            {
                                Console.Clear();
                                Console.WriteLine("\n\tWelcome to the Exercises Section! - ¡Bienvenido a la sección de Ejercicios!");
                                Console.WriteLine("\n");
                                Console.WriteLine("Escribe el número de la opción que desees hacer: ");
                                Console.WriteLine("\n");
                                Console.WriteLine("1. Basics.");
                                Console.WriteLine("2. Present Tense.");
                                Console.WriteLine("3. Past Tense.");
                                Console.WriteLine("4. Future Tense.");
                                Console.WriteLine("5. Exit - Salida.");

                                Console.WriteLine("\n");
                                opcion1 = int.Parse(Console.ReadLine()); // Se le la opción a la cual el usuario desea acceder
                                Console.WriteLine("\n");

                                switch (opcion1)
                                {
                                    case 1: // Caso 1 para acceder a los ejercicios de BASICS
                                        {
                                            Console.Clear();

                                            int opcion4 = 0;

                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n\t          BASICS");
                                                Console.WriteLine("\n");
                                                Console.WriteLine("Escribe el número del tema que desees practicar: ");
                                                Console.WriteLine("\n");
                                                Console.WriteLine("1. Frases Básicas.");
                                                Console.WriteLine("2. Colores.");
                                                Console.WriteLine("3. Números.");
                                                Console.WriteLine("4. Exit - Salida.");

                                                Console.WriteLine("\n");
                                                opcion4 = int.Parse(Console.ReadLine()); // Se le la opción a la cual el usuario desea acceder
                                                Console.WriteLine("\n");

                                                switch(opcion4)
                                                {
                                                    case 1: // Primer Caso para los Ejercicios de FRASES BÁSICAS
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Escribir en inglés las siguientes frases básicas (tienes 3 intentos): ");
                                                            Console.WriteLine("\n");
                                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            int contadorPuntaje = 0; // Contará el puntaje de los aciertos durante el ejercicio

                                                            // FRASE 'HELLO'

                                                            string hola;
                                                            int contadorIntentos = 0;
                                                            do
                                                            { 
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Hola");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                hola = Console.ReadLine();
                                                                if (hola.ToLower() == "hello")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos = 3;
                                                                }
                                                                if(hola.ToLower() != "hello")
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((hola.ToLower() != "hello") && contadorIntentos != 3);

                                                            // FIN DE FRASE 'HELLO'

                                                            // FRASE 'GOOD MORNING'
                                                            String gm;
                                                            int contadorIntentos2 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Buenos días");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                gm = Console.ReadLine();
                                                                if (gm.ToLower() == "good morning")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos2 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos2++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((gm.ToLower() != "good morning") && contadorIntentos2 != 3);

                                                            // FIN DE FRASE 'GOOD MORNING'

                                                            // FRASE 'GOOD AFTERNOON'
                                                            String ga;
                                                            int contadorIntentos3 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Buenas tardes");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                ga = Console.ReadLine();
                                                                if (ga.ToLower() == "good afternoon")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos3 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos3++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((ga.ToLower() != "good afternoon") && contadorIntentos3 != 3);

                                                            // FIN DE FRASE 'GOOD AFTERNOON'

                                                            // FRASE 'GOOD NIGHT'
                                                            String gn;
                                                            int contadorIntentos4 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Buenas noches");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                gn = Console.ReadLine();
                                                                if (gn.ToLower() == "good night")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos4 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos4++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((gn.ToLower() != "good night") && contadorIntentos4 != 3);

                                                            // FIN DE FRASE 'GOOD NIGHT'

                                                            // FRASE 'GOODBYE'
                                                            String gb;
                                                            int contadorIntentos5 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Adiós");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                gb = Console.ReadLine();
                                                                if (gb.ToLower() == "goodbye")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos5 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos5++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((gb.ToLower() != "goodbye") && contadorIntentos5 != 3);

                                                            // FIN DE FRASE 'GOODBYE'

                                                            // FRASE 'SEE YOU LATER'
                                                            String syl;
                                                            int contadorIntentos6 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Hasta luego");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                syl = Console.ReadLine();
                                                                if (syl.ToLower() == "see you later")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos6 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos6++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((syl.ToLower() != "see you later") && contadorIntentos6 != 3);

                                                            // FIN DE FRASE 'SEE YOU LATER'

                                                            // FRASE 'PLEASE'
                                                            String please;
                                                            int contadorIntentos7 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Por favor");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                please = Console.ReadLine();
                                                                if (please.ToLower() == "please")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos7 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos7++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((please.ToLower() != "please") && contadorIntentos7 != 3);

                                                            // FIN DE FRASE 'PLEASE'

                                                            // FRASE 'THANK YOU'
                                                            String ty;
                                                            int contadorIntentos8 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Gracias");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                ty = Console.ReadLine();
                                                                if (ty.ToLower() == "thank you")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos8 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos8++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((ty.ToLower() != "thank you") && contadorIntentos8 != 3);

                                                            // FIN DE FRASE 'THANK YOU'

                                                            // FRASE 'YOU ARE WELCOME'
                                                            String yaw;
                                                            int contadorIntentos9 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           De nada");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                yaw = Console.ReadLine();
                                                                if (yaw.ToLower() == "you are welcome")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos9 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos9++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((yaw.ToLower() != "you are welcome") && contadorIntentos9 != 3);

                                                            // FIN DE FRASE 'YOU ARE WELCOME'

                                                            // FRASE 'EXCUSE ME'
                                                            String em;
                                                            int contadorIntentos10 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Disculpe");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                em = Console.ReadLine();
                                                                if (em.ToLower() == "excuse me")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos10 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos10++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((em.ToLower() != "excuse me") && contadorIntentos10 != 3);

                                                            // FIN DE FRASE 'EXCUSE ME'

                                                            // FRASE 'HOW ARE YOU?'
                                                            String hru;
                                                            int contadorIntentos11 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           ¿Cómo estás?");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                hru = Console.ReadLine();
                                                                if (hru.ToLower() == "how are you?")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos11 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos11++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((hru.ToLower() != "how are you?") && contadorIntentos11 != 3);

                                                            // FIN DE FRASE 'HOW ARE YOU?'

                                                            // FRASE 'FINE, THANK YOU'
                                                            String fty;
                                                            int contadorIntentos12 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Bien, gracias");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                fty = Console.ReadLine();
                                                                if (fty.ToLower() == "fine, thank you")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos12 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos12++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((fty.ToLower() != "fine, thank you") && contadorIntentos12 != 3);

                                                            // FIN DE FRASE 'FINE, THANK YOU'

                                                            // FRASE 'WHAT'S YOUR NAME?'
                                                            String wyn;
                                                            int contadorIntentos13 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           ¿Cómo te llamas?");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                wyn = Console.ReadLine();
                                                                if (wyn.ToLower() == "what's your name?")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos13 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos13++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((wyn.ToLower() != "what's your name?") && contadorIntentos13 != 3);

                                                            // FIN DE FRASE 'WHAT'S YOUR NAME?'

                                                            // FRASE 'MY NAME IS'
                                                            String mni;
                                                            int contadorIntentos14 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Me llamo");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                mni = Console.ReadLine();
                                                                if (mni.ToLower() == "my name is")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos14 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos14++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((mni.ToLower() != "my name is") && contadorIntentos14 != 3);

                                                            // FIN DE FRASE 'MY NAME IS'

                                                            // FRASE 'NICE TO MEET YOU'
                                                            String ntmy;
                                                            int contadorIntentos15 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Gusto en conocerte");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                ntmy = Console.ReadLine();
                                                                if (ntmy.ToLower() == "nice to meet you")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos15 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos15++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((ntmy.ToLower() != "nice to meet you") && contadorIntentos15 != 3);

                                                            // FIN DE FRASE 'NICE TO MEET YOU'

                                                            // FRASE 'I'M SORRY'
                                                            String sorry;
                                                            int contadorIntentos16 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           Perdón");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                sorry = Console.ReadLine();
                                                                if (sorry.ToLower() == "i'm sorry")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos16 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos16++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((sorry.ToLower() != "i'm sorry") && contadorIntentos16 != 3);

                                                            // FIN DE FRASE 'I'M SORRY'

                                                            // FRASE 'HELP!'
                                                            String help;
                                                            int contadorIntentos17 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           ¡Ayuda!");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                help = Console.ReadLine();
                                                                if (help.ToLower() == "help!")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos17 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos17++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((help.ToLower() != "help!") && contadorIntentos17 != 3);

                                                            // FIN DE FRASE 'HELP!'

                                                            // FRASE 'WHERE IS THE TOILET?'
                                                            String witt;
                                                            int contadorIntentos18 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           ¿Dónde está el baño?");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                witt = Console.ReadLine();
                                                                if (witt.ToLower() == "where is the toilet?")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos18 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos18++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((witt.ToLower() != "where is the toilet?") && contadorIntentos18 != 3);

                                                            // FIN DE FRASE 'WHERE IS THE TOILET?'

                                                            // FRASE 'IT DOESN'T MATTER'
                                                            String idm;
                                                            int contadorIntentos19 = 0;
                                                            do
                                                            {
                                                                Console.WriteLine("\n\n\n\n\n\n\t\t                           No importa");
                                                                Console.WriteLine("\n\n");

                                                                Console.SetCursorPosition(43, 10);
                                                                idm = Console.ReadLine();
                                                                if (idm.ToLower() == "it doesn't matter")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntaje++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos19 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos19++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((idm.ToLower() != "it doesn't matter") && contadorIntentos19 != 3);

                                                            // FIN DE FRASE 'IT DOESN'T MATTER'

                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntaje + "/19."); // Muestra el puntaje al final del ejercicio

                                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Frases_Basicas.txt");
                                                            puntaje.WriteLine("El puntaje del ejercicio de Frases Básicas fue de: " + contadorPuntaje + "/19");
                                                            puntaje.Close();

                                                            Console.ReadKey();                                                            
                                                            Console.Clear();

                                                            break;
                                                        }
                                                    case 2: // Segundo Caso para los Ejercicios de COLORES
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Escribir en inglés el color de la pantalla que se presenta (tienes 3 intentos): ");
                                                            Console.WriteLine("\n");
                                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            int contadorPuntajeColores = 0; // Contará el puntaje de los aciertos durante el ejercicio
                                                            
                                                            // COLOR RED
                                                            String rojo;
                                                            int contadorIntentosColores = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Red; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                rojo = Console.ReadLine();

                                                                if (rojo.ToLower() == "red")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((rojo.ToLower() != "red") && contadorIntentosColores != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR RED

                                                            // COLOR GREEN
                                                            String green;
                                                            int contadorIntentosColores2 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Green; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                green = Console.ReadLine();

                                                                if (green.ToLower() == "green")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores2 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores2++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((green.ToLower() != "red") && contadorIntentosColores2 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR GREEN

                                                            // COLOR BLUE
                                                            String blue;
                                                            int contadorIntentosColores3 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Blue; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                blue = Console.ReadLine();

                                                                if (blue.ToLower() == "blue")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores3 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores3++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((blue.ToLower() != "blue") && contadorIntentosColores3 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR BLUE

                                                            // COLOR PURPLE
                                                            String purple;
                                                            int contadorIntentosColores4 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Magenta; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                purple = Console.ReadLine();

                                                                if (purple.ToLower() == "purple")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores4 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores4++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((purple.ToLower() != "purple") && contadorIntentosColores4 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR PURPLE

                                                            // COLOR YELLOW
                                                            String yellow;
                                                            int contadorIntentosColores5 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Yellow; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                yellow = Console.ReadLine();

                                                                if (yellow.ToLower() == "yellow")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores5 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores5++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((yellow.ToLower() != "yellow") && contadorIntentosColores5 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR YELLOW

                                                            // COLOR BLACK
                                                            String black;
                                                            int contadorIntentosColores6 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Black; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                black = Console.ReadLine();

                                                                if (black.ToLower() == "black")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores6 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores6++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((black.ToLower() != "black") && contadorIntentosColores6 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR BLACK

                                                            // COLOR WHITE
                                                            String white;
                                                            int contadorIntentosColores7 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.White; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                white = Console.ReadLine();

                                                                if (white.ToLower() == "white")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores7 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores7++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((white.ToLower() != "white") && contadorIntentosColores7 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR WHITE

                                                            // COLOR GRAY
                                                            String gray;
                                                            int contadorIntentosColores8 = 0;
                                                            do
                                                            {
                                                                Console.BackgroundColor = ConsoleColor.Gray; // Prepara la consola para el ejercicio
                                                                Console.ForegroundColor = ConsoleColor.Black;
                                                                Console.Clear();
                                                                Console.SetCursorPosition(50, 10);
                                                                gray = Console.ReadLine();

                                                                if (gray.ToLower() == "gray")
                                                                {
                                                                    Console.ResetColor();
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajeColores++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentosColores8 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Console.ResetColor();
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentosColores8++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((gray.ToLower() != "gray") && contadorIntentosColores8 != 3);

                                                            Console.ResetColor();

                                                            // FIN COLOR GRAY

                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntajeColores + "/8."); // Muestra el puntaje al final del ejercicio

                                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Colores.txt");
                                                            puntaje.WriteLine("El puntaje del ejercicio de Colores fue de: " + contadorPuntajeColores + "/8");
                                                            puntaje.Close();

                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            break;
                                                        }
                                                    case 3: // Tercer Caso para los Ejercicios de NÚMEROS
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Escribir en inglés cuántos cuadrados ves en pantalla (tienes 3 intentos): ");
                                                            Console.WriteLine("\n");
                                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            int contadorPuntajesNumeros = 0; // Contará el puntaje de los aciertos durante el ejercicio
                                                             
                                                            // Ejercicio Número DOS
                                                            string dos;
                                                            int contadorIntentos = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 2; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();                                                                

                                                                dos = Console.ReadLine();
                                                                if (dos.ToLower() == "two")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((dos.ToLower() != "two") && contadorIntentos != 3);
                                                            // Fin Ejercicio Número DOS

                                                            // Ejercicio Número CUATRO
                                                            string cuatro;
                                                            int contadorIntentos2 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 4; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                cuatro = Console.ReadLine();
                                                                if (cuatro.ToLower() == "four")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos2 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos2++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((cuatro.ToLower() != "four") && contadorIntentos2 != 3);
                                                            // Fin Ejercicio Número CUATRO

                                                            // Ejercicio Número UNO
                                                            string uno;
                                                            int contadorIntentos3 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 1; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                uno = Console.ReadLine();
                                                                if (uno.ToLower() == "one")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos3 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos3++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((uno.ToLower() != "one") && contadorIntentos3 != 3);
                                                            // Fin Ejercicio Número UNO

                                                            // Ejercicio Número CINCO
                                                            string cinco;
                                                            int contadorIntentos4 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 5; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                cinco = Console.ReadLine();
                                                                if (cinco.ToLower() == "five")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos4 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos4++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((cinco.ToLower() != "five") && contadorIntentos4 != 3);
                                                            // Fin Ejercicio Número CINCO

                                                            // Ejercicio Número NUEVE
                                                            string nueve;
                                                            int contadorIntentos5 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 9; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                nueve = Console.ReadLine();
                                                                if (nueve.ToLower() == "nine")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos5 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos5++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((nueve.ToLower() != "nine") && contadorIntentos5 != 3);
                                                            // Fin Ejercicio Número NUEVE

                                                            // Ejercicio Número SEIS
                                                            string seis;
                                                            int contadorIntentos6 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 6; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                seis = Console.ReadLine();
                                                                if (seis.ToLower() == "six")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos6 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos6++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((seis.ToLower() != "six") && contadorIntentos6 != 3);
                                                            // Fin Ejercicio Número SEIS

                                                            // Ejercicio Número OCHO
                                                            string ocho;
                                                            int contadorIntentos7 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 8; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                ocho = Console.ReadLine();
                                                                if (ocho.ToLower() == "eight")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos7 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos7++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((ocho.ToLower() != "eight") && contadorIntentos7 != 3);
                                                            // Fin Ejercicio Número OCHO

                                                            // Ejercicio Número TRES
                                                            string tres;
                                                            int contadorIntentos8 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 3; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                tres = Console.ReadLine();
                                                                if (tres.ToLower() == "three")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos8 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos8++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((tres.ToLower() != "three") && contadorIntentos8 != 3);
                                                            // Fin Ejercicio Número TRES

                                                            // Ejercicio Número SIETE
                                                            string siete;
                                                            int contadorIntentos9 = 0;
                                                            do
                                                            {
                                                                for (int i = 0; i < 7; i++)
                                                                {
                                                                    Cuadrado(); // Función para llamar los cuadrados (Se encuentra al final del código)
                                                                    Console.WriteLine();
                                                                }
                                                                Console.WriteLine("________________________________________________");
                                                                Console.WriteLine();

                                                                siete = Console.ReadLine();
                                                                if (siete.ToLower() == "seven")
                                                                {
                                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                                    contadorPuntajesNumeros++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                    contadorIntentos9 = 3;
                                                                }
                                                                else
                                                                {
                                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                                    Console.WriteLine("\n");
                                                                    contadorIntentos9++;
                                                                    Console.ReadKey();
                                                                    Console.Clear();
                                                                }
                                                            } while ((siete.ToLower() != "seven") && contadorIntentos9 != 3);
                                                            // Fin Ejercicio Número SIETE

                                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntajesNumeros + "/9."); // Muestra el puntaje al final del ejercicio

                                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Numeros.txt");
                                                            puntaje.WriteLine("El puntaje del ejercicio de Números fue de: " + contadorPuntajesNumeros + "/9");
                                                            puntaje.Close();

                                                            Console.ReadKey();
                                                            Console.Clear();

                                                            break;
                                                        }
                                                    case 4: // Cuarto Caso para salir de esta sección
                                                        {
                                                            Console.Clear();
                                                            break;                                                           
                                                        }
                                                    default: // Caso default
                                                        {
                                                            Console.WriteLine("This option is not valid - Esta opción no es válida.");
                                                            break;
                                                        }
                                                }
                                            } while (opcion4 != 4);

                                            break;
                                        }
                                    case 2: // Caso 2 para acceder a los ejercicios de PRESENT TENSE
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Escribir en inglés la palabra que complete la oración correctamente (tienes 3 intentos): ");
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            int contadorPuntajesPresent = 0; // Contará el puntaje de los aciertos durante el ejercicio
                                            
                                            // ORACIÓN UNO
                                            String travel;
                                            int contadorIntentos = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       I (travel) _____ to London every week.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                travel = Console.ReadLine();
                                                if (travel.ToLower() == "travel") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tI travel to London every week.");
                                                    Console.WriteLine("\t\t\t\t\tYo viajo a Londres cada semana.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((travel.ToLower() != "travel") && contadorIntentos != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN UNO

                                            // ORACIÓN DOS
                                            String run;
                                            int contadorIntentos2 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       They (run) ____ in the park every Saturday.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                run = Console.ReadLine();
                                                if (run.ToLower() == "run") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThey run in the park every Saturday.");
                                                    Console.WriteLine("\t\t\t\t\tEllos corren en el parque todos los sábados.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos2 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos2++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((run.ToLower() != "run") && contadorIntentos2 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN DOS

                                            // ORACIÓN TRES
                                            String clean;
                                            int contadorIntentos3 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       My mother (clean) _____ the house.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                clean = Console.ReadLine();
                                                if (clean.ToLower() == "cleans") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tMy mother cleans the house.");
                                                    Console.WriteLine("\t\t\t\t\tMi madre limpia la casa.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos3 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos3++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((clean.ToLower() != "cleans") && contadorIntentos3 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN TRES

                                            // ORACIÓN CUATRO
                                            String are;
                                            int contadorIntentos4 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       You (be) ____ a good student.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                are = Console.ReadLine();
                                                if (are.ToLower() == "are") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tYou are a good student.");
                                                    Console.WriteLine("\t\t\t\t\tTú eres un buen estudiante.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos4 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos4++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((are.ToLower() != "are") && contadorIntentos4 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CUATRO

                                            // ORACIÓN CINCO
                                            String work;
                                            int contadorIntentos5 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       Mary (work) _____ in a bank.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                work = Console.ReadLine();
                                                if (work.ToLower() == "works") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tMary works in a bank.");
                                                    Console.WriteLine("\t\t\t\t\tMary trabaja en un banco.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos5 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos5++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((work.ToLower() != "works") && contadorIntentos5 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CINCO

                                            // ORACIÓN SEIS
                                            String walks;
                                            int contadorIntentos6 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       John (walk) _____ to his office.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                walks = Console.ReadLine();
                                                if (walks.ToLower() == "walks") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tJohn walks to his office.");
                                                    Console.WriteLine("\t\t\t\t\tJohn camina a su oficina.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos6 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos6++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((walks.ToLower() != "walks") && contadorIntentos6 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN SEIS

                                            // ORACIÓN SIETE
                                            String study;
                                            int contadorIntentos7 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       You (study) _____ English at school.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                study = Console.ReadLine();
                                                if (study.ToLower() == "study") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tYou study English at school.");
                                                    Console.WriteLine("\t\t\t\t\tTú estudias inglés en la escuela.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos7 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos7++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((study.ToLower() != "study") && contadorIntentos7 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN SIETE

                                            // ORACIÓN OCHO
                                            String breaks;
                                            int contadorIntentos8 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       The dog (break) _____ the fence.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                breaks = Console.ReadLine();
                                                if (breaks.ToLower() == "breaks") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThe dog breaks the fence.");
                                                    Console.WriteLine("\t\t\t\t\tEl perro rompe la cerca.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos8 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos8++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((breaks.ToLower() != "breaks") && contadorIntentos8 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN OCHO

                                            // ORACIÓN NUEVE
                                            String car;
                                            int contadorIntentos9 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       The car (be) ____ in the garage.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                car = Console.ReadLine();
                                                if (car.ToLower() == "is") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThe car is in the garage.");
                                                    Console.WriteLine("\t\t\t\t\tEl coche está en el garage.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos9 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos9++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((car.ToLower() != "is") && contadorIntentos9 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN NUEVE

                                            // ORACIÓN DIEZ
                                            String has;
                                            int contadorIntentos10 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       My father (have) _____ a nice coat.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                has = Console.ReadLine();
                                                if (has.ToLower() == "has") //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                                  // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPresent++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tMy father has a nice coat.");
                                                    Console.WriteLine("\t\t\t\t\tMi padre tiene un lindo saco.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos10 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos10++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((has.ToLower() != "has") && contadorIntentos10 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                                               // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN DIEZ

                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntajesPresent + "/10."); // Muestra el puntaje al final del ejercicio

                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Present_Tense.txt");
                                            puntaje.WriteLine("El puntaje del ejercicio de Present Tense fue de: " + contadorPuntajesPresent + "/10");
                                            puntaje.Close();

                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        }
                                    case 3: // Caso 3 para acceder a los ejercicios de PAST TENSE
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Escribir el número de la palabra correcta en inglés de las siguientes oraciones en pasado simple (tienes 3 intentos): ");
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            int contadorPuntajesPast = 0; // Contará el puntaje de los aciertos durante el ejercicio

                                            // ORACIÓN UNO
                                            int was;
                                            int contadorIntentos = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       She _____ a doctor.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. was"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. is");
                                                Console.WriteLine("\t\t                       3. no");
                                                Console.WriteLine("\t\t                       4. want");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                was = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (was == 1) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                                            // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tShe was a doctor.");
                                                    Console.WriteLine("\t\t\t\t\tElla era una doctora.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((was != 1) && contadorIntentos != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN UNO

                                            // ORACIÓN DOS
                                            int were;
                                            int contadorIntentos2 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       The keys _____ in the drawer.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. was"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. were");
                                                Console.WriteLine("\t\t                       3. are");
                                                Console.WriteLine("\t\t                       4. never");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                were = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (were == 2) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                              // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThe keys were in the drawer.");
                                                    Console.WriteLine("\t\t\t\t\tLas llaves estaban en el cajón.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos2 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos2++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((were != 2) && contadorIntentos2 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN DOS

                                            // ORACIÓN TRES
                                            int wanted;
                                            int contadorIntentos3 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       I _____ to dance.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. wanted"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. want");
                                                Console.WriteLine("\t\t                       3. tomorrow");
                                                Console.WriteLine("\t\t                       4. no");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                wanted = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (wanted == 1) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                              // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tI wanted to dance.");
                                                    Console.WriteLine("\t\t\t\t\tYo quería bailar.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos3 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos3++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((wanted != 1) && contadorIntentos3 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN TRES

                                            // ORACIÓN CUATRO
                                            int learned;
                                            int contadorIntentos4 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       They _____ English.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. learn"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. want");
                                                Console.WriteLine("\t\t                       3. yes");
                                                Console.WriteLine("\t\t                       4. learned");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                learned = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (learned == 4) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                              // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThey learned English.");
                                                    Console.WriteLine("\t\t\t\t\tEllos aprendieron inglés.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos4 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos4++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((learned != 4) && contadorIntentos4 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CUATRO

                                            // ORACIÓN CINCO
                                            int believed;
                                            int contadorIntentos5 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       We _____ him.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. is"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. no");
                                                Console.WriteLine("\t\t                       3. believed");
                                                Console.WriteLine("\t\t                       4. believe");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                believed = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (believed == 3) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                              // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tWe believed him.");
                                                    Console.WriteLine("\t\t\t\t\tNosotros le creímos.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos5 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos5++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((believed != 3) && contadorIntentos5 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CINCO

                                            // ORACIÓN SEIS
                                            int bought;
                                            int contadorIntentos6 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       I _____ a blue car.");
                                                Console.WriteLine("\n\n");
                                                Console.WriteLine("\t\t                       1. buy"); // Opciones de las que el usuario podrá escoger
                                                Console.WriteLine("\t\t                       2. bought");
                                                Console.WriteLine("\t\t                       3. am");
                                                Console.WriteLine("\t\t                       4. want");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                bought = int.Parse(Console.ReadLine());
                                                Console.WriteLine();
                                                if (bought == 2) // Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                              // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesPast++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tShe was a doctor.");
                                                    Console.WriteLine("\t\t\t\t\tElla era una doctora.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos6 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos6++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((bought != 2) && contadorIntentos6 != 3); // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                                                                           // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN SEIS

                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntajesPast + "/6."); // Muestra el puntaje al final del ejercicio

                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Past_Tense.txt");
                                            puntaje.WriteLine("El puntaje del ejercicio de Past Tense fue de: " + contadorPuntajesPast + "/6");
                                            puntaje.Close();

                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        }
                                    case 4: // Caso 4 para acceder a los ejercicios de FUTURE TENSE
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Escribir en inglés el verbo en tiempo futuro para completar la oración correctamente (tienes 3 intentos): ");
                                            Console.WriteLine("\n");
                                            Console.WriteLine("Presiona ENTER para comenzar...");
                                            Console.ReadKey();
                                            Console.Clear();

                                            int contadorPuntajesFuture = 0; // Contará el puntaje de los aciertos durante el ejercicio

                                            // ORACIÓN UNO
                                            String depart;
                                            int contadorIntentos = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       The plane _____ (depart) at 9:00.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                depart = Console.ReadLine();
                                                if (depart.ToLower() == "will depart") 
                                                    //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                    // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesFuture++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThe plane will depart at 9:00.");
                                                    Console.WriteLine("\t\t\t\t\tEl avión despegará a las 9:00.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((depart.ToLower() != "will depart") && contadorIntentos != 3);
                                            // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                            // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN UNO

                                            // ORACIÓN DOS
                                            String study;
                                            int contadorIntentos2 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       I promise I _____ (study) for the exam after the game.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                study = Console.ReadLine();
                                                if (study.ToLower() == "will study")
                                                //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesFuture++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tI promise I will study for the exam after the game.");
                                                    Console.WriteLine("\t\t\t\t\tYo prometo que yo estudiaré para el examen después del juego.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos2 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos2++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((study.ToLower() != "will study") && contadorIntentos2 != 3);
                                            // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                            // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN DOS

                                            // ORACIÓN TRES
                                            String start;
                                            int contadorIntentos3 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       The concert _____ (start) at 10 pm.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                start = Console.ReadLine();
                                                if (start.ToLower() == "will start")
                                                //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesFuture++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tThe concert will start at 10 pm.");
                                                    Console.WriteLine("\t\t\t\t\tEl concierto empezará a las 10 pm.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos3 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos3++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((start.ToLower() != "will start") && contadorIntentos3 != 3);
                                            // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                            // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN TRES

                                            // ORACIÓN CUATRO
                                            String clean;
                                            int contadorIntentos4 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       I _____ (clean) my room after school.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                clean = Console.ReadLine();
                                                if (clean.ToLower() == "will clean")
                                                //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesFuture++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tI will clean my room after school.");
                                                    Console.WriteLine("\t\t\t\t\tYo limpiaré mi cuarto después de la escuela.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos4 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos4++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((clean.ToLower() != "will clean") && contadorIntentos4 != 3);
                                            // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                            // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CUATRO

                                            // ORACIÓN CINCO
                                            String play;
                                            int contadorIntentos5 = 0;
                                            do
                                            {
                                                Console.WriteLine("\n\n\n\n\n\n\t\t                       We _____ (play) football this weekend.");
                                                Console.WriteLine("\n\n");
                                                Console.SetCursorPosition(50, 10);

                                                play = Console.ReadLine();
                                                if (play.ToLower() == "will play")
                                                //Si la palabra ingresada es igual a la correcta... (se usa .ToLower para que no importando 
                                                // si el usuario ponga la palabra en mayúsculas o minúsculas, el sistema la marcará como correcta).
                                                {
                                                    Correcto(); // Llama a la funcion Correcto() (Se encuentra desarrollada hasta el final del código)
                                                    contadorPuntajesFuture++;
                                                    Console.WriteLine("\n");
                                                    Console.ForegroundColor = ConsoleColor.Green; // Escribe la oración correcta completa al final
                                                    Console.WriteLine("\t\t\t\t\tWe will play football this weekend.");
                                                    Console.WriteLine("\t\t\t\t\tNosotros jugaremos fútbol este fin de semana.");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    contadorIntentos5 = 3;
                                                }
                                                else
                                                {
                                                    Incorrecto(); // Llama a la funcion Incorrecto() (Se encuentra desarrollada hasta el final del código)
                                                    Console.WriteLine("\n");
                                                    contadorIntentos5++; // Se incrementa el contador de intentos
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                            } while ((play.ToLower() != "will play") && contadorIntentos5 != 3);
                                            // Se sigue realizando el ejercicio hasta que se lleguen a los 3 intentos
                                            // si es que no se llega a la respuesta correcta antes.

                                            // FIN DE ORACIÓN CINCO

                                            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\t\t\tEl puntaje total fue de: " + contadorPuntajesFuture + "/5."); // Muestra el puntaje al final del ejercicio

                                            // Se guarda el puntaje en un archivo de texto para luego poder consultarlo en la sección de puntajes
                                            StreamWriter puntaje = File.CreateText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Future_Tense.txt");
                                            puntaje.WriteLine("El puntaje del ejercicio de Future Tense fue de: " + contadorPuntajesFuture + "/5");
                                            puntaje.Close();

                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        }
                                    case 5: // Caso 5 para salir del Menú de Ejercicios
                                        {
                                            Console.Clear();
                                            Salir();
                                            break;
                                        }
                                    default: // Caso default
                                        {
                                            Console.WriteLine("This option is not valid - Esta opción no es válida.");
                                            break;
                                        }
                                }

                            } while(opcion1 != 5);

                            break;
                        }

                    case 3: // SECCIÓN DE PUNTAJES
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tWelcome to the Score Section! - ¡Bienvenido a la sección de Puntajes!");
                            Console.WriteLine("\n");
                            Console.WriteLine("Aquí podrás ver todos tus puntajes de Basic English: ");
                            Console.WriteLine("\n\n");

                            // Abre el archivo de FRASES BÁSICAS y muestra el puntaje
                            StreamReader leer = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Frases_Basicas.txt");
                            string contenido = leer.ReadToEnd();
                            Console.WriteLine(contenido);
                            leer.Close();

                            // Abre el archivo de COLORES y muestra el puntaje
                            StreamReader leer2 = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Colores.txt");
                            string contenido2 = leer2.ReadToEnd();
                            Console.WriteLine(contenido2);
                            leer2.Close();

                            // Abre el archivo de NÚMEROS y muestra el puntaje
                            StreamReader leer3 = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Numeros.txt");
                            string contenido3 = leer3.ReadToEnd();
                            Console.WriteLine(contenido3);
                            leer3.Close();

                            // Abre el archivo de PRESENT TENSE y muestra el puntaje
                            StreamReader leer4 = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Present_Tense.txt");
                            string contenido4 = leer4.ReadToEnd();
                            Console.WriteLine(contenido4);
                            leer4.Close();

                            // Abre el archivo de PAST TENSE y muestra el puntaje
                            StreamReader leer5 = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Past_Tense.txt");
                            string contenido5 = leer5.ReadToEnd();
                            Console.WriteLine(contenido5);
                            leer5.Close();

                            // Abre el archivo de FUTURE TENSE y muestra el puntaje
                            StreamReader leer6 = File.OpenText(@"C:\Users\aniav\Documents\UAQ - Ingeniería de Software\Introducción a la Programación\ProyectoFinal_AnaVassallo\Archivos\Ejercicios_Future_Tense.txt");
                            string contenido6 = leer6.ReadToEnd();
                            Console.WriteLine(contenido6);
                            leer6.Close();

                            Console.WriteLine("\nPresiona ENTER para regresar...");
                            Console.ReadKey();

                            break;
                        }

                    case 4: // SECCIÓN DE SALIDA
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tAre you sure you want to quit? Type 1 for NO and any other number for YES");
                            Console.WriteLine("\n¿Estás seguro que deseas salir? ¿Deseas continuar en el programa? Ingresa 4 para SÍ, cualquier otro número para NO");
                            opcion = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Salir();
                            break;
                        }

                    default: // CASO DEFAULT
                        {
                            Console.WriteLine("This option is not valid - Esta opción no es válida.");
                            break;
                        }
                }
                
            } while (opcion != 4);
        }

        // FUNCIONES QUE SE OCUPAN DENTRO DEL PROGRAMA MAIN

        public static void Cuadrado() // Función para crear los cuadrados de 4 por 4 el la Sección de Números
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }

        public static void Correcto() // Función para crear el logo de CORRECTO
        {
            Console.ForegroundColor = ConsoleColor.Green; // Colorea todo de verde para indicar la respuesta correcta
            Console.WriteLine("\n\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.WriteLine("\n\t\t\t\t\t     CORRECT! - ¡CORRECTO!");
            Console.WriteLine("\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.ResetColor();
        }

        public static void Incorrecto() // Función para crear el logo de INCORRECTO
        {
            Console.ForegroundColor = ConsoleColor.Red; // Colorea todo de rojo para indicar la respuesta incorrecta
            Console.WriteLine("\n\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.WriteLine("\n\t\t\t\t\t  INCORRECT! - ¡INCORRECTO!");
            Console.WriteLine("\n\t\t\t\t\tTRY AGAIN - INTENTA OTRA VEZ");
            Console.WriteLine("\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.ResetColor();
        }

        public static void Salir() // Función para crear el logo de EXIT
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // Cambia las primeras 2 líneas de asteriscos a un color Cyan
            Console.WriteLine("\n\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.ResetColor(); // Resetea los colores de texto a su valor default
            Console.WriteLine("\n\t\t\t\t\t     GOODBYE! - ¡ADIÓS!");
            Console.ForegroundColor = ConsoleColor.DarkRed; // Cambia las primeras 2 líneas de asteriscos a un color Rojo Oscuro
            Console.WriteLine("\n\n\t\t\t\t\t****************************");
            Console.WriteLine("\t\t\t\t\t****************************");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}