/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 28/2/2022
 * Time: 22:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Main{
	public class mochila{
		//atributos
		private string marca;
		private double precio;
		private string color;
		private double capacidad;
		
		public mochila(){
			marca = "Totto";
			precio = 60.80;
			color = "plomo";
			capacidad = 2.5;
		}
		
		public mochila(string marca, double precio, string color, double c){
			this.marca = marca;
			this.precio = precio;
			this.color = color;
			capacidad = c;
		}
		
		public void leer(){
			Console.Write("Ingrese marca: ");
			marca = Console.ReadLine();
			Console.Write("Ingrese precio: ");
			precio = double.Parse(Console.ReadLine());
			Console.Write("Ingrese color: ");
			color = Console.ReadLine();
			Console.Write("Ingrese capacidad: ");
			capacidad = double.Parse(Console.ReadLine());
		}
		
		public void mostrar(){
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("Precio: " + precio);
			Console.WriteLine("Color: " + color);
			Console.WriteLine("Capacidad: " + capacidad);
		}
	}
}
