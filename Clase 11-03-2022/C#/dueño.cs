/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 11/3/2022
 * Time: 19:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE4{
	public class dueño{
		private string nombre;
		private int nroMascotas;
		private string []m = new string[5];
		public dueño(){
			nombre = "Alan Brito";
			nroMascotas = 0;
		}
		public dueño(string nombre, int nroMascotas){
			this.nombre = nombre;
			this.nroMascotas = nroMascotas;
			for(int i = 0; i < nroMascotas; i++){
				Console.Write("Intro codRegistro mascota: ");
				m[i] = Console.ReadLine();
			}
		}
		public void leer(){
			Console.Write("Intro nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Intro nroMascotas: ");
			nroMascotas = int.Parse(Console.ReadLine());
			for(int i = 0; i < nroMascotas; i++){
				Console.Write("Intro codRegistro mascota: ");
				m[i] = Console.ReadLine();
			}
		}
		public void mostrar(){
			Console.WriteLine("\nnombre: " + nombre);
			Console.WriteLine("nroMascotas: " + nroMascotas);
			for(int i = 0; i < nroMascotas; i++){
				Console.WriteLine("codRegistro mascota: " + m[i]);
			}
		}
		
		public void ordenarMascotas(mascota a, mascota b){
			if(nroMascotas == 2){
				int []edades = new int[nroMascotas];
				for(int i = 0; i < nroMascotas; i++){
					if(a.getCodRegistro() == m[i])
						edades[i] = a.getEdad();
					if(b.getCodRegistro() == m[i])
						edades[i] = b.getEdad();	
				}
				if(edades[0] > edades[1]){
					string aux = m[0];
					m[0] = m[1];
					m[1] = aux;
				}
			}
		}
		
		public void inicisoC(mascota a, mascota b){
			for(int i = 0; i < nroMascotas; i++){
				if(m[i] == a.getCodRegistro() && a.getTipo() == "perro"){
					Console.WriteLine(a.getAnioVacuna());
				}
				if(m[i] == b.getCodRegistro() && b.getTipo() == "perro"){
					Console.WriteLine(b.getAnioVacuna());
				}
			}
		}
		
		public string getNombre() {
			return nombre;
		}
	
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
	
		public int getNroMascotas() {
			return nroMascotas;
		}
	
		public void setNroMascotas(int nroMascotas) {
			this.nroMascotas = nroMascotas;
		}
	}
}
