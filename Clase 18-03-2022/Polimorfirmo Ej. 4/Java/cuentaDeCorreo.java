import java.util.Scanner;

public class cuentaDeCorreo {
	private int nroMensajes;
	private String sms[][] = new String[5][50];

	public cuentaDeCorreo() {
		nroMensajes = 0;
	}

	public cuentaDeCorreo(int nroMensajes) {
		Scanner sc = new Scanner(System.in);
		this.nroMensajes = nroMensajes;
		for (int i = 0; i < nroMensajes; i++) {
			sms[0][i] = sc.nextLine();
			sms[1][i] = sc.nextLine();
			sms[2][i] = sc.nextLine();
			sms[3][i] = sc.nextLine();
			sms[4][i] = sc.nextLine();
		}
	}

	public cuentaDeCorreo(String autor, String fecha, String tamaño, String motivo, String mensaje) {
		nroMensajes = 1;
		sms[0][0] = autor;
		sms[1][0] = fecha;
		sms[2][0] = tamaño;
		sms[3][0] = motivo;
		sms[4][0] = mensaje;
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		nroMensajes = sc.nextInt();
		sc.nextLine();
		for (int i = 0; i < nroMensajes; i++) {
			sms[0][i] = sc.nextLine();
			sms[1][i] = sc.nextLine();
			sms[2][i] = sc.nextLine();
			sms[3][i] = sc.nextLine();
			sms[4][i] = sc.nextLine();
		}
	}

	public void mostrar() {
		System.out.println(nroMensajes);
		for (int i = 0; i < nroMensajes; i++) {
			System.out.println(sms[0][i] + " " + sms[1][i] + " " + sms[2][i] + " " + sms[3][i] + " " + sms[4][i]);
		}
	}

	public void mostrar(String fecha) {
		for (int i = 0; i < nroMensajes; i++) {
			if (sms[1][i].equals(fecha)) {
				System.out.println(sms[0][i] + " " + sms[1][i] + " " + sms[2][i] + " " + sms[3][i] + " " + sms[4][i]);
			}
		}
	}

	public void mostrar(String autor, int y) {
		for (int i = 0; i < nroMensajes; i++) {
			if (sms[0][i].equals(autor) && Integer.parseInt(sms[2][i]) < y) {
				System.out.println(sms[0][i] + " " + sms[1][i] + " " + sms[2][i] + " " + sms[3][i] + " " + sms[4][i]);
			}
		}
	}

	public void comparar(cuentaDeCorreo a) {
		if (this.nroMensajes > a.nroMensajes) {
			this.mostrar();
		}
		if (a.nroMensajes > this.nroMensajes) {
			a.mostrar();
		}
		if (this.nroMensajes == a.nroMensajes) {
			System.out.println("ambos correos tienen el mismo nro. de mensajes");
		}
	}

	public int cantidadAutorX(String autor) {
		int res = 0;
		for (int i = 0; i < nroMensajes; i++) {
			if (sms[0][i].equals(autor)) {
				res = res + 1;
			}
		}
		return res;
	}

	public void comparar(cuentaDeCorreo a, String autor) {
		if (this.cantidadAutorX(autor) > a.cantidadAutorX(autor)) {
			this.mostrar();
		}
		if (a.cantidadAutorX(autor) > this.cantidadAutorX(autor)) {
			a.mostrar();
		}
		if (this.cantidadAutorX(autor) == a.cantidadAutorX(autor)) {
			System.out.println("ambos correos tienen el mismo nro. de mensajes del auto " + autor);
		}
	}

	public int getNroMensajes() {
		return nroMensajes;
	}
	

	public void setNroMensajes(int nroMensajes) {
		this.nroMensajes = nroMensajes;
	}
}
