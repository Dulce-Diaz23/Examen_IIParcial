namespace Entidads
{
    public class DetalleTicket
    {
        public string Id { get; set; }
        public string Articulo { get; set; }
        public string TipoSoporte { get; set; }
        public string Solicitud { get; set; }
        public string Respuesta { get; set; }
        public int Cantidad { get; set; }
        public decimal precio { get; set; }
        public int IdTicket { get; set; }
        public decimal Total { get; set; }

        public DetalleTicket()
        {
        }

        public DetalleTicket(string id, string articulo, string tipoSoporte, string solicitud, string respuesta, int cantidad, decimal precio, int idTicket, decimal total)
        {
            Id = id;
            Articulo = articulo;
            TipoSoporte = tipoSoporte;
            Solicitud = solicitud;
            Respuesta = respuesta;
            Cantidad = cantidad;
            this.precio = precio;
            IdTicket = idTicket;
            Total = total;
        }
    }
}
