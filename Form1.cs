using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nika_Iakobashvili_Image_Viewer
{
    public partial class Form1 : Form
    {
        // Explain

        // Dictionary used to store image names and corresponding paths
        private Dictionary<string, string> imageNames = new Dictionary<string, string>();

        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            // When Form loads we check for the existance of startup.ini

            string currDir = Directory.GetCurrentDirectory();
            currDir = Directory.GetParent(currDir).Parent.FullName;

            string INIFile = Path.Combine(currDir, "startup.ini");
            // Separate function that reads .ini file and returns dictionary
            // option : value
            Dictionary<string, string> readINI = ReadIniFile(INIFile);

            if (readINI["StartupDirectory"] != "\"\"")
            {
                string dirPath = readINI["StartupDirectory"].Replace("\"", "");

                if (Directory.Exists(dirPath))
                {
                    listBoxDirs.Items.Add(dirPath);
                    UpdateList();
                }
            }

            // defalut size
            int size1 = 800;
            int size2 = 440;

            string[] sizes = readINI["DefaultPictureSize"].Split(';');
            if (sizes.Length == 2)
            {
                int.TryParse(sizes[0], out int sizetmp);
                int.TryParse(sizes[1], out int sizetmp2);

                if (sizetmp > 0 || sizetmp2 > 0)
                {
                    if (sizetmp > 1000) size1 = 1000;
                    else size1 = sizetmp;
                    if (sizetmp2 > 1000) size2 = 1000;
                    else size2 = sizetmp2;
                }
            }

            // resize
            pictureBoxCurrent.Size = new Size(size1, size2);

            // center
            pictureBoxCurrent.Left = (groupBoxViewer.Width - pictureBoxCurrent.Width) / 2;
        }

        // Function that reads .ini file and returns dictionary
        private static Dictionary<string, string> ReadIniFile(string fileName)
        {
            // If file does not exist we create it
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine("StartupDirectory=\"\"");
                    sw.WriteLine("DefaultPictureSize=940;400");
                }
            }
            // Read file and return dictionary
            return File.ReadLines(fileName).Select(s => s.Split('=')).Select(s => new
            {
                key = s[0],
                value = string.Join("=", s.Select((o, n) => new
                {
                    n,
                    o
                }).Where(o => o.n > 0).Select(o => o.o))
            }).ToDictionary(o => o.key, o => o.value);
        }

        public void UpdateList()
        {
            // Reset everything
            currentIndex = -1;
            listBoxImages.Items.Clear();
            imageNames.Clear();
            // For each directory in listbox we get all images and add them to listbox
            foreach (string directoryPath in listBoxDirs.Items)
            {
                string[] filePaths = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

                foreach (string filePath in filePaths)
                {
                    if (Path.GetExtension(filePath).Equals(".bmp", StringComparison.OrdinalIgnoreCase) ||
                       Path.GetExtension(filePath).Equals(".emf", StringComparison.OrdinalIgnoreCase) ||
                       Path.GetExtension(filePath).Equals(".ico", StringComparison.OrdinalIgnoreCase) ||
                       Path.GetExtension(filePath).Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                       Path.GetExtension(filePath).Equals(".gif", StringComparison.OrdinalIgnoreCase) ||
                       Path.GetExtension(filePath).Equals(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        string fileName = Path.GetFileName(filePath);

                        try
                        {
                            // check if image name already exists
                            if (!imageNames.ContainsKey(fileName))
                            {
                                imageNames.Add(fileName, filePath);
                                listBoxImages.Items.Add(fileName);
                            }
                            else
                            {
                                // if image name already exists we add number to the end of the name
                                int i = 1;
                                while (imageNames.ContainsKey(fileName + i))
                                {
                                    i++;
                                }
                                imageNames.Add(fileName + i, filePath);
                                listBoxImages.Items.Add(fileName + i);
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        // Function that checks if image exists
        public void CheckImageExistance(string imageName)
        {
            string curPath = imageNames[imageName];

            if (!File.Exists(curPath))
            {
                MessageBox.Show("File " + imageName + " doesn't exist!");
                imageNames.Remove(imageName);
                listBoxImages.Items.RemoveAt(listBoxImages.FindString(imageName));
                listBoxImages.SelectedIndex = 0;
                ClearImages();
                UpdateList();
                DisplayImages();
                return;
            }
        }

        // Function that clears images
        public void ClearImages()
        {
            pictureBoxPrevious.Image = null;
            pictureBoxCurrent.Image = null;
            pictureBoxNext.Image = null;
        }

        // Function that displays previous image
        public void DisplayPrev()
        {
            CheckImageExistance(listBoxImages.Items[currentIndex - 1].ToString());
            string prevName = listBoxImages.Items[currentIndex - 1].ToString();
            pictureBoxPrevious.Image = Image.FromFile(imageNames[prevName]);
        }

        // Function that displays next image
        public void DisplayNext()
        {
            CheckImageExistance(listBoxImages.Items[currentIndex + 1].ToString());
            string nextName = listBoxImages.Items[currentIndex + 1].ToString();
            pictureBoxNext.Image = Image.FromFile(imageNames[nextName]);
        }

        public void DisplayImages()
        {
            if (imageNames.Count == 0 || currentIndex > imageNames.Count || currentIndex == -1)
            {
                return;
            }
            ClearImages();
            pictureBoxPrevious.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCurrent.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNext.SizeMode = PictureBoxSizeMode.Zoom;

            string curName = listBoxImages.Items[currentIndex].ToString();

            labelInfo.Text = currentIndex.ToString();

            try
            {
                ClearImages();
                if (currentIndex - 1 >= 0) DisplayPrev();
                if (currentIndex + 1 <= imageNames.Count - 1) DisplayNext();
                pictureBoxCurrent.Image = Image.FromFile(imageNames[curName]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return;
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    string directoryPath = dialog.SelectedPath;
                    // check if directory is alreadt there

                    if (!listBoxDirs.Items.Contains(directoryPath))
                    {
                        // check if directory is a subdirectory of another directory
                        listBoxDirs.Items.Add(directoryPath);
                        foreach (string dir in listBoxDirs.Items)
                        {
                            if (directoryPath.Contains(dir) && directoryPath != dir)
                            {
                            }
                            else
                            {
                                UpdateList();
                            }
                        }
                        DisplayImages();
                    }
                    else
                    {
                        MessageBox.Show("Directory already exists!");
                    }
                }
            }
        }

        private void buttonDelDir_Click(object sender, EventArgs e)
        {
            if (listBoxDirs.SelectedIndex != -1)
            {
                listBoxDirs.Items.RemoveAt(listBoxDirs.SelectedIndex);
            }
            else
            {
                return;
            }
            UpdateList();
            ClearImages();
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = listBoxImages.SelectedIndex;
            if (currentIndex != -1)
            {
                CheckImageExistance(listBoxImages.Items[currentIndex].ToString());
                ClearImages();
                DisplayImages();
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex - 1 >= 0)
            {
                currentIndex--;
                listBoxImages.SelectedIndex = currentIndex;
                DisplayImages();
            }
            return;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentIndex + 1 <= imageNames.Count - 1)
            {
                currentIndex++;
                listBoxImages.SelectedIndex = currentIndex;
                DisplayImages();
            }
            return;
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (imageNames.Count == 0 || currentIndex > imageNames.Count - 1)
            {
                return;
            }
            ClearImages();

            buttonStop.Enabled = true;
            listBoxDirs.Enabled = false;
            listBoxImages.Enabled = false;
            numericUpDownDelay.Enabled = false;
            buttonPrev.Enabled = false;
            buttonNext.Enabled = false;
            buttonAddDir.Enabled = false;
            buttonDelDir.Enabled = false;

            currentIndex = 0;
            string curName = listBoxImages.Items[currentIndex].ToString();
            while (currentIndex < imageNames.Count)
            {
                if (currentIndex == -2)
                {
                    break;
                }
                labelInfo.Text = currentIndex.ToString();

                try
                {
                    DisplayImages();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                currentIndex++;
                await Task.Delay((int)numericUpDownDelay.Value);
                if (checkBoxLoop.Checked && currentIndex == imageNames.Count)
                {
                    currentIndex = 0;
                }
            }
            currentIndex = 0;
            buttonStop.Enabled = false;
            listBoxDirs.Enabled = true;
            listBoxImages.Enabled = true;
            numericUpDownDelay.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            buttonAddDir.Enabled = true;
            buttonDelDir.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            currentIndex = -2;

            buttonStop.Enabled = false;
            listBoxDirs.Enabled = true;
            listBoxImages.Enabled = true;
            numericUpDownDelay.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            buttonAddDir.Enabled = true;
            buttonDelDir.Enabled = true;
        }
    }
}