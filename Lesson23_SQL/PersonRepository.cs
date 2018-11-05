using Lesson21_DesignPatterns.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lesson23_SQL
{
    public class PersonRepository : IRepository<Person>
    {
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VcsDb";

        public Person Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM Persons WHERE ID = @ID", connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", id));
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return new Person
                            {
                                Id = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirtName = reader.GetString(2),
                                Age = reader.GetInt32(3)
                            };
                        }
                    }
                    return null;
                }
            }
        }

        public List<Person> GetAll()
        {
            var result = new List<Person>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT * FROM Persons", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Person
                            {
                                Id = reader.GetInt32(0),
                                LastName = reader.GetString(1),
                                FirtName = reader.GetString(2),
                                Age = reader.GetInt32(3)
                            });
                        }

                    }
                    return result;
                }
            }
        }

        public void Update(Person item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "UPDATE Persons SET " +
                    "LastName = @lastName, FirstName = @firstName, Age = @age " +
                    "WHERE ID=@id", connection))
                {
                    command.Parameters.Add(new SqlParameter("lastName", item.LastName));
                    command.Parameters.Add(new SqlParameter("firstName", item.FirtName));
                    command.Parameters.Add(new SqlParameter("age", item.Age));
                    command.Parameters.Add(new SqlParameter("id", item.Id));
                    command.ExecuteReader();
                }
            }
        }

        public void Add(Person item)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO Persons (LastName,FirstName,Age) " +
                    "VALUES(@lastName, @firstName, @age)", connection))
                {
                    command.Parameters.Add(new SqlParameter("lastName", item.LastName));
                    command.Parameters.Add(new SqlParameter("firstName", item.FirtName));
                    command.Parameters.Add(new SqlParameter("age", item.Age));
                    command.ExecuteReader();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(
                    "DELETE FROM Persons WHERE ID = @ID", connection))
                {
                    command.Parameters.Add(new SqlParameter("ID", id));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
