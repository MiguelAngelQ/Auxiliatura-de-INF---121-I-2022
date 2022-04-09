import java.util.Scanner;

public class alimento {
	protected String nombre;
	protected int precio;
	protected int nroV;
	protected String v[] = new String[50];
	protected int nroM;
	protected String m[] = new String[50];

	public alimento() {
		nombre = "papa";
		precio = 10;
		nroV = 1;
		v[0] = "C";
		nroM = 1;
		m[0] = "Zinc";
	}

	public alimento(String n, int p) {
		nombre = n;
		precio = p;
		nroV = 1;
		v[0] = "C";
		nroM = 1;
		m[0] = "Zinc";
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Into nombre: ");
		nombre = sc.next();
		System.out.print("Into precio: ");
		precio = sc.nextInt();
		System.out.print("Into nroV: ");
		nroV = sc.nextInt();
		for (int i = 0; i < nroV; i++) {
			System.out.print("	Into vitamina: ");
			v[i] = sc.next();
		}
		System.out.print("Into nroM: ");
		nroM = sc.nextInt();
		for (int i = 0; i < nroM; i++) {
			System.out.print("	Into mineral: ");
			m[i] = sc.next();
		}
	}

	public void mostrar() {
		System.out.println(nombre);
		System.out.println(precio);
		System.out.println(nroV);
		for (int i = 0; i < nroV; i++) {
			System.out.println(v[i]);
		}
		System.out.println(nroM);
		for (int i = 0; i < nroV; i++) {
			System.out.println(m[i]);
		}
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getPrecio() {
		return precio;
	}

	public void setPrecio(int precio) {
		this.precio = precio;
	}

	public int getNroV() {
		return nroV;
	}

	public void setNroV(int nroV) {
		this.nroV = nroV;
	}

	public int getNroM() {
		return nroM;
	}

	public void setNroM(int nroM) {
		this.nroM = nroM;
	}

}
