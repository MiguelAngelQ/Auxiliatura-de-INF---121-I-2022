/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 4/3/2022
 * Time: 19:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE3._{
	class Program{
		public static void Main(string[] args){
			//a
			mascota a = new mascota();
			mascota b = new mascota("Boby", "perro", 2, "chapi", "pequeño", 10);
			mascota c = new mascota("Poly", "loro", 3, "tropical", "pequeño", 1);
			mascota d = new mascota("Michi", "gato", 5, "angora", "mediano", 10);
			a.mostrar();
			b.mostrar();
			c.mostrar();
			d.mostrar();
			//b
			a.leer();
			a.mostrar();
			//c
			Console.Write("Introduzca raza: ");
			string x = Console.ReadLine();
			if(a.verificaRazaX(x) == true || b.verificaRazaX(x) == true || c.verificaRazaX(x) == true || d.verificaRazaX(x) == true){
				Console.WriteLine("Se tiene a la mascota con raza " + x);
			}else{
				Console.WriteLine("No se tiene a la mascota con raza " + x);
			}
			//d
			Console.Write("Introduzca tipo: ");
			x = Console.ReadLine();
			Console.Write("Introduzca edad: ");
			int y = int.Parse(Console.ReadLine());
			if(a.verificarTipoXMayorEdadY(x, y) == true){
				a.mostrar();
			}
			if(b.verificarTipoXMayorEdadY(x, y) == true){
				b.mostrar();
			}
			if(c.verificarTipoXMayorEdadY(x, y) == true){
				c.mostrar();
			}
			if(d.verificarTipoXMayorEdadY(x, y) == true){
				d.mostrar();
			}
			//e
			if(a.esTipoPerro() == true){
				a.verificaSuPeso();
			}
			if(b.esTipoPerro() == true){
				b.verificaSuPeso();
			}
			if(c.esTipoPerro() == true){
				c.verificaSuPeso();
			}
			if(d.esTipoPerro() == true){
				d.verificaSuPeso();
			}
			
			
			Console.ReadKey(true);
		}
	}
}