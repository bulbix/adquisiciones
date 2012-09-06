/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;



namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Usuario object for NHibernate mapped table 'usuario'.
	/// </summary>
	[Serializable]
	public class Usuario:IComparable
	{
		#region Member Variables
		protected int _idusuario;
		protected string _rfc;
		protected string _nombre;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _password;
		protected IList<UsuarioModulo> _usuariomodulo;
		
		#endregion
		#region Constructors
			
		public Usuario() {}
					
		public Usuario(int idusuario, string rfc, string nombre, DateTime? fechaalta, DateTime? fechabaja, string estatus, string password) 
		{
			this._idusuario= idusuario;
			this._rfc= rfc;
			this._nombre= nombre;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._password= password;
		}

		public Usuario(int idusuario)
		{
			this._idusuario= idusuario;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdUsuario
		{
			get { return _idusuario; }
			set {_idusuario= value; }
		}

       
		public  virtual string Rfc
		{
			get { return _rfc; }
			set {_rfc= value; }
		}
		public  virtual string Nombre
		{
			get { return _nombre; }
			set {_nombre= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}

		public  virtual string Password
		{
			get { return _password; }
			set {_password= value; }
		}

		public  virtual IList<UsuarioModulo> UsuarioModulo
		{
			get { return _usuariomodulo; }
			set {_usuariomodulo= value; }
		}

		
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			Usuario castObj = (Usuario)obj;
			return ( castObj != null ) &&
			this._idusuario == castObj.IdUsuario;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _idusuario.GetHashCode();
			return hash;
		}
		#endregion

	    public int CompareTo(object other)
	    {
	        return IdUsuario.CompareTo((other as Usuario).IdUsuario);
	    }

	    public override string ToString()
        {
            return Rfc.Trim() + "/" + Nombre.Trim();
        }
	}
}
