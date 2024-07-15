using ContactsApp.connectionClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.connectionClasses
{
    internal class Contact
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
    }
}

internal class ContactController
{
    static string myConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

    public DataTable Select()
    {
        DataTable table = new DataTable();
        using (SqlConnection connection = new SqlConnection(myConnectionString))
        {
            string sql = "SELECT * FROM Contacts";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(table);
        }
        return table;
    }

    public bool Insert(string name, string phone, string email, string address, string town)
    {
        bool isSuccessful = false;
        using (SqlConnection connection = new SqlConnection(myConnectionString))
        {
            string sql = "INSERT INTO Contacts (name, phone, email, address, town) VALUES (@name, @phone, @email, @address, @town)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@town", town);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            isSuccessful = rows > 0;
        }
        return isSuccessful;
    }

    public bool Update(string name, string phone, string email, string address, string town, int id)
    {
        bool isSuccessful = false;
        using (SqlConnection connection = new SqlConnection(myConnectionString))
        {
            string sql = "UPDATE Contacts SET name=@name, phone=@phone, email=@email, address=@address, town=@town WHERE id=@id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@town", town);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            isSuccessful = rows > 0;
        }
        return isSuccessful;
    }

    public bool Delete(int id)
    {
        bool isSuccessful = false;
        using (SqlConnection connection = new SqlConnection(myConnectionString))
        {
            string sql = "DELETE FROM Contacts WHERE id=@id";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            isSuccessful = rows > 0;
        }
        return isSuccessful;
    }

    public DataTable Search(string keyword)
    {        
        SqlConnection conn = new SqlConnection(myConnectionString);
        SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Contacts WHERE name LIKE '%" + keyword + "%' OR phone LIKE '%" + keyword + "%' OR address LIKE '%" + keyword + "%' OR town LIKE '%" + keyword + "%'", conn);
        DataTable table = new DataTable();
        sqlData.Fill(table);
        return table;
    }
}

