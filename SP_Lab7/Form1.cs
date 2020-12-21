using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SP_Lab7
{
    public partial class Form1 : Form
    {
        public List<Music> musics = new List<Music>();
        public BindingSource bindingSource = new BindingSource();
        public string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=MusicLibraryDB;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            string sqlExpression = "SELECT * FROM Musics";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(sqlExpression,conn);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    musics.Add(new Music(
                        sqlDataReader.GetString(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetString(3)
                        ));
                    
                }
            }
            
            bindingSource.DataSource = musics;
            dataGridView1.DataSource = bindingSource;
        }


        private void saveBt_Click(object sender, EventArgs e)
        {
            string sqlExpression = "TRUNCATE TABLE Musics";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand command =new SqlCommand(sqlExpression,conn);
                command.ExecuteNonQuery();
                
                foreach (Music item in musics)
                {
                    
                    sqlExpression =
                        $"INSERT  Musics(Name, Author, Genre, Album) VALUES('{item.Name}', '{item.Author}', '{item.Genre}', '{item.Album}');";
                    command = new SqlCommand(sqlExpression, conn);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
                musics.Remove(dataGridView1.SelectedRows[0].DataBoundItem as Music);
            bindingSource.ResetBindings(true);
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            musics.Add(new Music(nameTb.Text, authorTb.Text, genreTb.Text, albumTb.Text));
            bindingSource.ResetBindings(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost!",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}