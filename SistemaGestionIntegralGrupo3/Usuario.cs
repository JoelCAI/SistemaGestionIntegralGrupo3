using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionIntegralGrupo3
{
    public abstract class Usuario
    {
        protected int _registro;
        protected string _nombre;
        protected string _clave;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Clave
        {
            get { return this._clave; }
            set { this._clave = value; }
        }

        public int Registro
        {
            get { return this._registro; }
        }


        public static int _registroUsuario = 1;

        public Usuario(string nombre, string clave)
        {
            this._registro = _registroUsuario;
            _registroUsuario++;

            this._nombre = nombre;
            this._clave = clave;

        }


        /* Los métodos abstractos no pueden tener cuerpo */
        protected abstract void CrearClienteIndividual();

        protected abstract void CrearClienteCorporativo();

        protected abstract void EliminarClienteIndividual();

        protected abstract void EliminarClienteCorporativol();

        protected abstract void EditarClienteIndividual();

        protected abstract void EditarClienteCorporativo();

        /* La tarea de reponer es fundamental pero ya no recuerdan como hacerla */
        protected abstract void EstablecerCantidadCorrespondencia();

        protected abstract void EstablecerCantidadEncomienda();

        protected abstract void VerUsuario();

    }
}
