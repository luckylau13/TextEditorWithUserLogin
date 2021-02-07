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

namespace WindowsFormsApp1
{
    public partial class TextEditor : Form
    {
        private string path = "";
        public TextEditor()
        {
            InitializeComponent();
        }

        //to create new file 
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        //to save file
        private void SaveMenu(object sender, EventArgs e)
        {

         
            if (path == String.Empty)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.rtf";
                saveFile.Filter = "RTF Files|*.rtf";
                DialogResult dr = saveFile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    path = saveFile.FileName;

                    try
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine(richTextBox1.Text);
                        sw.Close();

                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error saving fil: " + ioe.Message);
                    }
                    string filename = saveFile.FileName;
                    MessageBox.Show("The File Selected was:" + filename);
                }

            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error saving fil: " + ioe.Message);
                }
            }

        }

        //to cut file
        private void CutControlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }

        //to create new file in tool strip 
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        //to change font in text editor
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //to open file in tool strip 
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {

        }

        //to save file in tool strip 
        private void ToolStripButton3_Click(object sender, EventArgs e)
        {

        }

        //to save file as in tool strip 
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {

        }

        //Bold button in tool strip 
        private void ToolStripButton5_Click(object sender, EventArgs e)
        {

        }

        //italic button in tool strip 
        private void ToolStripButton6_Click(object sender, EventArgs e)
        {

        }
        
        //underline in tool strip 
        private void ToolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Openfile_Menu(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open File";
                openFile.Filter = "Text File (*.txt)|*.txt|All Files(*.*)|*.*";
                DialogResult dr = openFile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFile.FileName;
                    string filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                }
            }
            catch (Exception ioe)
            { MessageBox.Show("Something went wrong!"); }
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.rtf";
            saveFile.Filter = "RTF Files|*.rtf";
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                 path = saveFile.FileName;

                try
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error saving fil: " + ioe.Message);
                }
                string filename = saveFile.FileName;
                MessageBox.Show("The File Selected was:" + filename);
            }

        }

        public void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //to make the text Bold
        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle = FontStyle.Bold;
                if (richTextBox1.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (richTextBox1.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (richTextBox1.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != richTextBox1.SelectionFont.Style)
                {
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ioe)
            {
                MessageBox.Show("Something went wrong!");
            }

        }

        //to make the text Italic 
        private void ToolStripButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle = FontStyle.Italic;
                if (richTextBox1.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (richTextBox1.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (richTextBox1.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != richTextBox1.SelectionFont.Style)
                {
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ioe)
            {
                MessageBox.Show("Something went wrong!");
            }
           
        }

        //to make the text underline
        private void ToolStripButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle = FontStyle.Underline;
                if (richTextBox1.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (richTextBox1.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (richTextBox1.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != richTextBox1.SelectionFont.Style)
                {
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ioe)
            {
                MessageBox.Show("Something went wrong!");
            }

        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Open File";
                openFile.Filter = "Text File (*.txt)|*.txt|All Files(*.*)|*.*";
                DialogResult dr = openFile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string filename = openFile.FileName;
                    string filetext = File.ReadAllText(filename);
                    richTextBox1.Text = filetext;
                }
            }
            catch (Exception ioe)
            { MessageBox.Show("Someting went wrong!"); }
            
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (path == String.Empty)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.rtf";
                saveFile.Filter = "RTF Files|*.rtf";
                DialogResult dr = saveFile.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    path = saveFile.FileName;

                    try
                    {
                        StreamWriter sw = new StreamWriter(path);
                        sw.WriteLine(richTextBox1.Text);
                        sw.Close();

                    }
                    catch (IOException ioe)
                    {
                        MessageBox.Show("Error saving fil: " + ioe.Message);
                    }
                    string filename = saveFile.FileName;
                    MessageBox.Show("The File Selected was:" + filename);
                }

            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();

                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error saving fil: " + ioe.Message);
                }
            }
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {
            try
            {

                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
                if (richTextBox1.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
                if (richTextBox1.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
                if (richTextBox1.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
                if (newFontStyle != richTextBox1.SelectionFont.Style)
                {
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, float.Parse(toolStripComboBox1.SelectedItem.ToString()));

                }
            }
            catch (Exception ioe)
            {
                MessageBox.Show("Something went wrong!");
            }
            
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new login();
            login.Show();
        }

        public void disablertb()
        {
            richTextBox1.Enabled = false ;
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            
        }

        //cut tool
        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = string.Empty;
            }
            catch(Exception ioe)
            {
                MessageBox.Show("Error:" + ioe);
            }
        }

        //copy tool 
        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(richTextBox1.SelectedText); }
            catch (Exception ioe) { MessageBox.Show("Error:"+ioe); }
            
        }

        //paste tool 
        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                string text = Clipboard.GetText();
                richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, text);
            }
            catch (Exception ioe) { MessageBox.Show("Error:" + ioe); }


        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        public void changename(string name)
        {
            toolStripLabel2.Text = name;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void CopyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(richTextBox1.SelectedText);  }
            catch (Exception ioe) { MessageBox.Show("Error:" + ioe); }
        }

        private void PasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string text = Clipboard.GetText();
                richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, text);
            }
            catch (Exception ioe) { MessageBox.Show("Error:" + ioe); }
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please roll your mouse over each  icon to see its functionality.");
        }
    }
}
