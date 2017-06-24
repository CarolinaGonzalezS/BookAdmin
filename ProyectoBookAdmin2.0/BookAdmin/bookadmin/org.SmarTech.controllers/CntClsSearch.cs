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
    public class CntClsSearch
    {

        public CntClsSearch() { }
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


        public List<EntClsSearch> forNameAutorComplete(string name, string lastName)
        {
            List<EntClsSearch> booklist = new List<EntClsSearch>();
            string storeProcedure = "ForAuthorCompleteName";
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
                        while (dr.Read())
                        {
                            booklist.Add(
                                new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"])
                            );
                        }
                    }
                }
            }
            return booklist;
        }


        public List<EntClsSearch> forOnlyNameAutor(string name)
        {
            List<EntClsSearch> bookList = new List<EntClsSearch>();
            string storeProcedure = "ForNameAuthor";
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
                        while (dr.Read())
                        {
                            bookList.Add(
                                new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"])
                            );
                        }
                    }
                }
            }
            return bookList;
        }        
   
        public List<EntClsSearch> forNameEditorial(string editorial)
        {
            List<EntClsSearch> bookList = new List<EntClsSearch>();
            string storeProcedure = "ForNameEditorial";
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
                    param.Value = editorial;
                    cmd.Parameters.Add(param);

                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bookList.Add(
                                new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"])
                            );
                        }
                    }
                }
            }
            return bookList;
        }

        public List<EntClsSearch> forOnlyLastNameAutor(string lastName)
        {
            List<EntClsSearch> bookList = new List<EntClsSearch>();
            string storeProcedure = "ForLastNameAuthor";
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
                    param.ParameterName = "lastName";
                    param.Value = lastName;
                    cmd.Parameters.Add(param);

                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bookList.Add(
                                new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"])
                            );
                        }
                    }
                }
            }
            return bookList;
        }


        public EntClsSearch forCodeBook(string code)
        {
            EntClsSearch obj_search = new EntClsSearch();
            string storeProcedure = "ForCodeBook";
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
                            obj_search = new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"]);
                        }

                    }
                }

            }
            return obj_search;
        }


        public EntClsSearch forIsbnBook(string isbn)
        {
            EntClsSearch obj_search = new EntClsSearch();
            string storeProcedure = "ForIsbnBook";
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
                    param.ParameterName = "isbn";
                    param.Value = isbn;
                    cmd.Parameters.Add(param);
                    con.Open();

                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj_search = new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"]);
                        }

                    }
                }

            }
            return obj_search;
        }

        public EntClsSearch forNameBook(string name)
        {
            EntClsSearch obj_search = new EntClsSearch();
            string storeProcedure = "forNameBook";
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
                            obj_search = new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"]);
                        }

                    }
                }

            }
            return obj_search;
        }

        public List<EntClsSearch> forNameInPartBook(string lastname)
        {
            List<EntClsSearch> bookList = new List<EntClsSearch>();
            string storeProcedure = "ForLastNameAuthor";
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
                    param.ParameterName = "lastName";
                    param.Value = lastname;
                    cmd.Parameters.Add(param);
                    con.Open();
                    using (DbDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bookList.Add(
                                new EntClsSearch((string)dr["NameBook"], (string)dr["stateB"], (int)dr["stock"], (string)dr["nameEdit"], (string)dr["nameAuth"], (string)dr["lastName"])
                            );
                        }
                    }
                }
            }
            return bookList;
        }

    }
}