using Adquisiciones.Business.Audit;
using Adquisiciones.Data.Entities;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.Catalogos;

namespace Adquisiciones.Business.ModAnexo
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAnexoService
    
    {
        ///<summary>
        ///</summary>
        IAnexoDao AnexoDao
        {
            get;
            set;
        }
        ///<summary>
        ///</summary>
        IArticuloDao ArticuloDao
        {
            get;
            set;
        }       

        ///<summary>
        ///</summary>
        ///<param name="combo"></param>
        void TiposLicitacionesCombo(ComboBox combo);
        ///<summary>
        ///</summary>
        ///<param name="combo"></param>
        void IvasCombo(ComboBox combo);
        ///<summary>
        ///</summary>
        ///<param name="combo"></param>
        void InstitutosCombo(ComboBox combo);

        ///<summary>
        ///</summary>
        ///<param name="anexo"></param>
        void GuardarAnexo(ref Anexo anexo);
        ///<summary>
        ///</summary>
        ///<param name="numAnexo"></param>
        ///<param name="idAlmacen"></param>
        ///<returns></returns>
        Anexo ConsultarAnexo(string numAnexo, Almacen almacen);

    }
}
