using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadFirstCSharpOpenTextFile
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();

            SetDialogBoxesProperties();
        }

        private void SetDialogBoxesProperties()
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";

            openFileDialog1.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop\";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
