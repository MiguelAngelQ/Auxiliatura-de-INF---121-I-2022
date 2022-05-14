/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 13/5/2022
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persistencia2022{
	public class ArchLibro{
		private string na;//nombre de archivo;
        private libro rLib;//el objeto que guardara nuestro archivo
		public ArchLibro(string nombreArchivo){
        	na = nombreArchivo;
		}
        public void crearNuevo() {
            if(System.IO.File.Exists(na) ) {//verificamos si el aerchivo existe
                Console.WriteLine("Realmente quiere borrar el archivo?. s/n");
                if( Console.ReadKey().KeyChar == 's' )//pregunta si el usuario ingreso "s"
                    System.IO.File.Delete(na);//borra el archivo con nombre na
            }
            else
                Console.WriteLine("El archivo no existe.");
        }
        public void adicionar() {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.Append);
            BinaryWriter escribe = new BinaryWriter(arch);
            rLib = new libro();
            try {
                do {
                    rLib.leer();
                    rLib.escribir(escribe);
                    Console.Write("Desea continuar añadiendo libros? s/n : ");
                } while( Console.ReadKey().KeyChar == 's' );
            }
            catch( Exception  ) {
                Console.WriteLine("Fallo en adicionar el objeto !!!");
            }
            finally {
                arch.Close();
            }
        }
        public void listar() {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(na, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            rLib =new libro();
            try {
                while( true ) {
                    rLib.lectura(lee);
                    rLib.mostrar();
                }
            }
            catch( Exception ) {
                Console.WriteLine("Fin de archivo ...");
            }
            finally {
                arch.Close();
            }
        }
	}
}
