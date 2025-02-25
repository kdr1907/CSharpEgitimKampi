using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete
            
            
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");
            #region kategori ekleme işlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection=new SqlConnection("Data Source=------------;initial catalog=-----------;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = ----------;initial catalog=----------------;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılırı!");




            #endregion

            #region ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source = ------------;initial catalog=----------;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) 
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();

            //} 


            //connection.Close();



            #endregion

            #region ürün silme işlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());





            //SqlConnection connection = new SqlConnection("Data Source=-------------;initial Catalog=----------;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla silindi.");




            #endregion

            #region ürün güncelleme işlmei

            //SqlConnection connection = new SqlConnection("Data Source=------------;initial Catalog=-------------;integrated security=true");
            //connection.Open();

            //Console.Write("Güncellenecek ürün id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@p1,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@productprice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();





            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı");







            #endregion

            Console.Read();
        }   
    }
}
