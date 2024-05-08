using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();
            dbFileName = "BaseData.db";
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
         if (!File.Exists(dbFileName)) MessageBox.Show("Please, create DB and blank table (Push \"Create\"button)");
            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;
                DataTable dTable = new DataTable();
                String sqlQuery;
                if (m_dbConn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Open connection with database");
                    //return;
                }
                try
                {
                    sqlQuery = "SELECT * FROM Warehouse";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                    adapter.Fill(dTable);
                    if (dTable.Rows.Count >= 0)
                    {
                        //dataGridView1.Rows.Clear();
                        for (int i = 0; i < dTable.Rows.Count; i++)
                        {
                            //dataGridView1.Columns.Add();
                            dataGridView1.Rows.Add(dTable.Rows[i].ItemArray);
                        }
                    }
                    else
                        MessageBox.Show("Database is empty");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReadDataBaseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void OpenForm2_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
