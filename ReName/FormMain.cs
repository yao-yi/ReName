using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReName
{
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        StringBuilder st = new StringBuilder();
        DialogResult result;
        DirectoryInfo p;
        FileInfo info;
        string[] s;
        private void btnChose_Click(object sender, EventArgs e)
        {
            result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOldName.Text = getProjectName(openFileDialog.FileName);
                btnRename.Enabled = true;
            }
        }
        private void btnRename_Click(object sender, EventArgs e)
        {
            justDoIt();
        }
        private void tbNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                justDoIt();
            }
        }
        private void justDoIt()
        {
            if (tbOldName.Text == tbNewName.Text || tbNewName.Text.Length == 0) MessageBox.Show("Incorrect name");
            else
            {
                DirectoryInfo pathDI = new DirectoryInfo(getDir(openFileDialog.FileName));
                string path = pathDI.FullName.Replace(tbOldName.Text, tbNewName.Text);
                Directory.Move(pathDI.FullName, pathDI.FullName.Replace(tbOldName.Text, tbNewName.Text));
                RenameDirs(path);
                RenameFiles(path);
                RenameInFiles(path);
                btnRename.Enabled = false;
                MessageBox.Show("Old name: " + tbOldName.Text + Environment.NewLine + "New name: " + tbNewName.Text, "Replaced successfully");
            }
        }
        private void RenameFiles(string v)
        {
            p = new DirectoryInfo(v);
            foreach (FileInfo child in p.GetFiles("*", SearchOption.AllDirectories))
            {
                string newName = child.FullName.Replace(tbOldName.Text, tbNewName.Text);

                if (newName != child.FullName)
                {
                    try
                    {
                        child.MoveTo(newName);
                    }
                    catch (Exception) { }
                }
            }
        }
        private void RenameInFiles(string v)
        {
            p = new DirectoryInfo(v);
            
            foreach (var file in p.GetFiles("*", SearchOption.AllDirectories))
            {
                info = new FileInfo(file.FullName);
                try
                {
                    File.WriteAllText(info.ToString(), File.ReadAllText(info.ToString()).Replace(tbOldName.Text, tbNewName.Text));
                }
                catch (Exception) { }
            }
        }
        private void RenameDirs(string v)
        {
            p = new DirectoryInfo(v);
            foreach (DirectoryInfo child in p.GetDirectories("*", SearchOption.AllDirectories))
            {
                string newName = child.FullName.Replace(tbOldName.Text, tbNewName.Text);
                if (newName != child.FullName)
                {
                    try
                    {
                        child.MoveTo(newName);
                    }
                    catch (Exception) { }
                }
            }
        }
        private string getDir(string fileName)
        {
            st.Clear();
            s = fileName.Split('\\');
            for (int i = 0; i < s.Length - 1; i++)
            {
                st.Append(s[i] + "\\");
            }
            return st.ToString();
        }
        private string getProjectName(string selectedPath)
        {
            s = selectedPath.Split('\\');
            return s[s.Length - 1].Replace(".sln","");
        }
    }
}
