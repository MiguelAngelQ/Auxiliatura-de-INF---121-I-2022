import java.util.Scanner;

public class Cliente extends Persona {
	private int codCliente;

	public Cliente() {
		super();
		codCliente = 1;
	}

	public Cliente(String c, String n, String p, String m, String f, int code) {
		super(c, n, p, m, f);
		codCliente = code;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		super.leer();
		System.out.println("Into codCliente:");
		codCliente = sc.nextInt();
	}

	public void mostrar() {
		super.mostrar();
		System.out.println(codCliente);
	}

	public int getCodCliente() {
		return codCliente;
	}

	public void setCodCliente(int codCliente) {
		this.codCliente = codCliente;
	}

}
