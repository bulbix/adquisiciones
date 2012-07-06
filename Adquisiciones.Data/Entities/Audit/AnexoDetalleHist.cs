/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Type;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// AnexoDetalleHist object for NHibernate mapped table 'anexo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class AnexoDetalleHist
	{
		#region Member Variables

	    private int _id;

	    private Anexo _anexo;
	    private int _modificacion;
	    private short _renglonanexo;

		protected Articulo _articulo;
		protected string _presentacion;
		protected decimal? _cantidad;
	    private string _tipo;

		#endregion

        ///// <summary>
        ///// Construye un objeto anexo opor reflexion
        ///// </summary>
        ///// <param name="propertyNames">Arreglo con las propiedades</param>
        ///// <param name="previousState">Arreglo con los valores anteriores</param>
        ///// <returns></returns>
        //public static AnexoDetalleHist ConstruirHistorico(object id, string[] propertyNames,
        //    object[] previousState, IType[] types, string tipo)
        //{
        //    var result = new AnexoDetalleHist();
        //    int index = 0;
        //    var anexoDetalleHistType = typeof(AnexoDetalleHist);

        //    var idAnexoDetalle = (AnexoDetalleId) id;

        //    result.Anexo = idAnexoDetalle.Anexo;
        //    result.Modificacion = idAnexoDetalle.Anexo.Modificacion - 1;
        //    result.RenglonAnexo = idAnexoDetalle.RenglonAnexo;

        //    foreach (string propiedad in propertyNames)
        //    {
        //        switch (propiedad)
        //        {
        //            default:
        //                if (!types[index].IsCollectionType)
        //                {
        //                    anexoDetalleHistType.GetProperty(propiedad).
        //                        SetValue(result, previousState[index], null);
        //                }
        //                break;
        //        }

        //        ++index;
        //    }
         
        //    result.Tipo = tipo;

        //    return result;
        //}



		#region Constructors

		public AnexoDetalleHist() {}
		
		#endregion
		#region Public Properties
		

		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Presentacion
		{
			get { return _presentacion; }
			set {_presentacion= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}

	    public virtual int Modificacion
	    {
	        get { return _modificacion; }
	        set { _modificacion = value; }
	    }

	    public virtual Anexo Anexo
	    {
	        get { return _anexo; }
	        set { _anexo = value; }
	    }

	    public virtual string Tipo
	    {
	        get { return _tipo; }
	        set { _tipo = value; }
	    }

	    public virtual short RenglonAnexo
	    {
	        get { return _renglonanexo; }
	        set { _renglonanexo = value; }
	    }

	    public virtual int Id
	    {
	        get { return _id; }
	        set { _id = value; }
	    }

	    #endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
		    return true;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
