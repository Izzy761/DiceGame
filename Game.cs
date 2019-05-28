using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace DiceGame
{
    public partial class Game : Form
    {
        SQLiteCommand sqlcmd;
        SQLiteDataReader Reader;
        int PlayerID = 0;
        int point = 0;
        public Game(int ID)
        {
            InitializeComponent();
            PlayerID = ID;
            LoadData();
        }
        private void ClearDice()
        {
            point = 0;
            //txtRoll.Text = "";
            //txtTotal.Text = "";
        }
        private void LoadData()
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
            {
                using (SQLiteCommand sqlcmd = sqlcon.CreateCommand())
                {
                    sqlcon.Open();
                    DataTable dt = new DataTable();
                    string sql = @"SELECT 
                                p.id
                                ,p.PlayerName as [Name]
                                ,count(ph.Roll) as [Rolls]	
                                ,cast(phr.win as text) as [Win]
                                ,cast(phr.Lose as text) as [Lose]
                                FROM [Players] p 
                                left join [PlayerHistory] ph on ph.PlayerID = p.Id
                                left join (
                                Select playerID, 
                                Sum(Case Result when 'Win' then 1 else 0 end) [win],
                                Sum(Case Result when 'Lose' then 1 else 0 end) [lose] 
                                from [PlayerHistory] Group by playerID) phr on phr.PlayerID = p.Id                    
                                where p.ID = @id
	                            Group by p.PlayerName ,p.id,phr.win ,phr.lose;";
                    sqlcmd.CommandText = sql;
                    sqlcmd.Parameters.Add(new SQLiteParameter("@id", PlayerID));
                    Reader = sqlcmd.ExecuteReader();
                    dt.Load(Reader);
                    txtWinLose.Text = dt.Rows[0][3].ToString() + "/" +dt.Rows[0][4].ToString();
                    txtNumRolls.Text = dt.Rows[0][2].ToString();
                    sqlcon.Close();
                }
            }
        }
        //wins 7, 11
        //craps 2, 3, 12
        //point 4, 5, 6, 8, 9, 10, 
        //lose point and 7 
        private void btnRollDice_OnClick(object sender, EventArgs e)
        {
            Random Roll = new Random();
            int Dice1 = Roll.Next(1, 6);
            int Dice2 = Roll.Next(1, 6);
            txtRoll.Text = Dice1 + ", " + Dice2;
            txtTotal.Text = (Dice1 + Dice2).ToString();
            Rules(Dice1 + Dice2);
        }

        private void Rules(int rolls)
        {
            if (point == 0)
            {
                if (rolls == 7 || rolls == 11)
                {
                    //Win message text
                    txtResult.Text = "Win";
                    Win(rolls, point);
                }
                else if (rolls == 2 || rolls == 3 || rolls == 12)
                {
                    //Craps message text
                    txtResult.Text = "Craps";
                    Lose(rolls, point);
                }
                else
                {
                    //Point message text                
                    point = rolls;
                    txtResult.Text = "Point " + point;
                    Points(rolls, point);
                }
            }
            else if (rolls == 7)
            {
                txtResult.Text = "Lost";
                Lose(rolls, point);
                ClearDice();
            }
            else if (point == rolls || rolls != 7)
            {
                txtResult.Text = "Win";
                Win(rolls, point);
                ClearDice();
            }
        }

        private void Win(int roll, int point)
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
            {
                sqlcon.Open();
                string sql = @"Insert into PlayerHistory(PlayerID,Roll,Point,Result) values(@id,@roll,@point,@result)";
                sqlcmd = new SQLiteCommand(sql, sqlcon);
                sqlcmd.Parameters.AddWithValue("@id", PlayerID);
                sqlcmd.Parameters.AddWithValue("@roll", roll);
                sqlcmd.Parameters.AddWithValue("@point", point);
                sqlcmd.Parameters.AddWithValue("@result", "Win");
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Dispose();
                sqlcon.Close();                
            }
            ClearDice();
            LoadData();

        }
        private void Lose(int roll, int point)
        {

            using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
            {
                sqlcon.Open();
                string sql = @"Insert into PlayerHistory(PlayerID,Roll,Point,Result) values(@id,@roll,@point,@result)";
                sqlcmd = new SQLiteCommand(sql, sqlcon);
                sqlcmd.Parameters.AddWithValue("@id", PlayerID);
                sqlcmd.Parameters.AddWithValue("@roll", roll);
                sqlcmd.Parameters.AddWithValue("@point", point);
                sqlcmd.Parameters.AddWithValue("@result", "Lose");
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Dispose();
                sqlcon.Close();
                ClearDice();
                LoadData();
            }
            
        }
        private void Points(int roll, int point)
        {
            using (SQLiteConnection sqlcon = new SQLiteConnection("Data Source=DiceGameDB.db;Version=3;"))
            {
                sqlcon.Open();
                string sql = @"Insert into PlayerHistory(PlayerID,Roll,Point,Result) values(@id,@roll,@point,null)";
                sqlcmd = new SQLiteCommand(sql, sqlcon);
                sqlcmd.Parameters.AddWithValue("@id", PlayerID);
                sqlcmd.Parameters.AddWithValue("@roll", roll);
                sqlcmd.Parameters.AddWithValue("@point", point);
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Dispose();
                sqlcon.Close();
            }
            LoadData();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            (new Players()).Show();
            PlayerID = 0;
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
