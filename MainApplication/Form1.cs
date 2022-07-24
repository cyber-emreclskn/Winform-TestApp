using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApplication.Views;
using MainApplication.Entities;

namespace MainApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        static AdminViews adminViews = new AdminViews();
        static List<AdminClass> admins = new List<AdminClass>() {
            new AdminClass("username","1234"),
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;

            /*
            if(RegisterAdmin(new AdminClass(username, password)))
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız Kayıt");
            }
            */

            if(loginAdmin(new AdminClass(username, password)))
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
            


           
        }

        public static bool loginAdmin(AdminClass admin)
        {
            if (admins.Contains(admin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RegisterAdmin(AdminClass admin)
        {
            
            admins.Add(admin);
            if (admins.Contains(admin))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool usernameStartWithNumberValidation(String username)
        {
           
            if (char.IsDigit(username[0]))
            {
                MessageBox.Show("Kullanıcı Adı Rakamla Başlamaz");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public static bool passwordLengthValidation(String password)
        {
            if (password.Length > 20)
            {
                MessageBox.Show("Parola 20 karakterden fazla olamaz");
                return false;
            }
            else
            {
                MessageBox.Show("Parola iyi oldu");
                return true;
            }
        }
        
        
    }
}
