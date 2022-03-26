/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 25/3/2022
 * Time: 18:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio{ 
	public class objeto{
		private string nombre;
		private int costo;
		public objeto(){
			nombre = "tajador";
			costo = 1;
		}
		public objeto(string nombre, int costo){
			this.nombre = nombre;
			this.costo = costo;
		}
		public void leer(){
			Console.Write("Into nombre objeto: ");
			nombre = Console.ReadLine();
			Console.Write("Into costo objeto: ");
			costo = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine(nombre + ", " + costo);
		}
		public string getNombre() {
			return nombre;
		}
	
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
	
		public int getCosto() {
			return costo;
		}
	
		public void setCosto(int costo) {
			this.costo = costo;
		}

	}
}
