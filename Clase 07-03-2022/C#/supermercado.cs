/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 7/3/2022
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Consultas1{
	public class supermercado{
		//atributos:
		private string nombre, direccion;
		private int nroProductos;
		private string [,]productos = new string[50,3];
		public supermercado(){
			nombre = "Fidalga 3.0";
			direccion = "Plaza Avaroa, Esq. Azpiazu, No. 1234";
			nroProductos = 1;
			productos[0, 0] = "mantequilla";
			productos[0, 1] = "45";
			productos[0, 2] = "12";
		}
		public supermercado(string n, string d){
			nombre = n;
			direccion = d;
			nroProductos = 0;
		}
		public void leer(){
			Console.Write("Nombre supermercado: ");
			nombre = Console.ReadLine();
			Console.Write("Direccion supermercado: ");
			direccion = Console.ReadLine();
			Console.Write("NroProductos supermercado: ");
			nroProductos = int.Parse(Console.ReadLine());
			for(int i = 0; i < nroProductos; i++){
				Console.Write("nombre: ");
				productos[i, 0] = Console.ReadLine();
				Console.Write("stock: ");
				productos[i, 1] = Console.ReadLine();
				Console.Write("precio: ");
				productos[i, 2] = Console.ReadLine();
			}
		}
		public void mostrar(){
			Console.WriteLine(nombre + ", " + direccion + ", " + nroProductos);
			for(int i = 0; i < nroProductos; i++){
				Console.WriteLine("(" + productos[i, 0] + " " + productos[i, 1] + " " + productos[i, 2] + ")");

			}
		}
		//metodo: cuanto stock tengo del producto x
		public int stockDelProductoX(string x){
			for(int i = 0; i < nroProductos; i++){
				if(productos[i, 0] == x){//buscando al producto x
					return int.Parse(productos[i, 1]);
				}
			}
			return 0;//peor de los casos
		}
		//metodo: muestra los productos mas baratos del mercado this contra el x
		public void comparar(supermercado x){
			Console.WriteLine("Productos mas baratos del supermercado " + this.nombre + " contra el supermercado " + x.nombre);
			for(int i = 0; i < this.nroProductos; i++){
				for(int j = 0; j < x.nroProductos; j++){
					if(this.productos[i, 0] == x.productos[j, 0]){
						if(int.Parse(this.productos[i, 2]) < int.Parse(x.productos[j, 2])){
							Console.WriteLine(this.productos[i, 0]);
						}
					}
				}
			}
		}
		public string getNombre() {
			return nombre;
		}
		public void setNombre(string nombre) {
			this.nombre = nombre;
		}
		public string getDireccion() {
			return direccion;
		}
		public void setDireccion(string direccion) {
			this.direccion = direccion;
		}
		public int getNroProductos() {
			return nroProductos;
		}
		public void setNroProductos(int nroProductos) {
			this.nroProductos = nroProductos;
		}
	}
}
