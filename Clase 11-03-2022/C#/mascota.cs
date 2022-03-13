/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 11/3/2022
 * Time: 19:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE4{
	/// <summary>
	/// Description of mascota.
	/// </summary>
	public class mascota{
		private string nombre;
		private int edad;
		private string tipo;
		private int anioVacuna;
		private string codRegistro;
		
		public mascota(){
			nombre = "Duke";
			edad = 1;
			tipo = "pastor aleman";
			anioVacuna = 2022;
			codRegistro = "123AB";
		}
		
		public mascota(string nombre, int e, string t, int a, string c){
			this.nombre = nombre;
			edad = e;
			tipo = t;
			anioVacuna = a;
			codRegistro = c;
		}
		
		public void leer(){
			Console.Write("Intro nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Intro edad: ");
			edad = int.Parse(Console.ReadLine());
			Console.Write("Intro tipo: ");
			tipo = Console.ReadLine();
			Console.Write("Intro anioVacuna: ");
			anioVacuna = int.Parse(Console.ReadLine());
			Console.Write("Intro codRegistro: ");
			codRegistro = Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("\nnombre: " + nombre);
			Console.WriteLine("edad: " + edad);
			Console.WriteLine("tipo: " + tipo);
			Console.WriteLine("anioVacuna: " + anioVacuna);
			Console.WriteLine("codRegistro: " + codRegistro);
		}
		
		public string getNombre() {
			return nombre;
		}
	
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
	
		public int getEdad() {
			return edad;
		}
	
		public void setEdad(int edad) {
			this.edad = edad;
		}
	
		public string getTipo() {
			return tipo;
		}
	
		public void setTipo(string tipo) {
			this.tipo = tipo;
		}
	
		public int getAnioVacuna() {
			return anioVacuna;
		}
	
		public void setAnioVacuna(int anioVacuna) {
			this.anioVacuna = anioVacuna;
		}
	
		public string getCodRegistro() {
			return codRegistro;
		}
	
		public void setCodRegistro(string codRegistro) {
			this.codRegistro = codRegistro;
		}

	}
}
