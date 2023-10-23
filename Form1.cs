using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

// Created by Suryanarayan

namespace macOS_VMX_Patcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Adds Intel and AMD dropbox items
            DropBox.Items.Add("Intel");
            DropBox.Items.Add("AMD");
            InitializeVMXFile();
        }

        private string vmxFilePath = "";
        private string optionCode = "";

        private void InitializeVMXFile()
        {
            if (!string.IsNullOrEmpty(vmxFilePath))
            {
                // Reads the existing content of the VMX file.
                string fileContent = File.ReadAllText(vmxFilePath);

                if (IsOptionCodeInstalled("Intel", fileContent) || IsOptionCodeInstalled("AMD", fileContent))
                {
                    // The Patch is installed.
                    uninstallbtn.Enabled = true;
                }
                else
                {
                    // The Patch is not installed.
                    uninstallbtn.Enabled = false;
                }
            }
        }

        private bool IsOptionCodeInstalled(string selectedOption, string fileContent)
        {
            string optionCode = GetOptionCode(selectedOption);
            string pattern = Regex.Escape(optionCode);

            return Regex.IsMatch(fileContent, pattern);
        }

        private void browsefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // Sets the VMX file initial directory to My Documents.
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Sets the filters to .vmx files.
            dialog.Filter = "VMX Files (*.vmx)|*.vmx|All Files (*.*)|*.*";
            // Sets the title of the dialog box.
            dialog.Title = "Select a .vmx file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                vmxFilePath = dialog.FileName;
                string selFileName = dialog.FileName;
                string selectedFilter = dialog.Filter;
                string selectedExtension = System.IO.Path.GetExtension(selFileName);
                // Displays the Filepath on the textbox.
                TextBox.Text = vmxFilePath;

                // Checks whether the selected file is a VMX file.
                if (selectedExtension.Equals(".vmx", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("VMX file selected: " + selFileName);
                }
                else
                {
                    // Clears the textbox.
                    TextBox.Text = "";
                    // Gives out error.
                    MessageBox.Show("Selected file is not a .vmx file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a .vmx file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void patchbtn_Click(object sender, EventArgs e)
        {
            // Checks if the VMX file path is empty or not.
            if (!string.IsNullOrEmpty(vmxFilePath))
            {
                try
                {
                    // Determine which option (Intel or AMD) is selected from the ComboBox.
                    string selectedOption = DropBox.SelectedItem as string;
                    optionCode = GetOptionCode(selectedOption);
                    // Checks if the dropbox file is empty or not.
                    if (!string.IsNullOrEmpty(optionCode))
                    {
                        // Read the existing content of the VMX file.
                        string[] existingLines = File.ReadAllLines(vmxFilePath);

                        // Create a new content by appending the selected option code.
                        string newContent = string.Join(Environment.NewLine, existingLines);
                        newContent += Environment.NewLine + optionCode;

                        // Write the new content back to the VMX file.
                        File.WriteAllText(vmxFilePath, newContent);

                        MessageBox.Show("Patch code added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        patchbtn.Enabled = false; // Disables the Patch button.
                        uninstallbtn.Enabled = true; // Enables Uninstall button.
                    }
                    else
                    {
                        // Displays error.
                        MessageBox.Show("Please select an option (Intel or AMD) from the dropbox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Checks for any errors.
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while patching the file: " + ex.Message);
                }
            }
            else
            {
                // Clears the textbox.
                TextBox.Text = "";
                // Gives out error.
                MessageBox.Show("Please select a .vmx file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uninstallbtn_Click(object sender, EventArgs e)
        {
            // Checks if the VMX file path is empty.
            if (!string.IsNullOrEmpty(vmxFilePath) && !string.IsNullOrEmpty(optionCode))
            {
                try
                {
                    // Read the existing content of the VMX file.
                    string fileContent = File.ReadAllText(vmxFilePath);

                    // Determine which option (Intel or AMD) is selected from the DropBox.
                    string selectedOption = DropBox.SelectedItem as string;
                    string optionCode = GetOptionCode(selectedOption);

                    if (IsOptionCodeInstalled(selectedOption, fileContent))
                    {
                        // Remove the option code.
                        fileContent = Regex.Replace(fileContent, Regex.Escape(optionCode), "", RegexOptions.Multiline);

                        // Write the modified content back to the VMX file.
                        File.WriteAllText(vmxFilePath, fileContent);

                        MessageBox.Show("Patch code uninstalled successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        uninstallbtn.Enabled = false; // Disables Uninstall button.
                        patchbtn.Enabled = true; // Enables Patch button.
                    }
                    else
                    {
                        MessageBox.Show("Patch code uninstalled successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        patchbtn.Enabled = true; // Enables Patch button.
                    }
                }
                // Checks for any errors.
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while saving the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please patch code and open a VMX file first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetOptionCode(string selectedOption)
        {
            switch (selectedOption)
            {
                case "Intel":
                    // Adds Intel option lines.
                    return @"smc.version = ""0""
smbios.reflectHost = ""TRUE""
hw.model = ""MacBookPro14,3""
board-id = ""Mac-551B86E5744E2388""
";

                case "AMD":
                    // Adds AMD option lines.
                    return @"smc.version = ""0""
cpuid.0.eax = ""0000:0000:0000:0000:0000:0000:0000:1011""
cpuid.0.ebx = ""0111:0101:0110:1110:0110:0101:0100:0111""
cpuid.0.ecx = ""0110:1100:0110:0101:0111:0100:0110:1110""
cpuid.0.edx = ""0100:1001:0110:0101:0110:1110:0110:1001""
cpuid.1.eax = ""0000:0000:0000:0001:0000:0110:0111:0001""
cpuid.1.ebx = ""0000:0010:0000:0001:0000:1000:0000:0000""
cpuid.1.ecx = ""1000:0010:1001:1000:0010:0010:0000:0011""
cpuid.1.edx = ""0000:0111:1000:1011:1111:1011:1111:1111""
smbios.reflectHost = ""TRUE""
hw.model = ""MacBookPro14,3""
board-id = ""Mac-551B86E5744E2388""
";

                default:
                    return string.Empty;
            }
        }

    }
}