using WPF_labs.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;



namespace WPF_labs.Data;

public class DatabaseHelper
{
    private string connectionString = "Server=localhost;Database=WPFLabs_DB;User Id=root;Password=;";

    public List<TaskModel> GetTasks()
    {
        var tasks = new List<TaskModel>();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Name, Description, Status, Category, UsrID FROM Task"; 
            MySqlCommand command = new MySqlCommand(query, connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var task = new TaskModel
                    {
                        UsrID = (int)reader["UsrID"],
                        TaskName = reader["Name"].ToString(),
                        TaskDescription = reader["Description"].ToString(),
                        TaskStatus = (int)reader["Status"],
                        Category = reader["Category"].ToString()
                    };
                    tasks.Add(task);
                }
            }
        }

        return tasks;
    }
}