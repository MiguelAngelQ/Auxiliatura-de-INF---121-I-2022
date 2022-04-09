import java.util.Scanner;

public class carne extends alimento {
	private String clase;
	private String proteinas;
	private String corte;

	public carne() {
		super();
		clase = "porcino";
		proteinas = "todas";
		corte = "filete";
	}

	public carne(String no, int pr, String c, String p, String co) {
		super(no, pr);
		clase = c;
		proteinas = p;
		corte = co;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		super.leer();
		System.out.print("Into clase: ");
		clase = sc.next();
		System.out.print("Into proteinas: ");
		proteinas = sc.next();
		System.out.print("Into corte: ");
		corte = sc.next();
	}

	public void mostrar() {
		super.mostrar();
		System.out.println(clase);
		System.out.println(proteinas);
		System.out.println(corte);
		System.out.println();
	}

	public String getClase() {
		return clase;
	}

	public void setClase(String clase) {
		this.clase = clase;
	}

	public String getProteinas() {
		return proteinas;
	}

	public void setProteinas(String proteinas) {
		this.proteinas = proteinas;
	}

	public String getCorte() {
		return corte;
	}

	public void setCorte(String corte) {
		this.corte = corte;
	}

}
