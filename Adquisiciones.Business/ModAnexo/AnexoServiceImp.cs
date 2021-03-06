﻿using System;
using System.Collections.Generic;
using System.Linq;
using Adquisiciones.Business.Audit;
using Adquisiciones.Data;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;
using System.Windows.Forms;

namespace Adquisiciones.Business.ModAnexo
{
    ///<summary>
    ///</summary>
    public class AnexoServiceImp : IAnexoService,IFormBusqueda
    {
        public IAnexoDao AnexoDao { get; set; }

        public IAuditService AuditService { get; set; }

        public IArticuloDao ArticuloDao { get; set; }

        [Transaction(ReadOnly = true)]
        public void TiposLicitacionesCombo(ComboBox combo)
        {

            var listLicita = AnexoDao.
                CargarCatalogo<TipoLicitacion>("IdTipolicitacion");

            var dicc = listLicita.ToDictionary(licita => licita, licita => licita.DesTipolicitacion);

            Util.Dicc2Combo<TipoLicitacion, string>(dicc, combo);
        }

        [Transaction(ReadOnly = true)]
        public void IvasCombo(ComboBox combo)
        {
            var listIvas = AnexoDao.CargarCatalogo<Iva>("FechaAlta");

            var dicc = listIvas.ToDictionary(iva => iva, iva => iva.Id.Porcentaje);

            Util.Dicc2Combo<Iva, short>(dicc, combo);
        }

        public void InstitutosCombo(ComboBox combo)
        {
            var institutos = new Dictionary<string, string>
                                 {
                                     {"O", "ORTOPEDIA"},
                                     {"C", "COMUNICACION"},
                                     {"R", "REHABILITACION"}
                                 };
            Util.Dicc2Combo<string, string>(institutos, combo);
        }

        /// <summary>
        /// Guarda el anexo con los detalles el renglon se oculta </summary>
        /// <param name="anexo"></param>
        [Transaction]
        public void GuardarAnexo(ref Anexo anexo)
        {
            
            if(anexo.IdAnexo == 0)
            {
                anexo.FechaCaptura = AnexoDao.FechaServidor();
            }

            anexo.FechaModificacion = AnexoDao.FechaServidor();
            anexo.IpTerminal = Util.IpTerminal();
            ++anexo.Modificacion;
            
            foreach (var anexoDetalle in anexo.AnexoDetalle)
            {
                anexoDetalle.Anexo = anexo;
            }

            anexo = AnexoDao.Merge(anexo);
        }

        [Transaction(ReadOnly = true)]
        public Anexo ConsultarAnexo(string numAnexo, Almacen almacen)
        {

            var anexoConsulta = AnexoDao.ConsultaAnexo(numAnexo, almacen);
            if (anexoConsulta != null)//Existe
            {

                var anexosDetalleConsulta = anexoConsulta.AnexoDetalle;
                anexoConsulta.AnexoDetalle = new List<AnexoDetalle>();

                //Seteamos las propiedas de la vista
                foreach (var anexoDetalleConsulta in anexosDetalleConsulta)
                {
                    var anexoDetalle = new AnexoDetalle
                    {
                        IdAnexoDetalle = anexoDetalleConsulta.IdAnexoDetalle,
                        RenglonAnexo = anexoDetalleConsulta.RenglonAnexo,
                        Articulo = anexoDetalleConsulta.Articulo,
                        CveArt = anexoDetalleConsulta.Articulo.Id.CveArt,
                        DescripcionArt = anexoDetalleConsulta.Articulo.DesArticulo,
                        UnidadArt = anexoDetalleConsulta.Articulo.Unidad,
                        CantidadMinimo = anexoDetalleConsulta.CantidadMinimo,
                        CantidadMaximo =  anexoDetalleConsulta.CantidadMaximo
                    };

                    anexoConsulta.AnexoDetalle.Add(anexoDetalle);
                }
            }

            return anexoConsulta;

        }


        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
        {
            var anexos = AnexoDao.CargarAnexos(almacen);
            return anexos;
        }

        [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            AnexoDao.Delete(entity as Anexo);
        }

        public bool CancelarEntity(object entity)
        {
            return true;
        }
    }
}
