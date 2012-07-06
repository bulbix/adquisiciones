using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Net;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Business
{
    ///<summary>
    ///</summary>
    public class Util
    {   
        ///<summary>
        ///</summary>
        ///<returns></returns>
        public static string IpTerminal()
        {
            //Nombre del equipo
            var iphost = Dns.GetHostEntry(Dns.GetHostName());
            return iphost.HostName;
        }

        /// <summary>
        /// Valida todos los campos del entity
        /// </summary>
        /// <returns>True si los campos son validos</returns>
        public static bool DatosValidos<TE>(TE entity)
        {
            var result = true;
            var engine = new ValidatorEngine();
            engine.Configure();
            if (!engine.IsValid(entity))
            {
                var values = engine.Validate(entity);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Valida un entity y da un detalle de los errores
        /// </summary>
        /// <typeparam name="TE"></typeparam>
        /// <param name="entity">La entidad a validar</param>
        /// <param name="numErrores">El numero de errores al momento</param>
        /// <param name="listaErrores"></param>
        /// <returns></returns>
        public static bool DatosValidos<TE>(TE entity, Label numErrores, ListBox listaErrores)
        {
            var result = true;
            var engine = new ValidatorEngine();
            engine.Configure();
            if (!engine.IsValid(entity))
            {
                var values = engine.Validate(entity);
                numErrores.Text = values.Length + " Errores";
                LlenarErroresEnLista(values, ref listaErrores);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Valida una fecha valida
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static bool FechaValida(DateTime? fecha)
        {
            bool result = true;

            if (fecha == null || fecha.ToString().Equals("01/01/0001 12:00:00 a.m."))
                result = false;

            return result;
        }


        /// <summary>
        /// Llena los errores generados por el engine
        /// </summary>
        /// <param name="values"></param>
        /// <param name="listaError"></param>
        public static void LlenarErroresEnLista(InvalidValue[] values, ref ListBox listaError)
        {
            listaError.Items.Clear();

            foreach (var message in 
                values.Select(value => value.PropertyName + ":" + value.Message))
            {
                listaError.Items.Add(message);
            }
        }

        /// <summary>
        /// Transforma la lista al dataset con los parametros especificados
        /// </summary>
        /// <param name="valores"></param>
        /// <param name="combo"></param>
        /// <returns></returns>
        public static void Dicc2Combo<TV,TL>(Dictionary<TV,TL> valores,ComboBox combo)
        {
            var tabla = new DataTable();
            tabla.Columns.Add("value", typeof(TV));
            tabla.Columns.Add("label", typeof(TL));

            foreach(var kvp in valores)
            {
                var fila = tabla.NewRow();
                fila["value"] = kvp.Key;
                fila["label"] = kvp.Value;

                tabla.Rows.Add(fila);
            }

            combo.DataSource = tabla;
            combo.DisplayMember = "label";
            combo.ValueMember = "value";

        }

      


    }
}
