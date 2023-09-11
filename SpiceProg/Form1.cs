using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiceProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             if (!Directory.Exists("C:\\Алый рассвет"))
                 Directory.CreateDirectory("C:\\Алый рассвет");

             if(!File.Exists($"C:\\Алый рассвет\\{name_box.Text} {patronymic_box.Text}.txt"))
             {
                 File.Delete($"C:\\Алый рассвет\\{name_box.Text} {patronymic_box.Text}");

                 File.AppendAllLines($"C:\\Алый рассвет\\{name_box.Text} {patronymic_box.Text}.txt", 
                     new string[]
                     {
                         $"Ф.И.О.: {surname_box.Text} {name_box.Text} {patronymic_box.Text}",
                         $"ВК: {vk_name.Text}", 
                         $"{vk_id.Text}", 
                         $"Возраст: {age.Text}",
                         $"Группа: {m_group_box.Text}",
                         $"Комментарий: {coment_box.Text}"
                     });

                 File.AppendAllLines($"C:\\Алый рассвет\\Люди.txt", 
                     new string[]
                     {
                         $"Ф.И.О.: {surname_box.Text} {name_box.Text} {patronymic_box.Text}",
                         $"ВК: {vk_name.Text}",
                         $"{vk_id.Text}",
                         $"Возраст: {age.Text}",
                         $"Группа: {m_group_box.Text}",
                         $"Комментарий: {coment_box.Text}"
                     });
             }      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void age_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void m_group_box_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            m_group_box.Text = m_group_box.Text.ToUpper();
        }
    }
}
