using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Messenger
{
    public partial class Messenger : Form
    {
        public Messenger()
        {
            InitializeComponent();
        }

        private void button_Maria_Click(object sender, EventArgs e)
        {
            string mesaj = this.richTextBox2.Text;
            if (!mesaj.Trim().Equals(""))
            {
                this.richTextBox1.SelectionColor = Color.Red;
                this.richTextBox1.AppendText("Maria: " + mesaj + "\n");
                this.richTextBox2.Clear();
            }
        }

        private void button_Ionel_Click(object sender, EventArgs e)
        {
            string mesaj = this.richTextBox2.Text;
            if (!mesaj.Trim().Equals(""))
            { 
                this.richTextBox1.SelectionColor = Color.Blue;
                this.richTextBox1.AppendText("Ionel: " + mesaj + "\n");
                this.richTextBox2.Clear();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string fn = this.saveFileDialog1.FileName;
            fn += ".rtf";
            string content = this.richTextBox1.Text;
            System.IO.File.WriteAllText(fn,content);
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "(*.rtf)|*.rtf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fn = dialog.FileName;
                string content = System.IO.File.ReadAllText(fn);
                this.richTextBox1.Text = content;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }
    }
}
