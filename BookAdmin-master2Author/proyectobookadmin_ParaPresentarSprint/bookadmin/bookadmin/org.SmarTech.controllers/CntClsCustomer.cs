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
    public class CntClsCustomer
    {
        public CntClsCustomer() { }
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

        public int registerCustomer(string identificationCard, string name, string lastname, string phone, string celphone, string addres, string mail)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = identificationCard;
            param1.ParameterName = "identificationCard";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = name;
            param2.ParameterName = "name";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = lastname;
            param3.ParameterName = "lastname";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = phone;
            param4.ParameterName = "phone";
            parameters.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = celphone;
            param5.ParameterName = "celphone";
            parameters.Add(param5);

            DbParameter param6 = dpf.CreateParameter();
            param6.Value = addres;
            param6.ParameterName = "addres";
            parameters.Add(param6);

            DbParameter param7 = dpf.CreateParameter();
            param7.Value = mail;
            param7.ParameterName = "mail";
            parameters.Add(param7);

            return ejecuteNonQuery("RegisterCustomer", parameters);
        }


        public EntClsCustomer CustomerSearch(string identificationCard)
        {
            EntClsCustomer ent_customer = new EntClsCustomer();
            string storeProcedure = "CustomerSearch";
            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = storeProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DbParameter param = cmd.CreateParameter();
                    param.DbType = DbType.String;
                    param.ParameterName = "identificationCard";
                    param.Value = identificationCard;
                    cmd.Parameters.Add(param);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ent_customer = new EntClsCustomer((string)dr["identificationCard"], (string)dr["name"], (string)dr["lastname"], (string)dr["phone"], (string)dr["celphone"], (string)dr["addres"], (string)dr["mail"]);

                        }

                    }
                }

            }
            return ent_customer;
        }
        
    }


}