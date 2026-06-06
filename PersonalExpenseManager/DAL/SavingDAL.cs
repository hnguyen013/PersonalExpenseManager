using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalExpenseManager.Entity;
using System.Data.SQLite;

namespace PersonalExpenseManager.DAL
{
    internal class SavingDAL : ISavingDAL
    {
        private string connectionString = "Data Source=data.db;Version=3;";
        private string error = "";

        public bool Create(Saving s)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"INSERT INTO savings
                               (ID, GoalName, TargetAmount, SavedAmount, TargetDate, Notes, Status)
                               VALUES
                               (@ID, @GoalName, @TargetAmount, @SavedAmount, @TargetDate, @Notes, @Status)";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", s.Id);
                cmd.Parameters.AddWithValue("@GoalName", s.GoalName);
                cmd.Parameters.AddWithValue("@TargetAmount", s.TargetAmount);
                cmd.Parameters.AddWithValue("@SavedAmount", s.SavedAmount);
                cmd.Parameters.AddWithValue("@TargetDate", s.TargetDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Notes", s.Notes);
                cmd.Parameters.AddWithValue("@Status", s.Status);

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

        public List<Saving> ReadAll()
        {
            List<Saving> list = new List<Saving>();
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM savings";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Saving s = new Saving(
                        reader["ID"].ToString(),
                        reader["GoalName"].ToString(),
                        Convert.ToDouble(reader["TargetAmount"]),
                        Convert.ToDouble(reader["SavedAmount"]),
                        Convert.ToDateTime(reader["TargetDate"]),
                        reader["Notes"].ToString(),
                        reader["Status"].ToString()
                    );

                    list.Add(s);
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

        public Saving ReadById(string id)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM savings WHERE ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Saving s = new Saving(
                        reader["ID"].ToString(),
                        reader["GoalName"].ToString(),
                        Convert.ToDouble(reader["TargetAmount"]),
                        Convert.ToDouble(reader["SavedAmount"]),
                        Convert.ToDateTime(reader["TargetDate"]),
                        reader["Notes"].ToString(),
                        reader["Status"].ToString()
                    );

                    reader.Close();
                    return s;
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

        public bool Update(Saving s)
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"UPDATE savings SET
                               GoalName = @GoalName,
                               TargetAmount = @TargetAmount,
                               SavedAmount = @SavedAmount,
                               TargetDate = @TargetDate,
                               Notes = @Notes,
                               Status = @Status
                               WHERE ID = @ID";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", s.Id);
                cmd.Parameters.AddWithValue("@GoalName", s.GoalName);
                cmd.Parameters.AddWithValue("@TargetAmount", s.TargetAmount);
                cmd.Parameters.AddWithValue("@SavedAmount", s.SavedAmount);
                cmd.Parameters.AddWithValue("@TargetDate", s.TargetDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Notes", s.Notes);
                cmd.Parameters.AddWithValue("@Status", s.Status);

                return cmd.ExecuteNonQuery() > 0;
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

                string sql = "DELETE FROM savings WHERE ID = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                return cmd.ExecuteNonQuery() > 0;
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

        public string GetNextId()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT ID FROM savings ORDER BY ID DESC LIMIT 1";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                object result = cmd.ExecuteScalar();

                if (result == null)
                    return "S001";

                string lastId = result.ToString();
                int number = int.Parse(lastId.Substring(1));
                number++;

                return "S" + number.ToString("D3");
            }
            catch
            {
                return "S001";
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
