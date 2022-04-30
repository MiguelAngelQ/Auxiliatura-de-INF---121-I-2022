/*
 * Created by SharpDevelop.
 * User: Micky
 * Date: 29/4/2022
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SegundoParcial2020{
	public class Seminario{
		protected string nombre;
        protected string horaInicio;
        protected string fecha;
        protected int nroExpositores;
        protected Expositor []e = new Expositor[50];
        protected string []horaExp = new string[50];
        
		public Seminario(){
			nombre = "Evento 2022";
            horaInicio = "19:30:00";//hh:mm:ss
            fecha = "25/04/2022";//dd/mm/aaaa
            e[0] = new Expositor();
            horaExp[0] = "19:30:00";
            e[1] = new Expositor("Alan Brito", "Comedia", "Anecdotas");
            horaExp[1] = "20:00:00";
            nroExpositores = 2;
        }
        public Seminario(string n, string h, string f, Expositor a, string b){
        	nombre = n;
            horaInicio = h;
            fecha = f;
            e[0] = new Expositor();
            e[0] = a;
            horaExp[0] = b;
            nroExpositores = 1;
        }
        public void leer(){
        	Console.Write("Into nombre: ");
        	nombre = Console.ReadLine();
        	Console.Write("Into horaInicio: ");
        	horaInicio = Console.ReadLine();
        	Console.Write("Into fecha: ");
        	fecha = Console.ReadLine();
        	Console.Write("Into nroExpositores: ");
        	nroExpositores = int.Parse(Console.ReadLine());
        	for(int i = 0; i < nroExpositores; i++){
        		e[i] = new Expositor();
        		e[i].leer();
        		Console.Write("Into hora exposicion: ");
        		horaExp[i] = Console.ReadLine();
        	}
        }
        public void mostrar(){
        	Console.WriteLine(nombre + ", " + horaInicio + ", " + fecha +" , " + nroExpositores);
        	for(int i = 0; i < nroExpositores; i++){
        		e[i].mostrar();
        		Console.WriteLine(horaExp[i]);
        	}
        }
        public bool incisoC(string temaX){
            bool sw = true;//puedo exponer ese tema a las 10:00:00
            for(int i = 0; i < nroExpositores; i++){
                 if(e[i].getTema() == temaX && horaExp[i] == "10:00:00"){
                     sw = false;//ya no puedo
                 }
             }
             return sw;
        }
        public void agregarExpositor(Expositor x){
            e[nroExpositores] = x;
            horaExp[nroExpositores] = "10:00:00";
            nroExpositores = nroExpositores + 1;
        }
	}
}
