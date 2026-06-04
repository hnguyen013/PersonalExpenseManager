using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseManager.Entity;
using System.Data.SQLite;

namespace PersonalExpenseManager.DAL
{
    internal class CategoryDAL : ICategoryDAL
    {
        private string connectionString = "Data Source=data.db;Version=3;";
        private string error = "";

        public string GetError()
        {
            return error;
        }

        public List<Category> ReadAll()
        {
            List<Category> list = new List<Category>();
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM categories";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category c = new Category();
                    c.Id = reader["id"].ToString();
                    c.Name = reader["name"].ToString();
                    c.Type = reader["type"].ToString();
                    c.Description = reader["description"].ToString();
                    c.Icon = reader["icon"].ToString();

                    list.Add(c);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return list;
        }

        public bool Create(Category c)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO categories(id, name, type, description, icon) VALUES(@id, @name, @type, @description, @icon)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@type", c.Type);
                cmd.Parameters.AddWithValue("@description", c.Description);
                cmd.Parameters.AddWithValue("@icon", c.Icon);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Update(Category c)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE categories SET name=@name, type=@type, description=@description, icon=@icon WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@type", c.Type);
                cmd.Parameters.AddWithValue("@description", c.Description);
                cmd.Parameters.AddWithValue("@icon", c.Icon);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Delete(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM categories WHERE id=@id";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public string GenerateID()
        {
            string id = "CAT001";
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT id FROM categories ORDER BY id DESC LIMIT 1";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString();
                    int number = int.Parse(lastID.Substring(3));
                    number++;

                    id = "CAT" + number.ToString("D3");
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return id;
        }
    }
}