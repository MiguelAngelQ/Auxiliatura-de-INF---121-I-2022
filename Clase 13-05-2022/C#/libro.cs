/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 13/5/2022
 * Time: 21:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace Persistencia2022{
	[Serializable]
	public class libro{
		private int codigo;
        private string nombre;
        private string autor;
        private int nro_paginas;
		public libro(){
        	codigo = 1;
            nombre = "Donde esta mi queso";
            autor = "A. Perez";
            nro_paginas = 128;
		}
        public libro(int c, string n, string a, int nro){
            codigo = c;
            nombre = n;
            autor = a;
            nro_paginas = nro;
        }
        public void leer(){
        	Console.Write("Into codigo: ");
        	codigo = int.Parse(Console.ReadLine());
        	Console.Write("Into nombre: ");
        	nombre = Console.ReadLine();
        	Console.Write("Into autor: ");
        	autor = Console.ReadLine();
        	Console.Write("Into nro_paginas: ");
        	nro_paginas = int.Parse(Console.ReadLine());
        }
        public void mostrar(){
        	Console.WriteLine(codigo + ", " + nombre + ", " + autor + ", " + nro_paginas);
        }
        public void escribir(BinaryWriter escritor){
            escritor.Write(this.codigo);
            escritor.Write(this.nombre);
            escritor.Write(this.autor);
            escritor.Write(this.nro_paginas);
        }
        public void lectura( BinaryReader lector) {
            this.codigo = lector.ReadInt32();
            this.nombre = lector.ReadString();
            this.autor = lector.ReadString();
            this.nro_paginas = lector.ReadInt32();
        }
        string getAutor(){
            return autor;
        }
        int getCodigo(){
            return codigo;
        }
	}
}
