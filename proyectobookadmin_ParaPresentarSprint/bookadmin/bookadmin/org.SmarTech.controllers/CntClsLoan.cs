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
    public class CntClsLoan
    {
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

        public int insertLoan(int id, string dateLoan, string dateLimit, string identificationCard, string code)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = dateLoan;
            param2.ParameterName = "dateLoan";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = dateLimit;
            param3.ParameterName = "dateLimit";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = identificationCard;
            param4.ParameterName = "identificationCard";
            parameters.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = code;
            param5.ParameterName = "code";
            parameters.Add(param5);
             
            return ejecuteNonQuery("insertLoan", parameters);
        }
    }
}