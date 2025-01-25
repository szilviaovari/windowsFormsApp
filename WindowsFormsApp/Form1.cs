using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Hugi\\Documents\\2025-2026\\project_windowsForms\\Sajat\\Ovari_Szilvia.html");
        }

        private void nameUpdatebutton_Click(object sender, EventArgs e)
        {
            string filePath = "nevek.txt";

            if (File.Exists(filePath))
            {
                string[] names = File.ReadAllLines(filePath);
                Array.Sort(names);
                label1.Text = "Nevek:\n";
                bool hasValidNames = false;
                for (int i = 0; i < names.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(names[i]))
                    {
                        label1.Text += "\n" + names[i];
                        hasValidNames = true;
                    }
                }
                if (!hasValidNames)
                {
                    label1.Text = "Nincsenek nevek a fájlban.";
                }
            }
            else
            {
                MessageBox.Show("A fájl nem található.");
            }
        }
    }
}
