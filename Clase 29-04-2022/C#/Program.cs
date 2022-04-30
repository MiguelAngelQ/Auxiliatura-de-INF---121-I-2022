/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/4/2022
 * Time: 18:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SegundoParcial2020{
	class Program{
		public static void Main(string[] args){
			/*SeminarioTaller a = new SeminarioTaller();
			//a
			a.leer();
			a.mostrar();
			//b Eliminar k expositores de genero Z del seminario taller instanciado (mantener el orden, no usar vectores auxiliares).
			Console.Write("Into k: ");
			int k = int.Parse(Console.ReadLine());
			Console.Write("Into Z: ");
			string z = Console.ReadLine();
			a.incisoB(k, z);
			a.mostrar();*/
			//c
			Expositor b = new Expositor();
			b.leer();
		    Seminario x = new Seminario();
		    x.leer();
		    Seminario y = new Seminario();
		    y.leer();
		    //verificamos en el primer seminario
		    if(x.incisoC(b.getTema())){
		        x.agregarExpositor(b);
		    }
		    //verificamos en el segundo seminario
		    if(y.incisoC(b.getTema())){
		        y.agregarExpositor(b);
		    }
		    x.mostrar();
		    y.mostrar();
			
			Console.ReadKey(true);
		}
	}
}