using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private DirectoryInfo _dif = null;
        private string _avPath = "";
        private StringBuilder _xml;
        private string _replace = "";
        private int _count = 0;

        public MainForm()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            //create database
            _xml = new StringBuilder();
            _xml.AppendLine("<Fragment>" + Environment.NewLine+"\t<ComponentGroup Id='ProductComponents' Directory='INSTALLFOLDER'>");
            this.textBoxReplaceWith.Text = "$(var.DebugDir)";
            folderBrowserDialogAVVer.SelectedPath = @"C:\Projects";
        }

        private void buttonDirBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFileSrcDirPath.Text = "";

                if (folderBrowserDialogAVVer.ShowDialog() == DialogResult.OK)
                {
                    _avPath = folderBrowserDialogAVVer.SelectedPath;
                    _dif = new DirectoryInfo(_avPath);
                    textBoxFileSrcDirPath.Text = _avPath;
                    textBoxReplace.Text = _avPath;
                }
            }
            catch (Exception)
            {   
                throw;
            }
        }


        private void FillDirectoryTreeView(DirectoryInfo diff, TreeNodeCollection addInMe)
        {
            try
            {
                TreeNode currentNode = addInMe.Add(diff.Name);

                foreach (FileInfo fileInfo in diff.GetFiles())
                {
                    _count++;
                    currentNode.Nodes.Add(fileInfo.FullName, fileInfo.Name + " (" + GetFileSize(fileInfo) + ")");
                    string fullName = _avPath + "\\" + fileInfo.Name;

                    if (fileInfo.FullName.Equals(_avPath + "\\" + fileInfo.Name))
                    {
                        AddNewXmlComponent(fileInfo);
                    }
                    else if(!File.Exists(_avPath+"\\"+fileInfo.Name))
                    {
                        AddNewXmlComponent(fileInfo);
                    }
   
                }

                foreach (DirectoryInfo subDir in diff.GetDirectories()) 
                {
                    FillDirectoryTreeView(subDir,currentNode.Nodes);
                }
                
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception "+ exc.Message);
            }
           
        }

        private void AddNewXmlComponent(FileInfo fileInfo)
        {
            var sb = new StringBuilder();
            sb.AppendLine("\t\t<Component Id='CMP_" + SanitiseComponentID(fileInfo.Name) + "_" + _count + "' Guid='" +
                          Guid.NewGuid().ToString().ToUpper() + "'>");
            try
            {
                string fileId = SanitiseComponentID(fileInfo.Name);
                string source = fileInfo.FullName.Replace(_replace.Trim(), this.textBoxReplaceWith.Text.Trim());

                sb.AppendLine("\t\t\t<File Id='FIL_" + fileId + "_" + _count + "' KeyPath='yes' Source='" + source + "' />");
            
            }
            catch(Exception exc)
            {
               // throw;
            }

            try
            {
                sb.AppendLine("\t\t</Component>" + Environment.NewLine);
            }
            catch (Exception exc)
            {
                
                throw;
            }


            _xml.Append(sb.ToString());
        }

        private static string GetFileSize(FileInfo file)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = file.Length;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void buttonTestRun_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private string SanitiseComponentID(string name)
        {
            string id = name.Replace("-", "_").Replace(" ", "_").Replace(".","_");
            return id;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialogFileList.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                this.saveFileDialogFileList.FilterIndex = 1;
                this.saveFileDialogFileList.RestoreDirectory = true;
               
                if (this.saveFileDialogFileList.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(saveFileDialogFileList.OpenFile()))
                    {
                        for (int i = 0; i < this.textBoxGeneratedString.Lines.Length; i++)
                        {
                            writer.WriteLine(this.textBoxGeneratedString.Lines[i]);
                        }
                    }
                }               
            }
            catch (Exception)
            {             
                throw;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; (i <= 10); i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation.
                    if (_dif != null)
                    {
                        this.treeViewAV.Nodes.Clear();
                        TreeNodeCollection collection = this.treeViewAV.Nodes;
                        _replace = this.textBoxReplace.Text.Trim();
                        Console.WriteLine("Runing shit!!");
                        FillDirectoryTreeView(_dif, collection);
                        
                    }
                    else
                    {
                        MessageBox.Show("Info", "Root directory is legal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                }
            }          
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
               // this.tbProgress.Text = "Canceled!";
            }
            else if (!(e.Error == null))
            {
               // this.tbProgress.Text = ("Error: " + e.Error.Message);
            }
            else
            {
                _xml.AppendLine("\t</ComponentGroup>" + Environment.NewLine + "</Fragment>");
                this.textBoxGeneratedString.Text = _xml.ToString();
            }
        }
    }
}
