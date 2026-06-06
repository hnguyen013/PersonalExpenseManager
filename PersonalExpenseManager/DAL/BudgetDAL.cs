using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseManager.Entity;
using System.Data.SQLite;

namespace PersonalExpenseManager.DAL
{
    internal class BudgetDAL : IBudgetDAL
    {
        private string connectionString = "Data Source=data.db;Version=3;";
        private string error = "";

        public bool Create(Budget b)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO budgets
                               (ID, BudgetName, Category, BudgetAmount, Spent, Period)
                               VALUES
                               (@ID, @BudgetName, @Category, @BudgetAmount, @Spent, @Period)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", b.Id);
                cmd.Parameters.AddWithValue("@BudgetName", b.BudgetName);
                cmd.Parameters.AddWithValue("@Category", b.Category);
                cmd.Parameters.AddWithValue("@BudgetAmount", b.BudgetAmount);
                cmd.Parameters.AddWithValue("@Spent", b.Spent);
                cmd.Parameters.AddWithValue("@Period", b.Period);

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

        public List<Budget> ReadAll()
        {
            List<Budget> list = new List<Budget>();
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM budgets";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Budget b = new Budget(
                        reader["ID"].ToString(),
                        reader["BudgetName"].ToString(),
                        reader["Category"].ToString(),
                        Convert.ToDouble(reader["BudgetAmount"]),
                        Convert.ToDouble(reader["Spent"]),
                        reader["Period"].ToString()
                    );

                    list.Add(b);
                }

                reader.Close();
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

        public Budget ReadById(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM budgets WHERE ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Budget b = new Budget(
                        reader["ID"].ToString(),
                        reader["BudgetName"].ToString(),
                        reader["Category"].ToString(),
                        Convert.ToDouble(reader["BudgetAmount"]),
                        Convert.ToDouble(reader["Spent"]),
                        reader["Period"].ToString()
                    );

                    reader.Close();
                    return b;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public bool Update(Budget b)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"UPDATE budgets SET
                               BudgetName = @BudgetName,
                               Category = @Category,
                               BudgetAmount = @BudgetAmount,
                               Spent = @Spent,
                               Period = @Period
                               WHERE ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", b.Id);
                cmd.Parameters.AddWithValue("@BudgetName", b.BudgetName);
                cmd.Parameters.AddWithValue("@Category", b.Category);
                cmd.Parameters.AddWithValue("@BudgetAmount", b.BudgetAmount);
                cmd.Parameters.AddWithValue("@Spent", b.Spent);
                cmd.Parameters.AddWithValue("@Period", b.Period);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    error = "Không tìm thấy budget cần sửa";
                    return false;
                }

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

        public bool DeleteById(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM budgets WHERE ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    error = "Không tìm thấy budget cần xóa";
                    return false;
                }

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

        public bool ResetSpent(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "UPDATE budgets SET Spent = 0 WHERE ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    error = "Không tìm thấy budget cần reset";
                    return false;
                }

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

        public string GetError()
        {
            return error;
        }
        public string GetNextId()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT ID FROM budgets ORDER BY ID DESC LIMIT 1";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    return "B001";
                }

                string lastId = result.ToString(); // ví dụ B005
                int number = int.Parse(lastId.Substring(1)); // lấy 005
                number++;

                return "B" + number.ToString("D3");
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return "B001";
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
