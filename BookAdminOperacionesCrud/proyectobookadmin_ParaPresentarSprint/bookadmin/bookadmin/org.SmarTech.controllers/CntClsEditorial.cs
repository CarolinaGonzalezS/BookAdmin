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
    public class CntClsEditorial
    {

        public CntClsEditorial() { }
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


        public EntClsEditorial CheckEditorial(string name)
        {
            EntClsEditorial obj_edit = new EntClsEditorial();
            string storeProcedure = "existEditorial";
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
                            obj_edit = new EntClsEditorial((int)dr["id"], (string)dr["name"], (string)dr["country"], (string)dr["city"]);

                        }

                    }
                }

            }
            return obj_edit;
        }

        public int insertEditorial(string name, string country, string city)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = name;
            param1.ParameterName = "name";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = country;
            param2.ParameterName = "country";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = city;
            param3.ParameterName = "city";
            parameters.Add(param3);


            return ejecuteNonQuery("insertEditorial", parameters);
        }

        public List<EntClsEditorial> EditorialList()
        {
            List<EntClsEditorial> editoriallist = new List<EntClsEditorial>();
            string storeProcedure = "EditorialList";
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
                            editoriallist.Add(
                                new EntClsEditorial((int)dr["id"], (string)dr["name"], (string)dr["country"], (string)dr["city"])
                            );
                        }
                    }
                }
            }
            return editoriallist;
        }

        public int updateEditorial(int id, string name, string country, string city)
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
            param3.Value = country;
            param3.ParameterName = "country";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = city;
            param4.ParameterName = "city";
            parameters.Add(param4);

            return ejecuteNonQuery("updateEditorial", parameters);
        }


        public EntClsEditorial listEditorialForid(int id)
        {
            EntClsEditorial objEditorial = new EntClsEditorial();
            string storeProcedure = "checkEditorialId";
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
                            objEditorial = new EntClsEditorial((string)dr["name"], (string)dr["country"], (string)dr["city"]);

                        }

                    }
                }

            }
            return objEditorial;
        }
    }
}