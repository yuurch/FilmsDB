using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 73);
        }


        private void Autorisation()
        {
            string StringUserLoggin = loginField.Text;
            string StringUserPas = passField.Text;
            
            DB db = new DB();
            
                try
                {
                   db.openConnection();

                    MySqlCommand comand = new MySqlCommand(
                        "SELECT * FROM `users` WHERE `user_loggin` = @lg AND `user_pass` = @ps",
                        db.getConnection()
                    );

                    comand.Parameters.Add("@lg", MySqlDbType.VarChar).Value = StringUserLoggin;
                    comand.Parameters.Add("@ps", MySqlDbType.VarChar).Value = StringUserPas;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comand);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        var MainMenuOpen = new mainmenu();
                        MainMenuOpen.Show();
                        this.Hide();
                        MainMenuOpen.FormClosed += (s, arg) => this.Close();
                    }
                    else
                        MessageBox.Show("Невірний логін або пароль.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час авторизації: {ex.Message}");
                }
            }
        
  
        private void UserPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Autorisation();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Autorisation();
        }
    }
}