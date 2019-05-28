using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Dapper;

namespace DiceGame
{
    public partial class Players : Form
    {

        
        SQLiteCommand sqlcmd;
        SQLiteDataReader Reader;

        int id = 0;
        public Players()
        {
            InitializeComponent();
            LoadPlayers();
        }
        
        private void LoadPlayers()
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
            {
                using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                {
                    sqlcon.Open();
                    DataTable dt = new DataTable();
                    string sql = @"Select Id,PlayerName from Players";
                    sqlcmd.CommandText = sql;
                    Reader = sqlcmd.ExecuteReader();
                    dt.Load(Reader);
                    dataGridView1.DataSource = dt;
                    sqlcon.Close();
                }
            }
        }

        private void CleanUp()
        {
            id = 0;
            txtPlayerName.Text = "";
        }

        private void btnCreatePlayer(object sender, EventArgs e)
        {//Insert a new player if it does not exist into a local db
            if (!String.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
                {
                    using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                    {
                        sqlcon.Open();
                        string sql = @"
                        Insert into Players(PlayerName) values (@name);";
                        //Insert into PlayerHistory(PlayerID) Select Max(id) from Players;
                        sqlcmd.CommandText = sql;
                        sqlcmd.Parameters.AddWithValue("@name", txtPlayerName.Text);
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Dispose();
                        sqlcon.Close();
                    }
                }
                LoadPlayers();
                CleanUp();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtPlayerName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();                
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                (new Game(id)).Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Please Select a player below to start a game or to pick up where you left off.";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
                {
                    using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                    {
                        sqlcon.Open();
                        string sql = @"delete from PlayerHistory where PlayerID = @ID;";
                        sqlcmd.CommandText = sql;
                        sqlcmd.Parameters.AddWithValue("@ID", id);
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Dispose();
                        sqlcon.Close();
                    }
                }            
                LoadPlayers();
                CleanUp();
            }
            else
            {
                lblError.Text = "Please Select a player below to start a game or to pick up where you left off.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
                {
                    using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                    {
                        sqlcon.Open();
                        string sql = @"delete from PlayerHistory where PlayerID = @ID; delete from Players where Id = @id";
                        sqlcmd.CommandText = sql;
                        sqlcmd.Parameters.AddWithValue("@id", id);
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Dispose();
                        sqlcon.Close();
                    }
                }
                LoadPlayers();
                CleanUp();
            }
            else
            {
                lblError.Text = "Please Select a player below to start a game or to pick up where you left off.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
                {
                    using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                    {
                        sqlcon.Open();
                        string sql = @"update Players set PlayerName = @name where ID = @ID;";
                        sqlcmd.CommandText = sql;
                        sqlcmd.Parameters.AddWithValue("@ID", id);
                        sqlcmd.Parameters.AddWithValue("@name", txtPlayerName.Text);
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Dispose();
                        sqlcon.Close();
                    }
                }
                LoadPlayers();
                CleanUp();
            }
            else
            {
                lblError.Text = "Please Select a player below to start a game or to pick up where you left off.";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
