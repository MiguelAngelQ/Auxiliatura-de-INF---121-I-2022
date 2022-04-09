
public class Main {

	public static void main(String[] args) {
	    //a
	    verdura v1 = new verdura("espinaca", 15, "cereal");
	    verdura v2 = new verdura("brocoli", 18, "planta");
	    fruta f1 = new fruta("manzana", 20, "si", "normal", "no");
	    carne c1 = new carne("chuleta", 50, "bobino", "si", "especial");
	    carne c2 = new carne("rabadilla", 58, "pocino", "si", "corriente");
	    //b
	    v1.mostrar();
	    v2.mostrar();
	    f1.mostrar();
	    c1.mostrar();
	    c2.mostrar();
	    //c) Insertar otro nombre y precio a la fruta.
	    f1.setNombre("naranja");
	    f1.setPrecio(25);
	    f1.mostrar();
	    //d) Verificar si la verdura 1 tiene los mismos minerales que la verdura 2.
	    if(v1.verificarMinerales(v2)) {
	    	System.out.println("Tienen mismos minerales");
	    }else {
	    	System.out.println("No tienen mismos minerales");
	    }
	  //e)Comparar el precio de la verdura 1 y la carne 2 y mostrar cual es mas barata.
	    if(v1.getPrecio() == c2.getPrecio()){
	        System.out.println("tienen mismos precios");
	    }else{
	        if(v1.getPrecio() > c2.getPrecio()){
	            v1.mostrar();
	        }else{
	            c2.mostrar();
	        }
	    }
	}
}
