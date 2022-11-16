using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imagenesdebug\fondo1.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textusuario.Text;
            string pass = textcontraseña.Text;
           
            if (user.Equals("admin") &&
            pass.Equals("123"))
            {
                formularioproductos fp = new formularioproductos();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y claveincorrecto");
            }
        }

        private void btninicio_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                string user = textusuario.Text;
                string pass = textcontraseña.Text;

                if (user.Equals("admin") &&
                pass.Equals("123"))
                {
                    formularioproductos fp = new formularioproductos();
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y claveincorrecto");
                }
            }
        }
    }
}
     
