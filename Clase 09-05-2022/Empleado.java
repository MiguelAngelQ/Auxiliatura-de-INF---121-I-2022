import java.util.Scanner;

public class Empleado extends Persona {
	private String cargo;
	private int nroItem;
	private double sueldo;

	public Empleado() {
		super();
		cargo = "mensajero";
		nroItem = 1;
		sueldo = 3500.50;
	}

	public Empleado(String c, String n, String p, String m, String f, String car, int nro, double s) {
		super(c, n, p, m, f);
		cargo = car;
		nroItem = nro;
		sueldo = s;
	}

	public void leer() {
		super.leer();
		Scanner sc = new Scanner(System.in);
		System.out.println("Into cargo, nro Item, sueldo");
		cargo = sc.next();
		nroItem = sc.nextInt();
		sueldo = sc.nextDouble();
	}

	public void mostrar() {
		super.mostrar();
		System.out.println(cargo + ", " + nroItem + ", " + sueldo);
	}

	public String getCargo() {
		return cargo;
	}

	public void setCargo(String cargo) {
		this.cargo = cargo;
	}

	public int getNroItem() {
		return nroItem;
	}

	public void setNroItem(int nroItem) {
		this.nroItem = nroItem;
	}

	public double getSueldo() {
		return sueldo;
	}

	public void setSueldo(double sueldo) {
		this.sueldo = sueldo;
	}

}
