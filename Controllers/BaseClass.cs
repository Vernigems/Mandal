using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Mandal.Controllers
{
    public class BaseClass : Controller
    {
        private readonly IConfiguration _configuration;

        public BaseClass(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        private T ChangeType<T>(DataRow dataRow)
        {
            var expando = new System.Dynamic.ExpandoObject() as IDictionary<string, object>;
            foreach (DataColumn col in dataRow.Table.Columns)
            {
                expando[col.ColumnName] = dataRow[col];
            }
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(expando));
        }

        public DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }

            return table;
        }

        public List<T> ExecuteQuery<T>(CommandType commandType, string query, params (string, object?)[] parameters)
        {            
            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));
                
            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m => command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value));

            var result = new DataTable();
            var data = new SqlDataAdapter(command);
            data.Fill(result);
            
            if (result.Rows.Count > 0)
                return result.Rows.OfType<DataRow>().Select(m => ChangeType<T>(m)).ToList();

            return null;
        }

        public List<T> ExecuteNonQuery<T>(CommandType commandType, string query, params (string, object?)[] parameters)
        {

            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m => command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value));

            var result = new DataTable();
            var data = new SqlDataAdapter(command);
            data.Fill(result);
            
            if (result.Rows.Count > 0)
                return result.Rows.OfType<DataRow>().Select(m => ChangeType<T>(m)).ToList();

            return null;
        }

        public List<T> ExecuteRows<T>(CommandType commandType, string query, params (string, object?)[] parameters)
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m => command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value));

            var result = new DataTable();
            var data = new SqlDataAdapter(command);
            data.Fill(result);

            if (result.Rows.Count > 0)
            {
                var r = result.Rows.OfType<DataRow>().Select(m => ChangeType<T>(m)).ToList();
                return r;
            }

            return null;
        }

        public void ExecuteNonQuery(CommandType commandType, string query, params (string, object?)[] parameters)
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m => command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value));

            var result = new DataTable();
            var data = new SqlDataAdapter(command);
            data.Fill(result);
        }

        public T ExecuteScalar<T>(CommandType commandType, string query, params (string, object?, bool)[] parameters)
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m =>
                {
                    command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value);
                    if (m.Item3 == true)
                        command.Parameters[m.Item1].Direction = ParameterDirection.Output;
                });


            var data = new SqlDataAdapter(command);
            var result = new DataTable();
            data.Fill(result);

            if (result.Rows.Count > 0 && result.Columns.Count > 0)
            {
                var amount = result.Rows[0][0];
                return (T)Convert.ChangeType(amount, typeof(T));
            }

            return default(T);
        }


        public DataSet ExecuteDataSet(CommandType commandType, string query, params (string, object?)[] parameters)
        {
            DataSet dataSet = new DataSet();

            var connection = new SqlConnection(_configuration.GetConnectionString("DevConnectionStrings"));

            using var command = connection.CreateCommand();
            command.CommandText = query;
            command.CommandTimeout = 30;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
                parameters.ToList().ForEach(m => command.Parameters.AddWithValue(m.Item1, m.Item2 ?? DBNull.Value));

            var result = new DataSet();
            var data = new SqlDataAdapter(command);
            data.Fill(dataSet);

            return dataSet;
        }
    }
}
