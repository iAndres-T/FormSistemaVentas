﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUser)
        {
            List<Permiso> _permisos = new List<Permiso>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdRol,p.NombreMenu FROM PERMISO p");
                    query.AppendLine("INNER JOIN ROL r ON r.IdRol = p.IdRol");
                    query.AppendLine("INNER JOIN USUARIO u ON u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @idUser");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _permisos.Add(new Permiso
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    _permisos = new List<Permiso>();
                }
            }
            return _permisos;
        }
    }
}
