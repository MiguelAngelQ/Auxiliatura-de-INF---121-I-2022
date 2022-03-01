/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 28/2/2022
 * Time: 22:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main{
	class Program{
		public static void Main(string[] args){
			mochila a = new mochila();//con constructor por defecto
			a.mostrar();
			mochila m = new mochila("Adidas", 200, "naranjado", 10.2);
			m.mostrar();
			mochila h = new mochila();
			h.leer();
			h.mostrar();
			
			Console.ReadKey(true);
		}
	}
}