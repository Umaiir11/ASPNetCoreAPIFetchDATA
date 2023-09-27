using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using WebApplication3.ConnectionString;
using WebApplication3.Model;

public class UserDataAccess
{
    public List<ModUser> GetAllUsers()
    {
        List<ModUser> users = new List<ModUser>();

        // Use the connection string directly from the static property
        string connectionString = ConnectionString.Pr_DbConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM User";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ModUser user = new ModUser
                        {
                            Pr_id = Convert.ToInt32(reader["ID"]),
                            Pr_Name = reader["FirstName"].ToString(),
                            Pr_Address = reader["Address"].ToString(),
                            // Map other properties here
                        };

                        users.Add(user);
                    }
                }
            }
        }

        return users;
    }
}
