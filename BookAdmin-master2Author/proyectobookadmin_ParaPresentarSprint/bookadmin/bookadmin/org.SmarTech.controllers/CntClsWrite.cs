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
    public class CntClsWrite
    {

        public CntClsWrite() 
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

        public int insertWrite(int id, string code)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = code;
            param2.ParameterName = "code";
            parameters.Add(param2);
          

            return ejecuteNonQuery("InsertWrite", parameters);
        }

        public EntClsWrite listWriteForCode(string code)
        {
            EntClsWrite objWrite = new EntClsWrite();
            string storeProcedure = "listAuthorWithBook";
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
                        if (dr.Read())
                        {
                            objWrite = new EntClsWrite((int)dr["id"]);

                        }

                    }
                }

            }
            return objWrite;
        }

        public List<EntClsWrite> SearchBookForIdAuthor(int id)
        {
            List<EntClsWrite> book_author = new List<EntClsWrite>();
            string storeProcedure = "SearchBookForIdAuthor";
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
                        while (dr.Read())
                        {
                            book_author.Add(
                                new EntClsWrite((int)dr["id"])
                            );
                        }
                    }
                }
            }
            return book_author;
        }
    }
}