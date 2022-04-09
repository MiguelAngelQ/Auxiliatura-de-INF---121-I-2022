import java.util.Scanner;

public class fruta extends alimento {
	private String carbohidratos;
	private String tipo;
	private String azucares;

	public fruta() {
		super();
		carbohidratos = "grasa";
		tipo = "citrico";
		azucares = "abc";
	}

	public fruta(String nom, int pre, String c, String t, String a) {
		super(nom, pre);
		carbohidratos = c;
		tipo = t;
		azucares = a;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		super.leer();
		System.out.print("Into carbohidratos: ");
		carbohidratos = sc.next();
		System.out.print("Into tipo: ");
		tipo = sc.next();
		System.out.print("Into azucares: ");
		azucares = sc.next();
	}

	public void mostrar() {
		super.mostrar();
		System.out.println(carbohidratos);
		System.out.println(tipo);
		System.out.println(azucares);
		System.out.println();
	}

	public String getCarbohidratos() {
		return carbohidratos;
	}

	public void setCarbohidratos(String carbohidratos) {
		this.carbohidratos = carbohidratos;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getAzucares() {
		return azucares;
	}

	public void setAzucares(String azucares) {
		this.azucares = azucares;
	}

}
