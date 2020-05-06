using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MorseLearn
{
    public partial class Form1 : Form
    {
        internal WindowsMediaPlayer wmp;
        string ls = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        char[] literals;
        static char choose_l;
        static char l;
        static bool game = false;
        static int score;
        public void Check()
        {
            if (game)
            {
                if (choose_l == l)
                {
                    MessageBox.Show("Правильно, это " + l, "Молодец!");
                    score += 1;
                }
                else
                {
                    MessageBox.Show("Не правильно, это " + l, "Попробуй еще раз");
                    score -= 1;
                }
                label2.Text = "Счет " + score.ToString();
                game = false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            wmp = new WindowsMediaPlayer();
            
        }
        private void sound(string l)
        {
            wmp.URL = "Sounds/" + l + ".mp3";
            wmp.controls.play();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            choose_l = 'Е';
            Check();
            sound("Е");
            label1.Text = "Пропевание:" + "	есть";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choose_l = 'А';
            Check();
            sound("А");
            label1.Text = "Пропевание:" + "ай-даа";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choose_l = 'Б';
            Check();
            sound("Б");
            label1.Text = "Пропевание:" + "баа-ки-те-кут";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choose_l = 'В';
            Check();
            sound("В");
            label1.Text = "Пропевание:" + "ви-даа-лаа";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choose_l = 'Г';
            Check();
            sound("Г");
            label1.Text = "Пропевание:" + "гаа-гаа-рин";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            choose_l = 'Д';
            Check();
            sound("Д");
            label1.Text = "Пропевание:" + "доо-ми-ки";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            choose_l = 'Ж';
            Check();
            sound("Ж");
            label1.Text = "Пропевание:" + "я-бук-ва-жее";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            choose_l = 'З';
            Check();
            sound("З");
            label1.Text = "Пропевание:" + "заа-каа-ти-ки";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            choose_l = 'И';
            Check();
            sound("И");
            label1.Text = "Пропевание:" + "и-ди";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            choose_l = 'Й';
            Check();
            sound("Й");
            label1.Text = "Пропевание:" + "и-краат-коо-еее";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            choose_l = 'К';
            Check();
            sound("К");
            label1.Text = "Пропевание:" + "каа-тень-каа";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            choose_l = 'Л';
            Check();
            sound("Л");
            label1.Text = "Пропевание:" + "лу-наа-ти-ки";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            choose_l = 'М';
            Check();
            sound("М");
            label1.Text = "Пропевание:" + "маа-маа";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            choose_l = 'Н';
            Check();
            sound("Н");
            label1.Text = "Пропевание:" + "ноо-мер";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            choose_l = 'О';
            Check();
            sound("О");
            label1.Text = "Пропевание:" + "оо-коо-лоо";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            choose_l = 'П';
            Check();
            sound("П");
            label1.Text = "Пропевание:" + "пи-лаа-поо-ёт";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            choose_l = 'Р';
            Check();
            sound("Р");
            label1.Text = "Пропевание:" + "ру-каа-ми";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            choose_l = 'С';
            Check();
            sound("С");
            label1.Text = "Пропевание:" + "си-не-е";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            choose_l = 'С';
            Check();
            sound("Т");
            label1.Text = "Пропевание:" + "таак";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            choose_l = 'Т';
            Check();
            sound("У");
            label1.Text = "Пропевание:" + "у-нес-лоо";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            choose_l = 'Ф';
            Check();
            sound("Ф");
            label1.Text = "Пропевание:" + "фи-ли-моон-чик";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            choose_l = 'Х';
            Check();
            sound("Х");
            label1.Text = "Пропевание:" + "хи-ми-чи-те"; // изменить звук
        }

        private void button24_Click(object sender, EventArgs e)
        {
            choose_l = 'Ц';
            Check();
            sound("Ц");
            label1.Text = "Пропевание:" + "цаа-пли-наа-ши";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            choose_l = 'Ч';
            Check();
            sound("Ч");
            label1.Text = "Пропевание:" + "чее-лоо-вее-чик";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            choose_l = 'Ш';
            Check();
            sound("Ш");
            label1.Text = "Пропевание:" + "шаа-раа-ваа-рыы";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            choose_l = 'Щ';
            Check();
            sound("Щ");
            label1.Text = "Пропевание:" + "щаа-ваам-не-шаа";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //sound("Ы");
            //label1.Text = "Пропевание:" + "ыы-не-наа-доо";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            choose_l = 'Ы';
            Check();
            sound("Ы");
            label1.Text = "Пропевание:" + "ыы-не-наа-доо";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            choose_l = 'Ь';
            Check();
            sound("Ь");
            label1.Text = "Пропевание:" + "знааак-мяг-кий-знааак";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            choose_l = 'Э';
            Check();
            sound("Э");
            label1.Text = "Пропевание:" + "э-ле-роо-ни-ки,";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            choose_l = 'Ю';
            Check();
            sound("Ю");
            label1.Text = "Пропевание:" + "ю-ли-ааа-наа";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            choose_l = 'Я';
            Check();
            sound("Я");
            label1.Text = "Пропевание:" + "я-маал-я-маал";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            game = true;
            Random r = new Random();
            if (!String.IsNullOrEmpty(textBox1.Text))
                ls = textBox1.Text;
             literals = ls.ToArray();
            //label1.Text = ls.ToString();
            l = literals[r.Next(0, literals.Length)];
            sound(Convert.ToString(l));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            literals = ls.ToArray();
        }
    }
}
