using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionIntegralGrupo3
{
    public class Sistema
    {
		
		public void MenuPrincipal()
		{
			Console.WriteLine("Hola Bienvenido a nuestro Sistema");
			Validador.Despedida();
			Console.Clear();
			int opcion;
			string nombre, clave;
			int posUsuarioA;
			int posUsuarioS;
			int posUsuarioC;

			/* 
			do
			{
				Console.Clear();
				opcion = Validador.PedirIntMenu("\n Menú del Sistema" +
									   "\n [1] Ingresar como Administrador." +
									   "\n [2] Ingresar como Supervisor." +
									   "\n [3] Ingresar como Cajero." +
									   "\n [4] Registrar usuario (Administrador, Supervisor o Cajero)." +
									   "\n [5] Ingresar como Gerente de Operaciones." +
									   "\n [6] Salir del Sistema.", 1, 6);
				switch (opcion)
				{
					case 1:
						Console.Clear();
						nombre = Validador.ValidarStringNoVacioUsuarioClave("\n\n Ingrese Usuario Administrador: ");
						posUsuarioA = BuscarUsuarioAdministradorNombre(nombre);
						if (posUsuarioA != -1)
						{
							Console.WriteLine(" El usuario *" + nombre + "* existe");
							clave = Validador.ValidarStringNoVacioUsuarioClave("\n Ingrese Clave: ");
							posUsuarioA = BuscarUsuarioAdministrador(nombre, clave);
							if (posUsuarioA != -1)
							{
								_usuarioAdministador[posUsuarioA].MenuAdministrador(this._producto); // Pasar el vector de productos como parametro
								this._producto = _usuarioAdministador[posUsuarioA].Producto; // Sincroniza los datos entre los objetos
							}
							else
							{
								Console.WriteLine("\n El Usuario *" + nombre + "* Existe pero la clave es incorrecta" +
												  "\n Vuelva a intentarlo cuando recuerde la clave");
								Validador.VolverMenu();
							}
						}
						else
						{

							Console.WriteLine("\n El Usuario *" + nombre + "* No existe");
							Console.WriteLine("\n Cuando vuelva al Menú Principal elija la opción 4 y regístrese si desea" +
											  " utilizar éste Rol como Administrador");
							Validador.VolverMenu();

						}
						break;
					case 2:
						Console.Clear();
						nombre = Validador.ValidarStringNoVacioUsuarioClave("\n\nIngrese Usuario Supervisor: ");
						posUsuarioS = BuscarUsuarioSupervisorNombre(nombre);
						if (posUsuarioS != -1)
						{
							Console.WriteLine(" El usuario *" + nombre + "* existe");
							clave = Validador.ValidarStringNoVacioUsuarioClave("\n Ingrese Clave: ");
							posUsuarioS = BuscarUsuarioSupervisor(nombre, clave);
							if (posUsuarioS != -1)
							{
								_usuarioSupervisor[posUsuarioS].MenuSupervisor(this._producto); // Pasar el vector de productos como parametro
								this._producto = _usuarioSupervisor[posUsuarioS].Producto; // Sincroniza los datos entre los objetos
							}
							else
							{
								Console.WriteLine("\n El Usuario *" + nombre + "* Existe pero la clave es incorrecta" +
												  "\n Vuelva a intentarlo cuando recuerde la clave");
								Validador.VolverMenu();
							}
						}
						else
						{

							Console.WriteLine("\n El Usuario *" + nombre + "* No existe");
							Console.WriteLine("\n Cuando vuelva al Menú Principal elija la opción 4 y regístrese si desea" +
											  " utilizar éste Rol como Supervisor");
							Validador.VolverMenu();

						}
						break;
					case 3:
						Console.Clear();
						nombre = Validador.ValidarStringNoVacioUsuarioClave("\n\n Ingrese Usuario Cajero: ");
						posUsuarioC = BuscarUsuarioCajeroNombre(nombre);
						if (posUsuarioC != -1)
						{
							Console.WriteLine(" El usuario " + nombre + " existe");
							clave = Validador.ValidarStringNoVacioUsuarioClave("\n Ingrese Clave: ");
							posUsuarioC = BuscarUsuarioCajero(nombre, clave);
							if (posUsuarioC != -1)
							{
								_usuarioCajero[posUsuarioC].MenuCajero(this._producto, this._venta);
								this._producto = _usuarioCajero[posUsuarioC].Producto;
								this._venta = _usuarioCajero[posUsuarioC].Venta;

							}
							else
							{
								Console.WriteLine("\n El Usuario *" + nombre + "* Existe pero la clave es incorrecta" +
												  "\n Vuelva a intentarlo cuando recuerde la clave");
								Validador.VolverMenu();
							}
						}
						else
						{
							Console.WriteLine("\n El Usuario *" + nombre + "* No existe");
							Console.WriteLine("\n Cuando vuelva al Menú Principal elija la opción 4 y regístrese si desea" +
											  " utilizar éste Rol como Cajero");
							Validador.VolverMenu();
						}
						break;
					case 4:
						MenuRegistroUsuario();
						break;
					case 5:
						ValidacionGerenteOperacion();
						break;
					case 6:
						break;

				}
			} while (opcion != 6);

			Validador.Despedida(); */
		}

		public void Iniciar()
		{
			MenuPrincipal();
		}
	}
}
