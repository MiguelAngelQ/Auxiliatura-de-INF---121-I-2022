/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 7/3/2022
 * Time: 20:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Consultas1{
	class Program{
		public static void Main(string[] args){
			//a
			supermercado a = new supermercado();
			supermercado b = new supermercado("Ketal 5", "Av. Ovando, Esq. Colon, Nro. 456");
			a.leer();
			b.leer();
			//b
			a.mostrar();
			b.mostrar();
			//c
			Console.Write("Into producto: ");
			string x = Console.ReadLine();
			if(a.stockDelProductoX(x) == 0 && b.stockDelProductoX(x) == 0){//ambos no tienen stock
				Console.WriteLine("Ambos supermercados no tienen stock");
			}else{
				if(a.stockDelProductoX(x) == b.stockDelProductoX(x)){
					Console.WriteLine("Ambos supermercados tienen el mismo stock");
				}else{
					if(a.stockDelProductoX(x) > b.stockDelProductoX(x)){
						Console.WriteLine("El supermercado " + a.getNombre() + " tiene mas stock");
					}else{
						Console.WriteLine("El supermercado " + b.getNombre() + " tiene mas stock");
					}
					
				}
			}
			//d
			a.comparar(b);
			Console.ReadKey(true);
		}
	}
}