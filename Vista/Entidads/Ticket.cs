using System;

namespace Entidads
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string IdentidadCliente { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal Descuento { get; set; }
        public decimal ISV { get; set; }
        public decimal Total { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, DateTime fecha, string identidadCliente, string codigoUsuario, decimal descuento, decimal iSV, decimal total)
        {
            Id = id;
            Fecha = fecha;
            IdentidadCliente = identidadCliente;
            CodigoUsuario = codigoUsuario;
            Descuento = descuento;
            ISV = iSV;
            Total = total;
        }
    }


}
