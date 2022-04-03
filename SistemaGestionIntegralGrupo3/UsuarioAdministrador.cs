using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionIntegralGrupo3
{
    public class UsuarioAdministrador : Usuario
    {
		protected List<Correspondencia> _producto;

		/* Descriptor de acceso a la lista de productos */
		public List<Correspondencia> Producto
		{
			get { return this._producto; }
			set { this._producto = value; }
		}

		/* Declaracion del constructor hijo */
		public UsuarioAdministrador(string nombre, string clave, List<Correspondencia> producto) : base(nombre, clave)
		{
			this._producto = producto;
		}

		/* Con esto voy a poder trabajar en mi atributo Productos */
		public void MenuAdministrador(List<Correspondencia> producto)
		{
			Producto = producto; /* Se reciben los productos del sistema */
			int opcion;
			/*do
			{
				/*
				Console.Clear();
				opcion = Validador.PedirIntMenu("\n Menu del Sistema" +
									   "\n [1] Crear Producto." +
									   "\n [2] Eliminar Producto." +
									   "\n [3] Editar Producto." +
									   "\n [4] Ver Productos." +
									   "\n [5] Volver al menu Principal.", 1, 6);

				switch (opcion)
				{
					case 1:
						CrearProducto();
						break;
					case 2:
						EliminarProducto();
						break;
					case 3:
						EditarProducto();
						break;
					case 4:
						VerProducto();
						Validador.VolverMenu();
						break;
					case 5:
						break;
				}
			} while ();*/
		}

		protected override void CrearClienteIndividual()
        {

        }

		protected override void CrearClienteCorporativo()
        {

        }

		protected override void EliminarClienteIndividual()
        {

        }

		protected override void EliminarClienteCorporativol()
        {

        }

		protected override void EditarClienteIndividual()
        {

        }

		protected override void EditarClienteCorporativo()
        {

        }

		/* La tarea de reponer es fundamental pero ya no recuerdan como hacerla */
		protected override void EstablecerCantidadCorrespondencia()
        {

        }

		protected override void EstablecerCantidadEncomienda()
        {

        }

		protected override void VerUsuario()
		{

		}

	}
}
