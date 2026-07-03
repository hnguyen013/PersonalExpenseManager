using PersonalExpenseManager.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace PersonalExpenseManager.DAL
{
    internal class TransactionDAL : ITransactionDAL
    {
        private string connectionString = "Data Source=data.db;Version=3;Foreign Keys=True;";
        private string error = "";

        public bool Create(Transaction t)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO transactions
                               (ID, Date, Type, CategoryId, Amount, Notes, BudgetId)
                               VALUES
                               (@ID, @Date, @Type, @CategoryId, @Amount, @Notes, @BudgetId)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", t.Id);
                cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Type", t.Type);
                cmd.Parameters.AddWithValue("@CategoryId", t.CategoryID);
                cmd.Parameters.AddWithValue("@Amount", t.Amount);
                cmd.Parameters.AddWithValue("@Notes", t.Notes);
                cmd.Parameters.AddWithValue("@BudgetId",
                    string.IsNullOrEmpty(t.BudgetId) ? (object)DBNull.Value : t.BudgetId);

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

        public List<Transaction> ReadAll()
        {
            List<Transaction> list = new List<Transaction>();

            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM transactions";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Transaction t = new Transaction(
                        reader["ID"].ToString(),
                        reader["Type"].ToString(),
                        reader["CategoryId"].ToString(),
                        Convert.ToDouble(reader["Amount"]),
                        Convert.ToDateTime(reader["Date"]),
                        reader["Notes"].ToString(),
                        reader["BudgetId"] == DBNull.Value ? null : reader["BudgetId"].ToString()
                    );

                    list.Add(t);
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

        public Transaction ReadById(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM transactions WHERE ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Transaction t = new Transaction(
                        reader["ID"].ToString(),
                        reader["Type"].ToString(),
                        reader["CategoryId"].ToString(),
                        Convert.ToDouble(reader["Amount"]),
                        Convert.ToDateTime(reader["Date"]),
                        reader["Notes"].ToString(),
                        reader["BudgetId"] == DBNull.Value ? null : reader["BudgetId"].ToString()
                    );

                    reader.Close();
                    return t;
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

        public bool Update(Transaction t)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"UPDATE transactions SET
                               Date = @Date,
                               Type = @Type,
                               CategoryId = @CategoryId,
                               Amount = @Amount,
                               Notes = @Notes,
                               BudgetId = @BudgetId,
                               WHERE ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", t.Id);
                cmd.Parameters.AddWithValue("@Date", t.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Type", t.Type);
                cmd.Parameters.AddWithValue("@CategoryId", t.CategoryID);
                cmd.Parameters.AddWithValue("@Amount", t.Amount);
                cmd.Parameters.AddWithValue("@Notes", t.Notes);
                cmd.Parameters.AddWithValue("@BudgetId",
                    string.IsNullOrEmpty(t.BudgetId) ? (object)DBNull.Value : t.BudgetId);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    error = "Không tìm thấy giao dịch cần sửa";
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

                string sql = "DELETE FROM transactions WHERE ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                {
                    error = "Không tìm thấy giao dịch cần xóa";
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
    }
}