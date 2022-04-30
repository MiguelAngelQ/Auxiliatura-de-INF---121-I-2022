/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/4/2022
 * Time: 18:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SegundoParcial2020{
	public class SeminarioTaller:Seminario{
		private string lugar;
		
		public SeminarioTaller():base(){
			lugar = "Auditorio A";
		}
		public SeminarioTaller(string n, string h, string f, Expositor a, string b, string lug):base(n, h, f, a, b){
			lugar = lug;
		}
		public void leer(){
			base.leer();
			Console.Write("Into lugar: ");
			lugar = Console.ReadLine();
		}
		public void mostrar(){
			base.mostrar();
			Console.WriteLine(lugar);
		}
		public void incisoB(int k, string z){
			while(k > 0){
				for(int i = 0; i < nroExpositores; i++){
					if(e[i].getGenero() == z){
						for(int j = i; j < nroExpositores - 1; j++){
							e[j] = e[j + 1];
							horaExp[j] = horaExp[j + 1];
						}
						nroExpositores = nroExpositores - 1;
						break;
					}
				}
				k = k - 1;
			}
		}
	}
}
