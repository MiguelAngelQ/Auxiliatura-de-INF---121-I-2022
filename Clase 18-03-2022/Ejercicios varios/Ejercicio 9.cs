/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 18/3/2022
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CLASE5{
	class Program{
		public static void Main(string[] args){
			String []a = {"MUY_GASTADO", "GASTADO", "USO_MEDIO", "SEMI_NUEVO", "NUEVO"};
			//					0			1			2			3			4
			int n = int.Parse(Console.ReadLine());
			string []obj = new string[n];
			int []estado_obj = new int[n];
			for(int i = 0; i < n; i++){
				obj[i] = Console.ReadLine();
				string estado = Console.ReadLine();
				if(estado == a[0])
					estado_obj[i] = 0;
				if(estado == a[1])
					estado_obj[i] = 1;
				if(estado == a[2])
					estado_obj[i] = 2;
				if(estado == a[3])
					estado_obj[i] = 3;
				if(estado == a[4])
					estado_obj[i] = 4;
 			}
			for(int i = 0; i < n - 1; i++){
				for(int j = i + 1; j < n; j++){
					if(estado_obj[i] > estado_obj[j]){
						int aux = estado_obj[i];
						estado_obj[i] =  estado_obj[j];
						estado_obj[j] = aux;
						string aux2 = obj[i];
						obj[i] =  obj[j];
						obj[j] = aux2;
					}
				}
			}
			for(int i = 0; i < n; i++){
				Console.WriteLine(obj[i] + " " + a[estado_obj[i]]);
			}
			
			Console.ReadKey(true);
		}
	}
}