
namespace Adquisiciones.Data.Auxiliares
{
    public class ReporteTabla
    {
        private int _claveArticulo;
        private string _descProveedor;
        private decimal _precioUnitario;
        private decimal _total;
        private string _marca;
        private decimal? _porcentaje;
        private string _observaciones;

        public ReporteTabla()
        {
        }

        public ReporteTabla(
            int claveArticulo,
            string descProveedor, 
            decimal precioUnitario,
            decimal total,
            string marca,
            decimal? porcentaje, string observaciones)
        {
            _claveArticulo = claveArticulo;
            _descProveedor = descProveedor;
            _precioUnitario = precioUnitario;
            _total = total;
            _marca = marca;
            _porcentaje = porcentaje;
            _observaciones = observaciones;
        }

        public virtual int ClaveArticulo
        {
            get { return _claveArticulo; }
            set { _claveArticulo = value; }
        }

        public virtual string DescProveedor
        {
            get { return _descProveedor; }
            set { _descProveedor = value; }
        }

        public virtual decimal PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        public virtual decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public virtual string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public virtual decimal? Porcentaje
        {
            get { return _porcentaje; }
            set { _porcentaje = value; }
        }

        public virtual string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
    }




}
