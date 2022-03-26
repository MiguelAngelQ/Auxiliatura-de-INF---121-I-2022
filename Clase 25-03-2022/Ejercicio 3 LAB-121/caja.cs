/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 25/3/2022
 * Time: 18:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio{
	public class caja{
		private string color;
		private string estado;
		private int nroObj;
		private objeto []obj = new objeto[50];
		public caja(){
			color = "cafe";
			estado = "nuevo";
			nroObj = 0;
		}
		public caja(string col, string est){
			color = col;
			estado = est;
			nroObj = 0;
		}
		public void leer(){
			Console.Write("Into color caja: ");
			color = Console.ReadLine();
			Console.Write("Into estado caja: ");
			estado = Console.ReadLine();
			Console.Write("Into estado nro. objetos: ");
			nroObj = int.Parse(Console.ReadLine());
			for(int i = 0; i < nroObj; i++){
				obj[i] = new objeto();
				obj[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine(color + ", " + estado + ", " + nroObj);
			for(int i = 0; i < nroObj; i++){
				obj[i].mostrar();
			}
		}
		
		public static caja operator --(caja x){
			for(int i = 0; i < x.nroObj; i++){
				x.obj[i].setCosto(x.obj[i].getCosto() / 2);
			}
			return x;
		}
		public static caja operator ++(caja x){
			Console.Write("Into nuevo color: ");
			x.color = Console.ReadLine();
			Console.Write("Into nuevo estado: ");
			x.estado = Console.ReadLine();
			for(int i = 0; i < x.nroObj; i++){
				string aux = x.obj[i].getNombre();
				bool sw = true;//es palindrome
				for(int j = 0; j < aux.Length / 2; j++){
					if(aux[i] != aux[aux.Length - i - 1]){
						sw = false;
						break;
					}
				}
				if(sw == true){
					x.obj[i].mostrar();
				}
			}
			return x;
		}
		
		public string getColor() {
			return color;
		}
	
		public void setColor(string color) {
			this.color = color;
		}
	
		public string getEstado() {
			return estado;
		}
	
		public void setEstado(string estado) {
			this.estado = estado;
		}
	
		public int getNroObj() {
			return nroObj;
		}
	}
}
