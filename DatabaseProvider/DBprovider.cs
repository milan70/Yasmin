using System;
using System.Collections.Generic;
//using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace DatabaseProvider
{
    public class DBprovider
    {
        //private string _connString;
        //private SQLiteConnection _connection = null;

        //public DBprovider()
        //{
        //    _connString = "Data Source=AVTestDb.s3db";
        //}

        //public string ConnectioString { get; set; }
        
        //public int ExecuteNonQuery(string sql)
        //{
        //    int result = 0;

        //    try
        //    {
        //       _connection = new SQLiteConnection(_connString);
        //        _connection.Open();

        //        var myCommand = new SQLiteCommand(_connection);
        //        myCommand.CommandText = sql;  

        //       result = myCommand.ExecuteNonQuery();  

        //       _connection.Close();  
        //    }
        //    catch (Exception)
        //    {
                    
        //        throw;
        //    }
        //    return result;
        //}

        //public DataTable ExecuteQuery(string sql)
        //{
        //    DataTable result = null;

        //    try
        //    {
        //        _connection = new SQLiteConnection(_connString);
        //        _connection.Open();

        //        var mycommand = new SQLiteCommand(_connection);
        //        mycommand.CommandText = sql;

        //        SQLiteDataReader reader = mycommand.ExecuteReader();
        //        result.Load(reader);

        //        reader.Close();
        //        _connection.Close();  
        //    }
        //    catch (Exception e)
        //    {
        //           Console.WriteLine("Exception while reading");
        //    }
        //    return result;
        //}

        


    }
}
