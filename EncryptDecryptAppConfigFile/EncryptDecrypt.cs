using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Diagnostics;
namespace EncryptDecryptAppConfigFile
{
    public partial class EncryptDecrypt : Form
    {
        public EncryptDecrypt()
        {
            InitializeComponent();
        }
        string FileName = string.Empty;


        public static void EncryptConnectionString(bool encrypt, string fileName)
        {
            Configuration configuration = null;
            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                configuration = ConfigurationManager.OpenExeConfiguration(fileName);
                ConnectionStringsSection configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
                {
                    if (encrypt && !configSection.SectionInformation.IsProtected)
                    {
                        //this line will encrypt the file
                        configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }

                    if (!encrypt && configSection.SectionInformation.IsProtected)//encrypt is true so encrypt
                    {
                        //this line will decrypt the file. 
                        configSection.SectionInformation.UnprotectSection();
                    }
                    //re-save the configuration file section
                    configSection.SectionInformation.ForceSave = true;
                    // Save the current configuration

                    configuration.Save();
                    Process.Start("notepad.exe", configuration.FilePath);
                    //configFile.FilePath 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void EncryptFile()
        {
            if (File.Exists(FileName))
            {
                EncryptConnectionString(true, FileName);
            }
            else
            {
                MessageBox.Show("File not exist");
            }
        }

        private void DecryptFile()
        {
            if (File.Exists(FileName))
            {
                EncryptConnectionString(false, FileName);
            }
            else
            {
                MessageBox.Show("File not exist");
            }
        }

        private void cmdOpen_Click_1(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            openFileDialog1.Filter = ".Net Executables|*.exe";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            FileName = openFileDialog1.FileName;
            txtEncryption.Text = FileName;
        }

        private void cmdEncrypt_Click_1(object sender, EventArgs e)
        {
            EncryptFile();
        }

        private void cmdDecrypt_Click_1(object sender, EventArgs e)
        {
            DecryptFile();
        }
    }
}
