using MySql.Data.MySqlClient;
using System;
namespace ProductsApp
{
    public class DBConnection
    {
        private readonly string _connectionString;
        private readonly string _TableName;
        private readonly string _PrimaryKeyName;
        private readonly string _TimeStampName;
        public DBConnection(string connectionString, string TableName, string PrimaryKeyName, string TimeStampName)
        {
            _connectionString = connectionString;
            _TableName = TableName;
            _PrimaryKeyName = PrimaryKeyName;
            _TimeStampName = TimeStampName;
        }
        public int Count
        {
            get
            {
                int Count = -1;
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(_connectionString))
                    {
                        MySqlCommand command = new MySqlCommand($"SELECT COUNT({_PrimaryKeyName}) FROM {_TableName} ORDER BY {_PrimaryKeyName};", connection);
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Count = reader.GetInt32(0);
                        }
                        reader.Close();
                        connection.Close();
                    }
                    return Count;
                }
                catch (Exception e)
                {
                    Console.WriteLine("DBConnection Count ERROR =\n\n" + e);
                    return Count;
                }
            }
        }
        public int[] Keys
        {
            get
            {
                int[] Keys = new int[Count];
                int counter = 0;
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(_connectionString))
                    {
                        MySqlCommand command = new MySqlCommand($"SELECT {_PrimaryKeyName} FROM {_TableName} ORDER BY {_PrimaryKeyName}", connection);
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Keys[counter++] = reader.GetInt32(0);
                        }
                        reader.Close();
                        connection.Close();
                    }
                    return Keys;
                }
                catch (Exception e)
                {
                    Console.WriteLine("DBConnection Keys ERROR =\n\n" + e);
                    return Keys;
                }
            }
        }
        public bool InsertRow(int Key, string Columns = "#NoData-?", string Values = "#NoData-?")
        {
            string FColumns = "";
            string FValues = "";
            if (Columns != "#NoData-?" || Values != "#NoData-?")
            {
                FColumns = $", {Columns}";
                FValues = $", {Values}";
            }
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"INSERT INTO {_TableName} ({_PrimaryKeyName}, {_TimeStampName} {FColumns}) VALUES ({Key}, CURRENT_TIMESTAMP {FValues});", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("DBConnection InsertRow ERROR =\n\n" + e);
                    return false;
                }
            }
        }
        public bool DeleteRow(int Key)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"DELETE FROM {_TableName} WHERE {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("DBConnection DeleteRow ERROR =\n\n" + e);
                    return false;
                }
            }
        }
        public bool SetField<T>(int Key, string Colunm, T Value, bool Time = false)
        {
            string FValue = "";
            if (Value is byte || Value is short || Value is int || Value is long || Value is decimal || Value is decimal || Value is decimal)
            {
                FValue = Value.ToString();
            }
            else
            {
                FValue = $"'{Value.ToString()}'";
            }
            string FTime = "";
            if (Time)
            {
                FTime = $", {_TimeStampName} = CURRENT_TIMESTAMP";
            }
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand($"UPDATE {_TableName} SET {Colunm} = {FValue}{FTime} Where {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("DBConnection SetField ERROR =\n\n" + e);
                    return false;
                }
            }
        }
        public string GetString(int Key, string Colunm)
        {
            string Field = "#NoData-?";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    MySqlCommand command = new MySqlCommand($"SELECT {Colunm} FROM {_TableName} WHERE {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    Field = (string)command.ExecuteScalar();
                    connection.Close();
                }
                return Field;
            }
            catch (Exception e)
            {
                Console.WriteLine("DBConnection GetString ERROR =\n\n" + e);
                return Field;
            }
        }
        public int GetInt(int Key, string Colunm)
        {
            int Field = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    MySqlCommand command = new MySqlCommand($"SELECT {Colunm} FROM {_TableName} WHERE {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    Field = (int)command.ExecuteScalar();
                    connection.Close();
                }
                return Field;
            }
            catch (Exception e)
            {
                Console.WriteLine("DBConnection GetInt ERROR =\n\n" + e);
                return Field;
            }
        }
        public decimal GetDecimal(int Key, string Colunm)
        {
            Decimal Field = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    MySqlCommand command = new MySqlCommand($"SELECT {Colunm} FROM {_TableName} WHERE {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    Field = (decimal)command.ExecuteScalar();
                    connection.Close();
                }
                return Field;
            }
            catch (Exception e)
            {
                Console.WriteLine("DBConnection GetDecimal ERROR =\n\n" + e);
                return Field;
            }
        }
        public DateTime GetDateTime(int Key, string Colunm)
        {
            DateTime Field = new DateTime();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    MySqlCommand command = new MySqlCommand($"SELECT {Colunm} FROM {_TableName} WHERE {_PrimaryKeyName} = {Key};", connection);
                    connection.Open();
                    Field = (DateTime)command.ExecuteScalar();
                    connection.Close();
                }
                return Field;
            }
            catch (Exception e)
            {
                Console.WriteLine("DBConnection GetDateTime ERROR =\n\n" + e);
                return Field;
            }
        }
    }
}