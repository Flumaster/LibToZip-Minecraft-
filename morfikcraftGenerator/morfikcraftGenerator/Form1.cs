using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace morfikcraftGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (toappdata.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = toappdata.SelectedPath;
                from.Text = selectedPath;
                for (int i = 0; i < Directory.GetDirectories(selectedPath + @"\versions\").Count(); i++)
                {
                    ver.Items.Add(new DirectoryInfo(Directory.GetDirectories(selectedPath + @"\versions\")[i]).Name);
                }
                ver.SelectedItem = new DirectoryInfo(Directory.GetDirectories(selectedPath + @"\versions\")[0]).Name;

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            /* Искать либы */
            if (from.Text != String.Empty && System.IO.Directory.Exists(from.Text))
            {
                    string folder = from.Text + "/" + libfolder.Text;
                    string[]fullfilesPath = Directory.GetFiles(folder, "*.jar", SearchOption.AllDirectories);
                    for (int i = 0; i < fullfilesPath.Count(); i++)
                    {
                        liblist.Items.Add(fullfilesPath[i], true);
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tosave.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = tosave.SelectedPath;
                to.Text = selectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liblist.Enabled = false;
            string folder = Directory.GetDirectoryRoot("Windows") + "/LibToZip/tmp/";
            string folder2 = Directory.GetDirectoryRoot("Windows") + "/LibToZip/";

            if (Directory.Exists(folder))
            {
                foreach (string file in Directory.GetFiles(folder))
                {
                    File.Delete(file);
                }
                try { Directory.Delete(folder, true); }
                catch { };
            }
            else
            {
                Directory.CreateDirectory(folder);
            }
            string zipToUnpack;
            String[] itemArr = new String[liblist.CheckedItems.Count];
            Int32 counter = 0;
            foreach (object item in this.liblist.CheckedItems)
            {
                String temp = Convert.ToString(item);
                itemArr[counter] = temp;
                counter++;
            }
            for (int i = 0; i < itemArr.Count(); i++)
            {
                zipToUnpack = itemArr[i];
                using (ZipFile zip1 = ZipFile.Read(zipToUnpack))
                {
                    foreach (ZipEntry a in zip1)
                    {
                        a.Extract(folder, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                Application.DoEvents();
                label3.Text = i.ToString()+" из "+liblist.CheckedItems.Count.ToString();
                Application.DoEvents();

            }
            Directory.Delete(folder + "/META-INF/", true);
            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(folder);
                zip.Save(folder2 + "libs.zip");
            }
            System.Diagnostics.Process.Start(folder2);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
 


    }
}
