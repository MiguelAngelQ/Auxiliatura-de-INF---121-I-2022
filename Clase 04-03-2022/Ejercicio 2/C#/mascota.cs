/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 4/3/2022
 * Time: 19:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE3._{
	public class mascota{
		private string nombre;
		private string tipo;
		private int edad;
		private string raza;
		private string tamaño;
		private int peso;
		public mascota(){
			nombre = "Tobby";
			tipo = "perro";
			edad = 8;
			raza = "pastor aleman";
			tamaño = "mediano";
			peso = 40;
		}
		public mascota(string n, string t, int e, string r, string ta, int p){
			nombre = n;
			tipo = t;
			edad = e;
			raza = r;
			tamaño = ta;
			peso = p;
		}
		public void leer(){
			Console.Write("Introduzca nombre: ");
			nombre = Console.ReadLine();
			Console.Write("Introduzca tipo: ");
			tipo = Console.ReadLine();
			Console.Write("Introduzca edad: ");
			edad = int.Parse(Console.ReadLine());
			Console.Write("Introduzca raza: ");
			raza = Console.ReadLine();
			Console.Write("Introduzca tamaño: ");
			tamaño = Console.ReadLine();
			Console.Write("Introduzca peso: ");
			peso = int.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine(nombre + ", " + tipo + ", " + edad + ", " + raza + ", " + tamaño + ", " + peso);
		}
		public bool verificaRazaX(string x){
			if(raza == x){
				return true;
			}else{
				return false;
			}
		}
		public bool verificarTipoXMayorEdadY(string x, int y){//x tipo, y edad
			if(tipo == x && edad > y)
				return true;
			return false;
		}
		public bool esTipoPerro(){
			if(tipo == "perro"){
				return true;
			}
			return false;
		}
		public void verificaSuPeso(){
			Console.Write("El perro " + nombre + " tiene ");
			if(tamaño == "pequeño"){
				if(peso < 10){
					Console.WriteLine("Peso bajo");
				}else{
					if(peso > 15){
						Console.WriteLine("Sobrepeso");
					}else{
						Console.WriteLine("Peso normal");
					}
				}
			}else{
				if(tamaño == "mediano"){
					if(peso < 15){
						Console.WriteLine("Peso bajo");
					}else{
						if(peso > 25){
							Console.WriteLine("Sobrepeso");
						}else{
							Console.WriteLine("Peso normal");
						}
					}
				}else{
					if(peso < 25){
						Console.WriteLine("Peso bajo");
					}else{
						if(peso > 45){
							Console.WriteLine("Sobrepeso");
						}else{
							Console.WriteLine("Peso normal");
						}
					}
				}
			}
		}
	}
}
