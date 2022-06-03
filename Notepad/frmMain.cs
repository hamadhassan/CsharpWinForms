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

namespace Notepad
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                rctxtbxMain.Font=fontDialog.Font;
            }
        }

        #endregion

        #region Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctxtbxMain.Undo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctxtbxMain.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctxtbxMain.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rctxtbxMain.Paste();
        }
        #endregion

        #region File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        #endregion

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files(.txt)| *.txt | All Files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(openFileDialog.FileName);
                string s = sr.ReadLine();
                StringBuilder sb = new StringBuilder();
                while (s != null)
                {
                    sb.Append(s);
                    s = sr.ReadLine();
                }
                sr.Close();
                rctxtbxMain.Text = sb.ToString();

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(.txt)| *.txt | All Files(*.*) | *.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string name = saveFile.FileName;
                File.WriteAllText(name,rctxtbxMain.Text);
            }
           
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(.txt)| *.txt | All Files(*.*) | *.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string name = saveFile.FileName;
                File.WriteAllText(name, rctxtbxMain.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void rctxtbxMain_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
