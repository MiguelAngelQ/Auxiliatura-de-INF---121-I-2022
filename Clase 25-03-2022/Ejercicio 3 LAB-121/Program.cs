/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 25/3/2022
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio{
	class Program{
		public static void Main(string[] args){
			//a
			caja a = new caja();
			caja b = new caja("azul", "viejo");
			caja c = new caja();
			c.leer();
			a.mostrar();
			b.mostrar();
			c.mostrar();
			//b
			--c;
			c.mostrar();
			//d
			++c;
			c.mostrar();
			
			Console.ReadKey(true);
		}
	}
}