using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionIntegralGrupo3
{
    public class Correspondencia
    {
		private string _codigo;
		private string _nombre;
		private int _cantidad;
		private int _precio;

		public string Codigo
		{
			get { return this._codigo; }
			set { this._codigo = value; }
		}
		public string Nombre
		{
			get { return this._nombre; }
			set { this._nombre = value; }
		}
		public int Cantidad
		{
			get { return this._cantidad; }
			set { this._cantidad = value; }
		}
		public int Precio
		{
			get { return this._precio; }
			set { this._precio = value; }
		}

		public Correspondencia(string codigo, string nombre)
		{
			this._codigo = codigo;
			this._nombre = nombre;
			this._cantidad = 0;
			this._precio = 0;
		}
	}
}
