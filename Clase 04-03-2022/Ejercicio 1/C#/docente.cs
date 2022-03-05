/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 4/3/2022
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE3{

	public class docente{
		private string nombre;
		private string paterno;
		private string materno;
		private double sueldo;
		private string area;
		
		public docente(){
			nombre = "Juan";
			paterno = "Perez";
			materno = "Perez";
			sueldo = 1789.00;
			area = "INF-111";
		}
		public docente(string nombre, string pat, string materno, double sueldo, string area){
			this.nombre = nombre;
			paterno = pat;
			this.materno = materno;
			this.sueldo = sueldo;
			this.area = area;
		}
		public void leer(){
			Console.Write("Ingrese nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Ingrese paterno: ");
			paterno = Console.ReadLine();
			Console.Write("Ingrese materno: ");
			materno = Console.ReadLine();
			Console.Write("Ingrese sueldo: ");
			sueldo = double.Parse(Console.ReadLine());
			Console.Write("Ingrese area: ");
			area = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine();
			Console.WriteLine("Nombre: " + nombre);
			Console.WriteLine("Paterno: " + paterno);
			Console.WriteLine("Materno: " + materno);
			Console.WriteLine("Sueldo: " + sueldo);
			Console.WriteLine("Area: " + area);
		}
		public void mayorSueldo(docente x){
			if(this.sueldo > x.sueldo){
				Console.WriteLine(this.nombre + " " + this.paterno + " " + this.materno);
			}else{
				Console.WriteLine(x.nombre + " " + x.paterno + " " + x.materno);
			}
		}
		public void modificarArea(string x){
			area = x;
			//this.area = x;
		}
		public void mismaArea(docente x){
			if(area == x.area){
				Console.WriteLine(nombre + " " + sueldo);
				Console.WriteLine(x.nombre + " " + x.sueldo);
			}else{
				Console.WriteLine("No son de la misma area");
			}
		}
	}
}
