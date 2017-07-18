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
    public class CntClsBook
    {

        public CntClsBook() { }
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

        public EntClsBook CheckBook(string name)
        {
            EntClsBook obj_book = new EntClsBook();
            string storeProcedure = "existBook";
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
                            obj_book = new EntClsBook((string)dr["name"]);

                        }

                    }
                }

            }
            return obj_book;
        }

        public int insertBook(string name, string code, string isbn,string datePublish,int stock,int idCateg,int idEdit, string stateB, int idAdmin)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = code;
            param1.ParameterName = "code";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = isbn;
            param2.ParameterName = "isbn";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = name;
            param3.ParameterName = "name";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = datePublish;
            param4.ParameterName = "datePublish";
            parameters.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param5.Value = idEdit;
            param5.ParameterName = "idEdit";
            parameters.Add(param5);

            DbParameter param6 = dpf.CreateParameter();
            param6.Value = idCateg;
            param6.ParameterName = "idCateg";
            parameters.Add(param6);

            DbParameter param7 = dpf.CreateParameter();
            param7.Value = stateB;
            param7.ParameterName = "stateB";
            parameters.Add(param7);

            DbParameter param8 = dpf.CreateParameter();
            param8.Value = stock;
            param8.ParameterName = "stock";
            parameters.Add(param8);

            DbParameter param9 = dpf.CreateParameter();
            param9.Value = idAdmin;
            param9.ParameterName = "idAdmin";
            parameters.Add(param9);

            return ejecuteNonQuery("insertBook", parameters);
        }

        public int updateBook(string code, string isbn, string name, string datePublish, int idEdit, int idCateg, string stateB, int stock)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = code;
            param1.ParameterName = "code";
            parameters.Add(param1);

            DbParameter param2 = dpf.CreateParameter();
            param2.Value = isbn;
            param2.ParameterName = "isbn";
            parameters.Add(param2);

            DbParameter param3 = dpf.CreateParameter();
            param3.Value = name;
            param3.ParameterName = "name";
            parameters.Add(param3);

            DbParameter param4 = dpf.CreateParameter();
            param4.Value = datePublish;
            param4.ParameterName = "datePublish";
            parameters.Add(param4);

            DbParameter param5 = dpf.CreateParameter();
            param4.Value = idEdit;
            param4.ParameterName = "idEdit";
            parameters.Add(param5);

            DbParameter param6 = dpf.CreateParameter();
            param4.Value = idCateg;
            param4.ParameterName = "idCateg";
            parameters.Add(param6);

            DbParameter param7 = dpf.CreateParameter();
            param4.Value = stateB;
            param4.ParameterName = "stateB";
            parameters.Add(param7);

            DbParameter param8 = dpf.CreateParameter();
            param4.Value = stock;
            param4.ParameterName = "stock";
            parameters.Add(param8);

            return ejecuteNonQuery("updateBook", parameters);
        }

        public int deleteBook(string code)
        {
            List<DbParameter> parameters = new List<DbParameter>();

            DbParameter param1 = dpf.CreateParameter();
            param1.Value = code;
            param1.ParameterName = "code";
            parameters.Add(param1);

            return ejecuteNonQuery("deleteBook", parameters);
        }

        public List<EntClsBook> listBook() 
        {
            List<EntClsBook> booklist = new List<EntClsBook>();
            string storeProcedure = "listBook";
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
                            booklist.Add(                                
                                new EntClsBook((string)dr["code"], (string)dr["isbn"], (string)dr["name"], (string)dr["datePublish"], (int)dr["idEdit"], (int)dr["idCateg"], (int)dr["idAdmin"], (string)dr["stateB"], (int)dr["stock"])
                            );
                        }
                    }
                }
            }
            return booklist;
        }
        
        public EntClsBook CheckBook2(string name)
        {
            EntClsBook obj_book = new EntClsBook();
            string storeProcedure = "existBook";
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
                            obj_book = new EntClsBook((string)dr["name"], (string)dr["code"],(int)dr["stock"],(string)dr["stateB"]);

                        }

                    }
                }

            }
            return obj_book;
        }

        public int updateStockBook(string code, int stock)
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

            return ejecuteNonQuery("updateStockBook", parameters);
        }

    }
}