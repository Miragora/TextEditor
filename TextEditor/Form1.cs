using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var open_dialog = new OpenFileDialog();
            open_dialog.Title = "выбор файла";
            open_dialog.Filter = "Текстовые файлы |*.txt| Все файлы |*.*|";
            var result = open_dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var file_name = open_dialog.FileName;
            if (!File.Exists(file_name))
                return;
            var file_text = File.ReadAllText(file_name);

            //после команды textbox
            TextEditor.Text = file_text;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            var save_dialog = new SaveFileDialog();
            save_dialog.Title = "Выбор файла";
            save_dialog.Filter = "Текстовый файл |*.txt| Все файлы |*.*|";
            var result = save_dialog.ShowDialog();
            if (result != DialogResult.OK)
                return;
            var file_name = save_dialog.FileName;
            
             File.WriteAllText(file_name, TextEditor.Text);

        }

        private void statistiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stat_form = new statisticForm(TextEditor.Text);
            stat_form.Show();
        }

       
    }
}
