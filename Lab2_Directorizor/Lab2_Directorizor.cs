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

namespace Lab2_Directorizor
{
    public partial class Lab2_Directorizor : Form
    {
        private List<SimpleFileInfo> fileList;

        public Lab2_Directorizor()
        {
            InitializeComponent();
        }

        private void B_Directory_Click(object sender, EventArgs e)
        {
            if (FBD_Directory.ShowDialog() == DialogResult.OK)
            {
                string dir = FBD_Directory.SelectedPath;
                fileList = SimpleFileInfo.GenerateFileList(dir);
                status_directorypath.Text = dir;
                status_dirsize.Text = fileList.Sum(file => file.FileLength).ToString() + " bytes";
                status_numfiles.Text = fileList.Count() + " files";
                UpdateUI();
            }
        }

        private void LV_Directory_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            Console.WriteLine(e.Column);
            switch (e.Column)
            {
                case 1:
                    SimpleFileInfo.CompareOption = SimpleFileInfo.SortBySize;                    
                    break;
                case 2:
                    SimpleFileInfo.CompareOption = SimpleFileInfo.SortByModified;
                    break;
                case 3:
                    SimpleFileInfo.CompareOption = SimpleFileInfo.SortByDirectory;
                    break;
                default:
                    SimpleFileInfo.CompareOption = null;
                    break;
            }
            if (SimpleFileInfo.CompareOption != null)
                fileList.Sort(SimpleFileInfo.CompareOption);
            else
                fileList.Sort();

            LV_Directory.Items.Clear();
            UpdateUI();
        }

        private void LV_Directory_SelectedIndexChanged(object sender, EventArgs e)
        {            
            SimpleFileInfo selectedFile;            

            if (LV_Directory.SelectedItems.Count > 0)
            {
                //Console.WriteLine(LV_Directory.SelectedItems[0].Tag);
                selectedFile = (SimpleFileInfo)LV_Directory.SelectedItems[0].Tag;
                List<SimpleFileInfo> searchList = fileList.FindAll(file => file.Equals(selectedFile)).ToList();                
                for (int i = 0; i < LV_Directory.Items.Count; ++i)
                {
                    LV_Directory.Items[i].BackColor = Color.White;
                }
                foreach (SimpleFileInfo found in searchList)
                {                    
                    for (int i= 0; i < LV_Directory.Items.Count; ++i)
                    {
                        if (LV_Directory.Items[i].Tag == found)
                        {
                            LV_Directory.Items[i].BackColor = Color.Salmon;
                        }                        
                    }                    
                }
                LV_Directory.SelectedItems.Clear();
            }
        }

        private void UpdateUI()
        {
            foreach (SimpleFileInfo file in fileList)
            {
                ListViewItem info = new ListViewItem(file.FileName);
                info.Tag = file;
                info.SubItems.Add(file.FileLength.ToString());
                info.SubItems.Add(file.LastModified.ToString());
                info.SubItems.Add(file.DirName);
                LV_Directory.Items.Add(info);
            }            
        }

        private void LV_Directory_SizeChanged(object sender, EventArgs e)
        {
            LV_col_Path.Width = LV_Directory.Width - (LV_col_Size.Width + LV_col_Modified.Width + LV_col_fileName.Width);
        }
    }
}
