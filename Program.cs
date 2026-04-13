using System.Numerics;
using CoffeeShopSystem.Models;
using CoffeeShopSystem.Patterns;
using Microsoft.Data.SqlClient;
namespace CoffeeShopSystem;

class Program
{
    static void Main(string[] args)
    {

        //Factory Pattern
        ICoffee icoffe= CoffeeFactory.CreateCoffee("espresso");

         //Factory Pattern
        icoffe= new MilkDecorator(icoffe);
        icoffe= new SugarDecorator(icoffe);

        Console.WriteLine($"Order: {icoffe.GetDescription()}");
        Console.WriteLine($"Price: {icoffe.GetCost()}");

         //Factory Pattern
        IDiscountStrategy discount= new HappyHours();
        decimal discountedPrice= discount.ApplyDiscount(icoffe.GetCost());

        Console.WriteLine($"Total Price after applying discount is {discountedPrice: 0.00}");

         //Adapter Pattern
        IInvoiceService invoiceService= new InvoiceAdapter(new LegacyInvoiceSystem());
        Console.WriteLine(invoiceService.GenerateInvoice(discountedPrice,"Mr. Kazi"));

        try
        {
            using var connection= SqlDbConnection.instance.CreateConnection();
            connection.Open();

            //Insert
            string insertQuery= "INSERT INTO Orders(customerId,createdAt, totalAmount) OUTPUT INSERTED.Id VALUES (@cid, @date, @total);";
            using var insertCommand= new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@cid",1);
            insertCommand.Parameters.AddWithValue("@date",DateTime.Now);
            insertCommand.Parameters.AddWithValue("@total",discountedPrice);

            int newOrderId=Convert.ToInt32(insertCommand.ExecuteScalar());
            Console.WriteLine($"Order {newOrderId} inserted");

            //UPDATE
            string updateQuery= "UPDATE Orders SET totalAmount= totalAmount+10 WHERE Id =@id";
            using var updateCommand= new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@id", newOrderId);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine($"Order {newOrderId} updated");

            //GET
            string selectQuery= "SELECT Id, CustomerId, totalAmount, createdAt FROM orders";
            using var selectCommand= new SqlCommand(selectQuery,connection);
            using var reader= selectCommand.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"OrderId: {reader["Id"]} | Total: {reader["totalAmount"]} Taka | Date: {reader["createdAt"]}");
            }
        
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Database Operation Failed: {ex.Message}");
        }

    }
    
}
