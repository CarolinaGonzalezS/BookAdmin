using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.controllers
{
    public class CntClsFine
    {

        public CntClsFine() { }

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

        public int insertFine(double value, string descriptionF)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = value;
            param1.ParameterName = "value";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = descriptionF;
            param2.ParameterName = "descriptionF";
            parameters.Add(param2);

            return ejecuteNonQuery("insertFine", parameters);
        }

        public int insertFineCustomer(string identificationCard, int id, string dateF)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = identificationCard;
            param1.ParameterName = "identificationCard";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = id;
            param2.ParameterName = "id";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param2.Value = dateF;
            param2.ParameterName = "dateF";
            parameters.Add(param3);

            return ejecuteNonQuery("insertFineCustomer", parameters);
        }
    }
}