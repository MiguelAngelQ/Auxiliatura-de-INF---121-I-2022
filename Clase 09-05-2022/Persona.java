import java.util.Scanner;

public class Persona {
	protected String ci, nombre, paterno, materno, fechaNacimiento;

	public Persona() {
		ci = "12345678";
		nombre = "Juan";
		paterno = "Perez";
		materno = "Perez";
		fechaNacimiento = "11/05/1998";// dd/mm/aaaa
	}

	public Persona(String c, String n, String p, String m, String f) {
		ci = c;
		nombre = n;
		paterno = p;
		materno = m;
		fechaNacimiento = f;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		System.out.println("Into ci, nombre, paterno, materno, fechanac: ");
		ci = sc.next();
		nombre = sc.next();
		paterno = sc.next();
		materno = sc.next();
		fechaNacimiento = sc.next();
	}

	public void mostrar() {
		System.out.println("\n" + ci + ", " + nombre + ", " + paterno + ", " + materno + ", " + fechaNacimiento);
	}

	public String getCi() {
		return ci;
	}

	public void setCi(String ci) {
		this.ci = ci;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getPaterno() {
		return paterno;
	}

	public void setPaterno(String paterno) {
		this.paterno = paterno;
	}

	public String getMaterno() {
		return materno;
	}

	public void setMaterno(String materno) {
		this.materno = materno;
	}

	public String getFechaNacimiento() {
		return fechaNacimiento;
	}

	public void setFechaNacimiento(String fechaNacimiento) {
		this.fechaNacimiento = fechaNacimiento;
	}

}
