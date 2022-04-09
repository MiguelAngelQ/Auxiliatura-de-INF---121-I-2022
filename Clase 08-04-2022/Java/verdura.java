import java.util.Scanner;

public class verdura extends alimento {
	private String tipo;

	public verdura() {
		super();
		tipo = "hortaliza";
	}

	public verdura(String n, int p, String t) {
		super(n, p);
		tipo = t;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		super.leer();
		System.out.print("Into tipo: ");
		tipo = sc.next();
	}

	public void mostrar() {
		super.mostrar();
		System.out.println(tipo);
		System.out.println();
	}
	
	public boolean verificarMinerales(verdura x) {
		if(this.nroM != x.nroM) {
			return false;
		}
		//si tienen la misma cantidad de minerales
		for(int i = 0; i < this.nroM; i++) {
			if(!this.m[i].equals(x.m[i])) {
				return false;
			}
		}
		return true;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

}
