using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data;

namespace frmmain
{
    static class Program
    {
        public static SqlConnection conn;
        public static String connString = "";
        public static SqlDataReader reader;
        public static String servername = @"MSI\TRONG";

        public static String id = "";
        public static String pw = "";

        public static String databaseName = "";

        public static String defaultPath = @"C:\BACKUP\";


        public static string DELETE_BACKUP =
                "DELETE FROM msdb.dbo.backupfile WHERE backup_set_id = {0}\n" +
                "DELETE FROM msdb.dbo.backupfilegroup WHERE backup_set_id = {0}\n" +
                "DELETE FROM msdb.dbo.backupset WHERE backup_set_id = {0}\n";


        /// <summary>
        /// {0} restore_history_id
        /// </summary>
        public static string DELETE_RESTORE_HISTORY =
            "DELETE FROM msdb.dbo.restorefile WHERE restore_history_id = {0}\n" +
            "DELETE FROM msdb.dbo.restorefilegroup WHERE restore_history_id = {0}\n" +
            "DELETE FROM msdb.dbo.restorehistory WHERE restore_history_id = {0}\n";

        public static int Connect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                return 1;
            }
            catch (Exception ex)
            {  
                return 0;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static void TryExistsConnect()
        {
            if (conn.State == ConnectionState.Closed) conn.Open();
        }

        public static SqlDataReader ExecSqlDataReader(String sql)
        {
            //conn = new SqlConnection(connectString);
            TryExistsConnect();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            //cmd.CommandTimeout = 600;
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String sql, CommandType type, SqlParameter[] parameters)
        {
            TryExistsConnect();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = type;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                reader = null;
                return null;
            }

        }

        public static int ExecSqlNonQuery(String sql, String connectString)
        {
            conn = new SqlConnection(connectString);
            TryExistsConnect();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 600;
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return ex.State;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int ExecSqlNonQuery(String sql, CommandType type, SqlParameter[] parameters)
        {
            TryExistsConnect();

            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            cmd.CommandType = type;
            // cmd.CommandTimeout = 600;
            try
            {
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable ExecSqlDataTable(String sql)
        {
            TryExistsConnect();

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
    }
}
