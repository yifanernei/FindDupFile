using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FIndDupFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var str = "Data Source=:memory:;Version=3;New=True;";
            SQLiteConnection conn = new SQLiteConnection(str);
            conn.Open();

            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "create table t(id, name);insert into t values(1, 'a');insert into t values(2, 'b');";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select * from t";
            var rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                var id = rd.GetInt32(0);
                string name = rd.GetString(1);
            }
        }

        private void bt_adddir_Click(object sender, EventArgs e)
        {
            if (fbd_dirs.ShowDialog() == DialogResult.OK)
            {
                DirInfo info = new DirInfo(fbd_dirs.SelectedPath);

                var item = lv_dirs.Items.Add(info.Path);
                item.SubItems.Add(info.LastDate);
                item.Tag = item;
            }
        }
    }
}
