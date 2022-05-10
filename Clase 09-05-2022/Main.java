
public class Main {

	public static void main(String[] args) {
		//a: listo
		//crear una empresa con tres empleados
		//b
		Empresa e = new Empresa();//crea con 3 empleados
		e.mostrar();
		e.eliminarEmpleado("9849210");
		e.mostrar();
		//d
		//creamos 4 clientes para agregarlos
		Cliente c1 = new Cliente("9849210", "Brenda", "Montes", "Linares", "08/08/2000", 1);
		Cliente c2 = new Cliente("12345678", "Juan", "Perez", "Perez", "11/05/1998", 2);
		Cliente c3 = new Cliente("17896542", "Marcos", "Mendez", "Ali", "13/03/1089", 3);
		Cliente c4 = new Cliente("25987653", "Susana", "Ramos", "Mamani", "13/03/1089", 4);
		e.agregarCliente(c1);
		e.agregarCliente(c2);
		e.agregarCliente(c3);
		e.agregarCliente(c4);
		e.mostrar();
		e.eliminaEmpleadoCliente();
		System.out.println("-----");
		e.mostrar();
	}

}
