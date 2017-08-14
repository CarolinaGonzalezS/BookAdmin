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

        public int insertLoan(string dateLoan, string dateLimit, string identificationCard, string code, string stateL)
        {
            List<DbParameter> parameters = new List<DbParameter>();

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

            DbParameter param6 = dpf.CreateParameter();
            param6.Value = stateL;
            param6.ParameterName = "stateL";
            parameters.Add(param6);

            return ejecuteNonQuery("insertLoan", parameters);
        }

        public EntClsLoan searchLoan(int id)
        {
            EntClsLoan ent_loan = new EntClsLoan();
            string storeProcedure = "searchLoan";
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
                    param.ParameterName = "id";
                    param.Value = id;
                    cmd.Parameters.Add(param);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ent_loan = new EntClsLoan((int)dr["id"], (string)dr["stateL"]);

                        }
                    }
                }

            }
            return ent_loan;
        }

        public EntClsLoan fineLoan(int id)
        {
            EntClsLoan fineloan = new EntClsLoan();
            string storeProcedure = "fineLoan";
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
                    param.ParameterName = "id";
                    param.Value = id;
                    cmd.Parameters.Add(param);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            fineloan = new EntClsLoan((int)dr["id"], (string)dr["identificationCard"], (string)dr["dateLoan"]);

                        }
                    }
                }

            }
            return fineloan;
        }
        public List<EntClsLoan> checkForCodeLoan(string code)
        {
            List<EntClsLoan> loanList = new List<EntClsLoan>();
            string storeProcedure = "checkForCodeLoan";
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
                    param.ParameterName = "code";
                    param.Value = code;
                    cmd.Parameters.Add(param);

                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            loanList.Add(
                                new EntClsLoan((int)dr["id"], (string)dr["stateL"])
                            );
                        }
                    }
                }
            }
            return loanList;
        }

        public int deleteLoan(int id)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            return ejecuteNonQuery("deleteLoan", parameters);
        }

        
    }
}