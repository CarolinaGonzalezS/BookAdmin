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
    public class CntClsAuthor
    {

        public CntClsAuthor() { }

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

        public EntClsAuthor CheckAuthor(string name, string lastName)
        {
            EntClsAuthor obj_author = new EntClsAuthor();
            string storeProcedure = "existAuthor";
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

                    DbParameter param1 = cmd.CreateParameter();
                    param1.DbType = DbType.String;
                    param1.ParameterName = "lastName";
                    param1.Value = lastName;
                    cmd.Parameters.Add(param1);

                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj_author = new EntClsAuthor((int)dr["id"], (string)dr["name"], (string)dr["lastName"], (string)dr["nationality"]);

                        }

                    }
                }

            }
            return obj_author;
        }

        public int insertAuthor(string name, string lastName, string nationality)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = name;
            param1.ParameterName = "name";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = lastName;
            param2.ParameterName = "lastName";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = nationality;
            param3.ParameterName = "nationality";
            parameters.Add(param3);


            return ejecuteNonQuery("insertAuthor", parameters);
        }

        public List<EntClsAuthor> AuthorList()
        {
            List<EntClsAuthor> authorlist = new List<EntClsAuthor>();
            string storeProcedure = "AuthorList";
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
                            authorlist.Add(
                                new EntClsAuthor((int)dr["id"], (string)dr["name"], (string)dr["lastName"], (string)dr["nationality"])
                            );
                        }
                    }
                }
            }
            return authorlist;
        }

        public int updateAuthor(int id, string name, string lastName, string nationality)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = name;
            param2.ParameterName = "name";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = lastName;
            param3.ParameterName = "lastName";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = nationality;
            param4.ParameterName = "nationality";
            parameters.Add(param4);

            return ejecuteNonQuery("updateAuthor", parameters);
        }

        public EntClsAuthor CheckAuthorForId(int id)
        {
            EntClsAuthor obj_author = new EntClsAuthor();
            string storeProcedure = "AuthorforId";
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
                            obj_author = new EntClsAuthor((string)dr["name"], (string)dr["lastName"], (string)dr["nationality"]);

                        }

                    }
                }

            }
            return obj_author;
        }

        public int deleteAuthor(int id)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = id;
            param1.ParameterName = "id";
            parameters.Add(param1);

            return ejecuteNonQuery("deleteAuthor", parameters);
        }


    }
}