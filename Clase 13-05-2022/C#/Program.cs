/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 13/5/2022
 * Time: 21:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Persistencia2022{
	class Program{
		public static void Main(string[] args){
			bool sw = true;
           
            while( sw ) {
                // Hacemos que el fondo y el las letras sean de colores mas atractivos
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n                                        ");
                Console.WriteLine("          MENU                          ");
                Console.WriteLine("          ====                          ");
                Console.WriteLine("                                        ");
                Console.WriteLine("1. CREAR                                ");
                Console.WriteLine("2. ADICION                              ");
                Console.WriteLine("3. LISTADO                              ");
                Console.WriteLine("0. SALIR                                ");
                Console.WriteLine("                                        ");
                Console.WriteLine("INTRODUSCA  UNA  OPCION             =>  ");
                // leemos un caracter si esta en el intervalo 1-3 hace las 
                // Opciones que se detallan si es 4 o otro caracter sale del programa
                // haciendo un beep
                ArchLibro ejemplo = new ArchLibro(@"e:\Libros.dat");
                switch( Console.ReadKey().KeyChar ) {
                    case '1':
                        ejemplo.crearNuevo();
                        break;
                    case '2':
                        ejemplo.adicionar();
                        break;
                    case '3':
                        ejemplo.listar();
                        break;
                default:
                        Console.WriteLine("\n   El programa ya termino  !!!");
                        Console.Beep();
                        sw = false;
                        break;
                }
            }
			Console.ReadKey(true);
		}
	}
}