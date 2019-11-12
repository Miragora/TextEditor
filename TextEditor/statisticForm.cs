using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class statisticForm : Form
    {
        public statisticForm(string text)
        {
            InitializeComponent();
            var text_length = text.Length;
            var words = text.Split(' ');
            var words_count = words.Length;

            TextLengthLabel.Text = text_length.ToString();
            WordsCountLabel.Text = words_count.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
