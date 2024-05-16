using System.Collections.Generic;
using System.Data.SqlClient;

namespace _1_AdoNet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("sql server hoş geldiniz");

			//DataProvider
			//,=> sql server => System.Data.SqlClie


			//DataProvider Connection 
			SqlConnection sqlConnection = new SqlConnection();
			//Sql aç
			sqlConnection.ConnectionString = @"Server=ANK3-YZLMORT-14\MSSQLSERVERANK16;Database=NorthWind-Furkan;Trusted_Connection=true;";
			sqlConnection.Open();

			//Dataprovider Command
			SqlCommand sqlSelectCommand = new SqlCommand();
			sqlSelectCommand.CommandText = "select * from dbo.Employees;";
			sqlSelectCommand.Connection = sqlConnection;
			//Dataprovider Reader
			SqlDataReader reader = sqlSelectCommand.ExecuteReader();

			int counter = 0;

			while (reader.Read())
			{
				Console.WriteLine(reader[0] + " " + reader["Title"] + "" + reader[2]);
				counter++;
			}
			Console.WriteLine($"--------Satır Sayısı : {counter}---------");
			//Insert Command for Categories

		
			Console.Write("Yeni Kategori Adı");
			string categoryName = Console.ReadLine();

			Console.Write("Yeni Descprition Adı");
			string categoryDesc = Console.ReadLine();

			string insertSqlCommand = $"INSERT INTO dbo.Categories(CategoryName, Description) VALUES('{categoryName}','{categoryDesc}')";






			sqlConnection.Close();
			Console.ReadLine();
		}


	}
}
