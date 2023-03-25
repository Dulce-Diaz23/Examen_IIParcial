using Entidads;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datoss
{
    public class TicketDB
    {
        string cadena = "server=localhost; user=root; database=Ticket; password=diaz;";

        public bool Guardar(Ticket ticket, List<DetalleTicket> detalle)
        {
            bool inserto = false;
            int idTicket = 0;

            try
            {
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append("INSERT INTO ticket (Fecha, ISV, Descuento,Total, IdentidadCliente, CodigoUsuario) VALUES (@Fecha, @ISV, @Descuento,@Total, @IdentidadCliente, @CodigoUsuario);");
                sqlTicket.Append("SELECT LAST_INSERT_ID();");

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append("INSERT INTO detalleticket (IdTicket,Articulo, TipoSoporte, Solicitud, Respuesta,Cantidad, Precio, Total)  VALUES (@IdTicket, @Articulo, @TipoSoporte, @Solicitud, @Respuesta,@Cantidad, @Precio, @Total);");



                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();

                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);


                    try
                    {
                        using (MySqlCommand cmd1 = new MySqlCommand(sqlTicket.ToString(), con, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.Date).Value = ticket.Fecha;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            cmd1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                            cmd1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                            idTicket = Convert.ToInt32(cmd1.ExecuteScalar());
                        }

                        //
                        foreach (DetalleTicket detalles in detalle)
                        {
                            using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), con, transaction))
                            {
                                cmd2.CommandType = System.Data.CommandType.Text;
                                cmd2.Parameters.Add("@IdTicket", MySqlDbType.Int32).Value = idTicket;
                                cmd2.Parameters.Add("@Articulo", MySqlDbType.VarChar, 15).Value = detalles.Articulo;
                                cmd2.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 30).Value = detalles.TipoSoporte;
                                cmd2.Parameters.Add("@Solicitud", MySqlDbType.VarChar, 45).Value = detalles.Solicitud;
                                cmd2.Parameters.Add("@Respuesta", MySqlDbType.VarChar, 45).Value = detalles.Respuesta;
                                cmd2.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = detalles.Cantidad;
                                cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalles.precio;
                                cmd2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalles.Total;
                                cmd2.ExecuteNonQuery();

                            }

                        }

                        transaction.Commit();
                        inserto = true;
                    }
                    catch (System.Exception)
                    {
                        inserto = false;
                        transaction.Rollback();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            return inserto;
        }
    }
}
