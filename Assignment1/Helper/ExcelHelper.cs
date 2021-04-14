using Dapper;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace Assignment1.Helper
{
    class ExcelHelper
    {
        public static string TestDataFile(string ExcelName)
        {
            string fullpath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\TestData\" + ExcelName + ".xlsx");


            var connection = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0", fullpath);
            return connection;
        }
        public static List<T> GetTestData<T>(string excelName, string sheetName)
        {
            using (var connection = new OleDbConnection(TestDataFile(excelName)))
            {
                connection.Open();
                var query = "select * from [" + sheetName + "$]";
                var value = connection.Query<T>(query).AsList();
                connection.Close();
                return value;
            }
        }
    }
}
