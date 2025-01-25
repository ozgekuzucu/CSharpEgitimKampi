﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//CRUD--->Create-Read-Update-Delete
			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();
			#region Kategori Ekleme İşlemi
			//Console.WriteLine("---------------------------------------");
			//Console.Write("Eklemek İstediğiniz Kategori Adı: ");
			//string categoryName=Console.ReadLine();

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PUNASPD;initial catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
			//command.Parameters.AddWithValue("@p1",categoryName);
			//command.ExecuteNonQuery();//koşulsuz şekilde sorguyu çalıştır
			//connection.Close();
			//Console.Write("Kategori Eklendi");
			#endregion

			#region Ürün Ekleme İşlemi
			//string productName;
			//decimal productPrice;
			////bool productStatus;

			//Console.Write("Ürün Adı: ");
			//productName =Console.ReadLine();
			//Console.Write("Ürün Fiyatı: ");
			//productPrice=decimal.Parse(Console.ReadLine());

			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PUNASPD; initial Catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice",productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.Write("Ürün Eklendi");
			#endregion

			#region Ürün Listeleme İşlemi
			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PUNASPD; initial Catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();
			//SqlCommand command = new SqlCommand("select * from TblProduct",connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);
			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString()+" ");
			//	}
			//	Console.WriteLine();
			//}

			//connection.Close();

			#endregion

			#region Ürün Silme İşlemi
			//Console.Write("Silinecek Ürün Id: ");
			//int productId =int.Parse(Console.ReadLine());
			//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PUNASPD; initial Catalog=EgitimKampiDb;integrated security=true");
			//connection.Open();

			//SqlCommand command = new SqlCommand("delete from TblProduct where ProductId=@productId",connection);
			//command.Parameters.AddWithValue("@productId",productId);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Silme işlemi yapıldı.");



			#endregion

			#region Ürün Güncelleme İşlemi
			Console.Write("Güncellenecek Ürün Id: ");
			int productId=int.Parse(Console.ReadLine());

			Console.Write("Güncellenecek Ürün Adı: ");
			string productName = Console.ReadLine();

			Console.Write("Güncellenecek Ürün Fiyatı: ");
			decimal productPrice = decimal.Parse(Console.ReadLine());

			SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PUNASPD; initial Catalog=EgitimKampiDb;integrated security=true");
			connection.Open();
			SqlCommand command = new SqlCommand("update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
			command.Parameters.AddWithValue("@productName", productName);
			command.Parameters.AddWithValue("@productPrice",productPrice);
			command.Parameters.AddWithValue("@productId",productId);
			command.ExecuteNonQuery();

			connection.Close();
			Console.Write("Güncelleme işlemi yapıldı.");
			#endregion
			Console.Read();
		}
	}
}
