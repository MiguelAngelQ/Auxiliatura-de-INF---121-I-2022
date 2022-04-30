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
	public class Expositor{
		private string nombre;
		private string genero;
		private string tema;
		
		public Expositor(){
			nombre = "Juan Perez";
			genero = "Oratoria";
			tema = "Tecnicas de oratoria";
		}
		public Expositor(string n, string g, string t){
			nombre = n;
			genero = g;
			tema = t;
		
		}
		public void leer(){
			Console.Write("Into nombre expositor: ");
			nombre = Console.ReadLine();
			Console.Write("Into genero expositor: ");
			genero = Console.ReadLine();
			Console.Write("Into tema expositor: ");
			tema = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine(nombre + ", " + genero + ", " + tema);
		}
		public string getGenero(){
			return genero;
		}
		public string getTema(){
			return tema;
		    }
	}
}
