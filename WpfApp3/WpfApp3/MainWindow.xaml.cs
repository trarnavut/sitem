using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private readonly string _connectionString = "Server=8ex2x.h.filess.io;Port=3307;Database=LibraryManagement_arrangegot;User Id=LibraryManagement_arrangegot;Password=94fc6b21caeb5ef18247c00f4b4f3fbaa6f0f9c6;";
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LoadUsersFromDatabase();
        }

        private void LoadUsersFromDatabase()
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    string query = "SELECT Id, Name, Email, Phone FROM Users";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            Users.Clear();
                            while (reader.Read())
                            {
                                Users.Add(new User
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                    Email = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtPhone.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    string query = "INSERT INTO Users (Name, Email, Phone, IsAdmin, Password) VALUES (@Name, @Email, @Phone, 1, 1)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", TxtName.Text);
                        command.Parameters.AddWithValue("@Email", TxtEmail.Text);
                        command.Parameters.AddWithValue("@Phone", TxtPhone.Text);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("User added successfully.");
                        LoadUsersFromDatabase();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }

        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            if (UserDataGrid.SelectedItem is User selectedUser)
            {
                try
                {
                    using (var connection = new MySqlConnection(_connectionString))
                    {
                        string query = "UPDATE Users SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", selectedUser.Id);
                            command.Parameters.AddWithValue("@Name", TxtName.Text);
                            command.Parameters.AddWithValue("@Email", TxtEmail.Text);
                            command.Parameters.AddWithValue("@Phone", TxtPhone.Text);

                            connection.Open();
                            command.ExecuteNonQuery();

                            MessageBox.Show("User updated successfully.");
                            LoadUsersFromDatabase();
                            ClearForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (UserDataGrid.SelectedItem is User selectedUser)
            {
                try
                {
                    using (var connection = new MySqlConnection(_connectionString))
                    {
                        string query = "DELETE FROM Users WHERE Id = @Id";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", selectedUser.Id);
                            connection.Open();
                            command.ExecuteNonQuery();

                            MessageBox.Show("User deleted successfully.");
                            LoadUsersFromDatabase();
                            ClearForm();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ClearForm()
        {
            TxtName.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
