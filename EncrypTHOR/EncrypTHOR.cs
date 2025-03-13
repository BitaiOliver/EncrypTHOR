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

namespace EncrypTHOR
{
    public partial class EncrypTHOR : Form
    {
        private CryptoServices CryServ = new CryptoServices();
        public EncrypTHOR()
        {
            InitializeComponent();
        }


        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if("" != DecryptPassTextBox.Text)
            {
                DecryptPlainTextBox.Text = CryServ.Decript(DecryptPassTextBox.Text, EncryptPlainTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter decrypting password");
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if ("" != EncryptPassTextBox.Text)
            {
                EncryptPlainTextBox.Text = CryServ.Encript(EncryptPassTextBox.Text, DecryptPlainTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please enter encrypting password");
            }
        }

        private void FileEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = null;
            OpenFileDialog open_dialog;

            if ("" != EncryptPassTextBox.Text)
            {
                open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Text Files|*.txt";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {
                    plaintext = File.ReadAllText(open_dialog.FileName);
                    EncryptPlainTextBox.Text = CryServ.Encript(EncryptPassTextBox.Text, plaintext);
                }
                else
                {
                    /* do nothing */
                }
            }
            else
            {
                MessageBox.Show("Please enter encrypting password");
            }
        }

        private void FileDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedtext = null;
            OpenFileDialog open_dialog;

            if ("" != DecryptPassTextBox.Text)
            {
                open_dialog = new OpenFileDialog();
                open_dialog.Filter = "Text Files|*.txt";
                if (open_dialog.ShowDialog() == DialogResult.OK)
                {               
                    cryptedtext = File.ReadAllText(open_dialog.FileName);
                    DecryptPlainTextBox.Text = CryServ.Decript(DecryptPassTextBox.Text, cryptedtext);
                }
                else
                {
                    /* do nothing */
                }
            }
            else
            {
                MessageBox.Show("Please enter decrypting password");
            }
        }

        private void EncryptSaveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, EncryptPlainTextBox.Text);
            }
            else
            {
                MessageBox.Show("Err: File could not be saved!");
            }
        }

        private void DecryptSaveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, DecryptPlainTextBox.Text);
            }
            else
            {
                MessageBox.Show("Err: File could not be saved!");
            }
        }
    }
    /*
    public class InternalMethotds
    {
        public string GetAesKey_forEncrypt()
        {
            return EncryptPassTextBox.Text;
        }

    }*/
}
