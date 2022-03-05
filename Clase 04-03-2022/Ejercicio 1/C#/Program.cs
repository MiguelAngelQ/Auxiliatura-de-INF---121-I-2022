/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 4/3/2022
 * Time: 18:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE3{
	class Program{
		public static void Main(string[] args){
			//a
			docente a = new docente();
			a.leer();
			docente b = new docente("Fernando", "Apaza", "Flores", 3400.80, "LIN-116");
			//b
			a.mostrar();
			b.mostrar();
			//c
			a.mayorSueldo(b);
			//d
			Console.Write("Introduzca area nueva de trabajo: ");
			string x = Console.ReadLine();
			b.modificarArea(x);
			b.mostrar();
			//e
			a.mismaArea(b);
			
			Console.ReadKey(true);
		}
	}
}