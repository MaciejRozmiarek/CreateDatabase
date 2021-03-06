﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CreateDatabase
{
    class MySqlDatabase
    {

        public MySqlConnection connection;
        public bool connectionStatus = false;
        //string connectionString = "SERVER=localhost;DATABASE=mysql;UID=root;PASSWORD=;";
        //string connectionString = "SERVER=localhost;UID=root;PASSWORD=;";
        public bool OpenConnection(string ConnectionString)
        {
            string connectionString = ConnectionString;
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                this.connectionStatus = true;
                return true;

            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.

                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        this.connectionStatus = false;
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        this.connectionStatus = false;
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                this.connectionStatus = false;
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                this.connectionStatus = false;
                return false;
            }
        }
        public bool insertToDB(string Query)
        {
            
            string query = Query;
            if (connectionStatus == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command

                    //dodac try cach dla duplikatow i bledow
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();

                    return true;
                }
                catch (Exception exc)
                {

                    return false;
                }


                //close connection


            }
            else
            {
                return false;
            }
            
           
        }

        public DataSet getDataSet(string Command)
        {
            string sqlCmd = Command;
            DataSet DS = new DataSet();
            //DS = null; 
            if (connectionStatus == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlCmd, connection);
                    cmd.CommandType = CommandType.Text;
                    // MySqlDataReader rdr = cmd.ExecuteReader();

                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlCmd, connection);

                    mySqlDataAdapter.Fill(DS);
                    mySqlDataAdapter.Dispose();
                }
                catch (Exception ex)
                {

                    DataTable dt = new DataTable("MyTable");

                    dt.Columns.Add(new DataColumn("Błąd", typeof(string)));

                    DataRow dr = dt.NewRow();

                    dr["Błąd"] = ex;
                    dt.Rows.Add(dr);
                    DS.Tables.Add(dt);
                }


            }
            return DS;

        }
        
    }
}
