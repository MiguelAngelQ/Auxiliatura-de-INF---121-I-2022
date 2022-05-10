import java.util.Scanner;

public class Empresa {
	private String nombre;
	private int nroClientes;
	private Cliente cliente[] = new Cliente[50];
	private int nroEmpleados;
	private Empleado empleado[] = new Empleado[50];

	public Empresa() {
		nombre = "Alfa";
		nroClientes = 0;
		nroEmpleados = 3;
		empleado[0] = new Empleado();
		empleado[1] = new Empleado("8845210", "Oscar", "Sanchez", "Soto", "17/08/1998", "cajero", 2, 4500.32);
		empleado[2] = new Empleado("9849210", "Brenda", "Montes", "Linares", "08/08/2000", "gerente", 2, 4700.32);
	}

	public Empresa(String n) {
		nombre = n;
		nroClientes = 0;
		nroEmpleados = 2;
		empleado[0] = new Empleado("7847210", "Maria", "Apaza", "Soto", "10/10/2001", "cajero", 1, 4800.32);
		empleado[1] = new Empleado("9849210", "Brenda", "Montes", "Linares", "08/08/2000", "gerente", 2, 4700.32);
	}

	public void leer() {
		Scanner sc = new Scanner(System.in);
		System.out.println("Introduzca nombre empresa");
		nombre = sc.next();
		System.out.println("Introduzca nroEmpleados");
		nroEmpleados = sc.nextInt();
		for (int i = 0; i < nroEmpleados; i++) {
			empleado[i] = new Empleado();
			empleado[i].leer();
		}
	}

	public void mostrar() {
		System.out.println(nombre + ", " + nroClientes);
		for (int i = 0; i < nroClientes; i++)
			cliente[i].mostrar();
		System.out.println(nroEmpleados);
		for (int i = 0; i < nroEmpleados; i++)
			empleado[i].mostrar();
	}

	public void eliminarEmpleado(String ciX) {
		for (int i = 0; i < nroEmpleados; i++) {
			if (empleado[i].getCi().equals(ciX)) {// verifico que tenga ci X
				for (int j = i + 1; j < nroEmpleados; j++) {
					empleado[j - 1] = empleado[j];
				}
				nroEmpleados -= 1;
				break;
			}
		}
	}
	
	public void eliminaEmpleadoCliente() {
		for(int i = 0; i < nroEmpleados; i++) {
			for(int j = 0; j < nroClientes; j++) {
				if(empleado[i].getCi().equals(cliente[j].getCi())) {
					eliminarEmpleado(empleado[i].getCi());
				}
			}
		}
	}
	
	public void agregarCliente(Cliente x) {
		cliente[nroClientes] = x;
		nroClientes += 1;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public int getNroClientes() {
		return nroClientes;
	}

	public void setNroClientes(int nroClientes) {
		this.nroClientes = nroClientes;
	}

	public Cliente[] getCliente() {
		return cliente;
	}

	public void setCliente(Cliente[] cliente) {
		this.cliente = cliente;
	}

	public int getNroEmpleados() {
		return nroEmpleados;
	}

	public void setNroEmpleados(int nroEmpleados) {
		this.nroEmpleados = nroEmpleados;
	}

	public Empleado[] getEmpleado() {
		return empleado;
	}

	public void setEmpleado(Empleado[] empleado) {
		this.empleado = empleado;
	}

}
