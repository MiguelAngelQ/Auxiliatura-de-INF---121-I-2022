/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 11/3/2022
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE4{
	class Program{
		public static void Main(string[] args){
			dueño a = new dueño();
			dueño b = new dueño();
			mascota v = new mascota();
			mascota w = new mascota();
			a.leer();
			b.leer();
			a.mostrar();
			b.mostrar();
			v.leer();
			w.leer();
			v.mostrar();
			w.mostrar();
			//b
			Console.Write("Intro nombre dueño: ");
			string x = Console.ReadLine();
			if(a.getNombre() == x){
				a.ordenarMascotas(v, w);
				a.mostrar();
			}
			if(b.getNombre() == x){
				b.ordenarMascotas(v, w);
				b.mostrar();
			}
			//c
			a.inicisoC(v, w);
			b.inicisoC(v, w);
			//d
			if(a.getNroMascotas() > b.getNroMascotas()){
			
			}
			if(b.getNroMascotas() > a.getNroMascotas()){
			
			}
			
			
			Console.ReadKey(true);
		}
	}
}