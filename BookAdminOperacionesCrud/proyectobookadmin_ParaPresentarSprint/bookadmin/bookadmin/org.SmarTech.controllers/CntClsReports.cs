﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.controllers
{
    public class CntClsReports
    {
        public CntClsReports()
        {
        }

        public static string constr
        {
            get
            {
                return
                    ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            }
        }
        //proveedor quien va dar servicio

        public static string provider
        {
            get { return ConfigurationManager.ConnectionStrings["Conn"].ProviderName; }
        }

        //intermediario para realizar las consultas (para hacer conexiones)
        public static DbProviderFactory dpf
        {
            get
            {
                return DbProviderFactories.GetFactory(provider);
            }
        }

        private static int ejecuteNonQuery
            (string StoredProcedure, List<DbParameter> parametros)
        {
            int id = 0;
            try
            {
                //establece una conexion con el factory
                using (DbConnection con = dpf.CreateConnection())
                {
                    con.ConnectionString = constr;
                    //creamos un comando por el factory
                    using (DbCommand cmd = dpf.CreateCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = StoredProcedure;

                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (DbParameter param in parametros)
                        {
                            cmd.Parameters.Add(param);
                        }
                        con.Open();
                        id = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return id;
        }

        public List<EntClsReports> BookReport()
        {
            List<EntClsReports> bookreport = new List<EntClsReports>();
            string storeProcedure = "BookReport";
            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = storeProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bookreport.Add(
                                new EntClsReports(
                                    (string)dr["Codigo"], (string)dr["ISBN"],
                                    (string)dr["Titulo"], (string)dr["FechaPublicacion"],
                                    (string)dr["Editorial"], (string)dr["Nombre"],
                                    (string)dr["Apellido"], (string)dr["Categoria"],
                                    (string)dr["Estado"], (int)dr["Stock"])
                            );
                        }
                    }
                }
            }
            return bookreport;
        }

        public List<EntClsReports> CustomerReport()
        {
            List<EntClsReports> customerreport = new List<EntClsReports>();
            string storeProcedure = "CustomerReport";
            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = storeProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            customerreport.Add(
                                new EntClsReports(
                                    (string)dr["Cedula"], (string)dr["Nombre"],
                                    (string)dr["Apellido"], (string)dr["Telefono"],
                                    (string)dr["Cedula"], (string)dr["Direccion"],
                                    (string)dr["Email"])
                            );
                        }
                    }
                }
            }
            return customerreport;
        }
    }
}