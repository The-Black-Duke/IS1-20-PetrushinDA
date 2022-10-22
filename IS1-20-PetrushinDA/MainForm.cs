using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace IS1_20_PetrushinDA
{
    public partial class MAINForm : MetroFramework.Forms.MetroForm
    {
        public MAINForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Сокрытие текущей формы
            this.Hide();
            //Инициализируем и вызываем форму диалога авторизации
            AuthForm Auth2 = new AuthForm();
            //Вызов формы в режиме диалога
            Auth2.ShowDialog();
            //Если авторизации была успешна и в поле класса хранится истина, то делаем движуху:
            if (Auth.auth)
            {
                //Отображаем рабочую форму
                this.Show();
                //Вытаскиваем из класса поля в label'ыMi
                metroLabel2.Text = Auth.auth_id;
                metroLabel3.Text = ($"Здравствуйте, { Auth.auth_fio}") ;
                metroLabel4.ForeColor = Color.GreenYellow;
                metroLabel4.Text = "Авторизация прошла успешно!";
                //Красим текст в label в зелёный цвет
                
            }
            //иначе
            else
            {
                //Закрываем форму
                this.Close();
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {
                
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MAINForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
