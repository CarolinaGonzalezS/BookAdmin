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
    public class CntClsReturnBook
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

        public EntClsReturnBook ReturnBook(int id)
        {
            EntClsReturnBook objReturn = new EntClsReturnBook();
            string storeProcedure = "ReturnBook";
            using (DbConnection con = dpf.CreateConnection())
            {
                con.ConnectionString = constr;
                using (DbCommand cmd = dpf.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = storeProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    DbParameter param = cmd.CreateParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = "id";
                    param.Value = id;
                    cmd.Parameters.Add(param);


                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            objReturn = new EntClsReturnBook((int)dr["id"], (string)dr["identificationCard"], (string)dr["name"], (string)dr["lastName"], (string)dr["nameBook"], (string)dr["code"]);
                        }
                    }
                }
            }
            return objReturn;
        }

        public int UpdateStateLoan(int id)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            return ejecuteNonQuery("UpdateStateLoan", parameters);
        }


        public int UpdateStockBook(string code, int stock)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = code;
            param1.ParameterName = "code";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = stock;
            param2.ParameterName = "stock";
            parameters.Add(param2);

            return ejecuteNonQuery("UpdateStockBook", parameters);
        }

        public EntClsSearch searchBook(string name)
        {
            EntClsSearch objSearch = new EntClsSearch();
            string storeProcedure = "ForNameBook";
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
                    param.ParameterName = "name";
                    param.Value = name;
                    cmd.Parameters.Add(param);
                    con.Open();
                
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            objSearch = new EntClsSearch((string)dr["code"], (string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"]);

                        }

                    }
                }

            }
            return objSearch;
        }


    }


}