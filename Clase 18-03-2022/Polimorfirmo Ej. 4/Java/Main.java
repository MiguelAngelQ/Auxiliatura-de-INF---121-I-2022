import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		cuentaDeCorreo a = new cuentaDeCorreo();
		cuentaDeCorreo b = new cuentaDeCorreo("Alan Brito", "23/07/2021", "3", "salud", "Quedate en casa");
		cuentaDeCorreo c = new cuentaDeCorreo();
		c.leer();
		b.mostrar();
		c.mostrar();
		//b
		String fecha = sc.nextLine();
		c.mostrar(fecha);
		//c
		String autor = sc.nextLine();
		int y = sc.nextInt();
		c.mostrar(autor, y);
		//d
		b.comparar(c);
		//e
		String autorr = sc.nextLine();
		b.comparar(c, autorr);
	}
}
