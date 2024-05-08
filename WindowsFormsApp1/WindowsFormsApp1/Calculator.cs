using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            dbFileName = "BaseData.db";
            ReadData();
        }
        private void ReadData()
        {
            m_dbConn = new SQLiteConnection(@"Data Source=BaseData.db");
            m_dbConn.Open();
            SQLiteCommand sqc = new SQLiteCommand("SELECT * FROM Warehouse", m_dbConn);
            var reader = sqc.ExecuteReader();

            while (reader.Read())
            {
                screwI.Text = reader[0].ToString();
                bigI.Text= reader[1].ToString();
                smallI.Text= reader[2].ToString();
                shelfI.Text= reader[3].ToString();
            }
            reader.Close();
            m_dbConn.Close();
        }

        private void testtext_Click(object sender, EventArgs e)
        {

        }

        private void UpLoad_Click(object sender, EventArgs e)
        {
            screwI.Text = ScrewTextBox.Text;
            bigI.Text = BigTextBox.Text;
            smallI.Text = SmallTextBox.Text;
            shelfI.Text = ShelfTextBox.Text;
            //int[] counts = { Convert.ToInt32(ScrewTextBox.Text), Convert.ToInt32(BigTextBox.Text), Convert.ToInt32(SmallTextBox.Text), Convert.ToInt32(ShelfTextBox.Text) };
            //string[] names = { ScrewTextBox.Text, BigTextBox.Text, SmallTextBox.Text, ShelfTextBox.Text };
            //for (int i = 0; i <= 3; i++)
            //{
            //    string query = $"UPDATE Warehouse SET count = {counts[i]} WHERE Screw = '{names[i]}'";
            //}
        }

        private void Calculate()
        {
            int screw;
        }
    }
}
