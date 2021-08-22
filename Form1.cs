using Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Diagnostics;

namespace Fencrypt
{
    public partial class MainForm : Form
    {
        //
        //
        //
        // RSA
        //
        //
        //
        public static Rsa rsa;
        public static byte[] _file_bytes;
        public string _encoded_path = @"/Fencrypt/RSA/encrypted";
        public string _decoded_path = @"/Fencrypt/RSA/decrypted";
        public static string _path = @"/Fencrypt/RSA/keys/";
        public static string _file_path= "";
        public static string _type = "";
        public static int _numberOfBytes = 32;
        public MainForm()
        {
            InitializeComponent();
        }
        // Only numbers in key size box
        private void key_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        // Key gen button
        private async void generate_keys_btn_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            if (key_size.Text == "")
            {
                MessageBox.Show("Please, enter key size!");
            }
            else
            {
                console_box.AppendText("Generating keys...");

                await Task.Run(()=>rsa = new Rsa(Convert.ToInt32(key_size.Text)));
                rsa.WriteKeys(_path);

                console_box.AppendText("Keys generated!" + Environment.NewLine);
                console_box.AppendText("Key size: " + key_size.Text + " bytes" + Environment.NewLine + Environment.NewLine);
            }
            Application.UseWaitCursor = false;
        }
        // show keys in different window
        private void show_key_btn_Click(object sender, EventArgs e)
        {            
            if (rsa == null)
            {
                return;
            }
            KeyForm keyForm = new KeyForm();

            keyForm.public_key_box.Text = Convert.ToBase64String(rsa.PublicKey.Item1.ToByteArray());
            keyForm.private_key_box.Text = Convert.ToBase64String(rsa.PrivateKey.Item1.ToByteArray());

            keyForm.Show();
        }

        private void message_file_open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            _file_path = openFileDialog1.FileName;
            _file_bytes = File.ReadAllBytes(_file_path);
            _type = Path.GetExtension(_file_path);

            console_box.AppendText($"File {_file_path} succesfully readed!" + Environment.NewLine + Environment.NewLine);
            console_box.AppendText($"Readed {_file_bytes.Length} bytes" + Environment.NewLine + Environment.NewLine);
            //show_file_btn_Click(sender, e);
        }

        private void show_file_btn_Click(object sender, EventArgs e)
        {           
            if (_type == ".txt")
            {
                MessageForm messageForm = new MessageForm();
                messageForm.message_text.Text = Encoding.UTF8.GetString(_file_bytes);
                messageForm.Show();

            }
            else if(_type == ".png" || _type == ".jpg")
            {
                PictureMessageForm pictureForm = new PictureMessageForm();
                pictureForm.pictureBox1.Image = Image.FromFile(_file_path);
                pictureForm.Show();
            }
        }

        private List<byte[]> asyncEncrypt(List<byte[]> list, ProgressBar bar = null)
        {
            var res = rsa.EncodeListForms(list, bar);            
            console_box.AppendText("Complete!" + Environment.NewLine);

            time_box.Text = res.Item2;

            return res.Item1;
        }
        private List<byte[]> asyncDecrypt(List<byte[]> list, ProgressBar bar = null)
        {
            var res = rsa.DecodeListForms(list, bar);
            console_box.AppendText("Complete!" + Environment.NewLine);
            
            time_box.Text = res.Item2;

            return res.Item1;
        }

        private async void encrypt_btn_Click(object sender, EventArgs e)
        {
            if (rsa == null || _file_path == "")
                return;
            console_box.AppendText("Encrypting...");

            _numberOfBytes = Convert.ToInt32(key_size.Text);
            List<byte[]> encoded_message = null;
            await Task.Run(() => encoded_message = asyncEncrypt(CryptoFunctions.ReadFileBytes(_file_path, _numberOfBytes), progressBar1));

            CryptoFunctions.SetFileBytes(_encoded_path + _type, encoded_message, 2 * _numberOfBytes);

            console_box.AppendText($"Writed {encoded_message.Count * _numberOfBytes * 2} bytes" 
                + Environment.NewLine + Environment.NewLine);
            ShowFile(_encoded_path + _type, true);
        }

        private async void decrypt_btn_Click(object sender, EventArgs e)
        {
            if (rsa == null || _file_path == "" || !File.Exists(_encoded_path + _type))
                return;
            console_box.AppendText("Decrypting...");

            List<byte[]> decoded_message = null;
            try
            {
                await Task.Run(() => decoded_message = asyncDecrypt(CryptoFunctions.ReadFileBytes(_encoded_path + _type, _numberOfBytes * 2), progressBar1));

                int wirtedBytes = CryptoFunctions.SetFileBytes(_decoded_path + _type, decoded_message, _numberOfBytes);

                console_box.AppendText($"Writed {wirtedBytes} bytes"
                    + Environment.NewLine + Environment.NewLine);

                ShowFile(_decoded_path + _type);
            }
            catch { };
        }

        private void ShowFile(string path, bool encoded = false)
        {
            if (_type == ".txt" || encoded)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.message_text.Text = Encoding.UTF8.GetString(File.ReadAllBytes(path));
                messageForm.Show();

            }
            else if (_type == ".png" || _type == ".jpg" && encoded == false)
            {
                PictureMessageForm pictureForm = new PictureMessageForm();
                pictureForm.pictureBox1.Image = Image.FromFile(path);
                pictureForm.Show();
            }
        }

        private void rsa_signature_btn_Click(object sender, EventArgs e)
        {
            if (rsa == null || _file_path == "")
                return;
            console_box.AppendText("Computing rsa e-sig...");

            var sig = rsa.ComputeSignatyre(_file_bytes);
            var fileName = Path.GetFileName(_file_path);
            var name = fileName.Split('.')[0];
            File.WriteAllBytes(@"/Fencrypt/RSA/Signature/" + name + ".sig", sig);

            console_box.AppendText("Complete!" + Environment.NewLine + Environment.NewLine);
            MessageBox.Show($"{sig}");
        }

        private void rsa_signature_check_Click(object sender, EventArgs e)
        {
            if (rsa == null || _file_path == "" || !File.Exists(@"/Fencrypt/RSA/Signature/" + Path.GetFileName(_file_path).Split('.')[0] + ".sig"))
                return;
            console_box.AppendText("Checking e-sig...");

            var readed = File.ReadAllBytes(@"/Fencrypt/RSA/Signature/" + Path.GetFileName(_file_path).Split('.')[0] + ".sig");

            var checker = rsa.CheckSignature(readed, @"/Fencrypt/RSA/Signature/" + Path.GetFileName(_file_path));
            if (checker)
            {
                console_box.AppendText("Complete! Checking True!" + Environment.NewLine + Environment.NewLine);
            }
            else
            {
                console_box.AppendText("Complete! Checking False!" + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("Checking false!", "Attention!");
            }
        }
        //
        //
        //
        // Vernam
        //
        //
        //
        private static string _vernam_encrypted_path = "";
        private static string _vernam_decrypted_path = @"/Fencrypt/Vernam/Decrypted";
        private static string _vernam_key_path = @"/Fencrypt/Vernam/secret.key";
        private async void vernam_encrypt_btn_Click(object sender, EventArgs e)
        {
            if (_file_path == "")
                return;
            try
            {
                byte[] readedKey = File.ReadAllBytes(_vernam_key_path);
                vernam_console_box.AppendText($"Readed {readedKey.Length} bytes" + Environment.NewLine + Environment.NewLine);
                Vernam.SetKey(readedKey);
            }
            catch { };

            vernam_console_box.AppendText("Encrypting...");

            Vernam.Init(Convert.ToInt32(vernam_bytes.Text));
            if (_vernam_key_path == "")
                _vernam_key_path = @"/Fencrypt/Vernam/secret.key";
            File.WriteAllBytes(_vernam_key_path, Vernam.GetKey().ToByteArray());

            int number_bytes = Convert.ToInt32(vernam_bytes.Text);
            Tuple<List<byte[]>, string> message = null;

            List<byte[]> readedBytes = CryptoFunctions.ReadFileBytes(_file_path, number_bytes);
            

            await Task.Run(()=> message = Vernam.EncryptDecryptList(readedBytes, false, vernam_progress_bar));
            _vernam_encrypted_path = @"/Fencrypt/Vernam/Encrypted";
            int writedBytes = CryptoFunctions.SetFileBytes(_vernam_encrypted_path + _type, message.Item1, number_bytes);

            vernam_console_box.AppendText("Complete!" + Environment.NewLine);
            vernam_console_box.AppendText($"Writed {writedBytes} bytes" + Environment.NewLine + Environment.NewLine);

            vernam_time_box.Text = message.Item2;
            ShowFile(_vernam_encrypted_path + _type, true);
        }
        private async void vernam_decrypt_btn_Click(object sender, EventArgs e)
        {
            if (_vernam_encrypted_path == "")
                return;
            try
            {
                byte[] readedKey = File.ReadAllBytes(_vernam_key_path);
                vernam_console_box.AppendText($"Readed {readedKey.Length} bytes" + Environment.NewLine + Environment.NewLine);
                Vernam.SetKey(readedKey);
            }
            catch { };

            vernam_console_box.AppendText("Decrypting...");

            int number_bytes = Convert.ToInt32(vernam_bytes.Text);          
            Tuple<List<byte[]>, string> message = null;
            

            List<byte[]> bytes2Write = CryptoFunctions.ReadFileBytes(_vernam_encrypted_path + _type, number_bytes);
            await Task.Run(() => message = Vernam.EncryptDecryptList(bytes2Write, true, vernam_progress_bar));

            int writedBytes = CryptoFunctions.SetFileBytes(_vernam_decrypted_path + _type, message.Item1, number_bytes);
            if (_vernam_key_path == "")
                _vernam_key_path = @"/Fencrypt/Vernam/secret.key";
            File.WriteAllBytes(_vernam_key_path, Vernam.GetKey().ToByteArray());

            vernam_console_box.AppendText("Complete!" + Environment.NewLine);
            vernam_console_box.AppendText($"Writed {writedBytes} bytes" + Environment.NewLine + Environment.NewLine);
            
            vernam_time_box.Text = message.Item2;
            ShowFile(_vernam_decrypted_path + _type);
        }

        private void vernam_open_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            _file_path = openFileDialog1.FileName;
            _file_bytes = File.ReadAllBytes(_file_path);
            _type = Path.GetExtension(_file_path);

            vernam_console_box.AppendText($"File {_file_path} succesfully readed!" + Environment.NewLine + Environment.NewLine);
            vernam_console_box.AppendText($"Readed {_file_bytes.Length} bytes" + Environment.NewLine + Environment.NewLine);
        }

        private void vernam_show_file_Click(object sender, EventArgs e)
        {
            ShowFile(_file_path);
        }

        private void vernam_key_path_TextChanged(object sender, EventArgs e)
        {
            _vernam_key_path = vernam_key_path.Text;
        }

        private void vernam_key_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            openFileDialog2.Filter = "Ключ-файл формата .key|*.key";
            openFileDialog2.DefaultExt = ".key";
            openFileDialog2.InitialDirectory = @"/Fencrypt/Vernam";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                _vernam_key_path = openFileDialog2.FileName;
                vernam_key_path.Text = _vernam_key_path;
                vernam_console_box.AppendText("Key file successfull opened!" + Environment.NewLine + Environment.NewLine);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"/Fencrypt"))
            {
                Directory.CreateDirectory(@"/Fencrypt/RSA");
                Directory.CreateDirectory(@"/Fencrypt/RSA/Keys");
                Directory.CreateDirectory(@"/Fencrypt/Vernam");
                Directory.CreateDirectory(@"/Fencrypt/Elgamal");
            }
        }
        //
        //
        //
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab.Text == "RSA")
            {
                Process.Start("explorer", @"\Fencrypt\RSA");
            }
            if(tabControl.SelectedTab.Text == "Vernam")
            {
                Process.Start("explorer", @"\Fencrypt\Vernam");
            }
            if(tabControl.SelectedTab.Text == "Shamir")
            {
                Process.Start("explorer", @"\Fencrypt\Shamir");
            }
            if (tabControl.SelectedTab.Text == "Elgamal")
            {
                Process.Start("explorer", @"\Fencrypt\Elgamal");
            }
        }
        //
        //
        // Elgamal
        //
        //
        //
        Elgamal Alice;
        Elgamal Bob;
        List<Tuple<byte[], byte[]>> elgamal_encrypted;        
        private async void elgamal_encrypt_btn_Click(object sender, EventArgs e)
        {
            elgamal_console.AppendText("Encrypting...");

            Elgamal.Init(Convert.ToInt32(elgamal_bytes.Text) * 2);

            Alice = new Elgamal();
            Bob = new Elgamal();

            Elgamal.Swap(Alice, Bob);

            var readed = CryptoFunctions.ReadFileBytes(_file_path, Convert.ToInt32(elgamal_bytes.Text));
            var encrypted = await Task.Run(()=> Alice.EncryptList(readed));
            elgamal_encrypted = encrypted;

            elgamal_console.AppendText("Complete!" + Environment.NewLine);
            //CryptoFunctions.SetFileBytes(@"\Fencrypt\Elgamal\encrypted" + _type, encrypted, Convert.ToInt32(elgamal_bytes.Text) * 4);
        }

        private void elgamal_decrypt_btn_Click(object sender, EventArgs e)
        {
            elgamal_console.AppendText("Decrypting...");

            /*var readed = CryptoFunctions.ReadFileBytes(@"\Fencrypt\Elgamal\encrypted" + _type, Convert.ToInt32(elgamal_bytes.Text) * 4);

            CryptoFunctions.SetFileBytes(@"\Fencrypt\Elgamal\decrypted" + _type, Bob.DecryptList(readed), Convert.ToInt32(elgamal_bytes.Text));
            ShowFile(@"\Fencrypt\Elgamal\decrypted" + _type);*/
            CryptoFunctions.SetFileBytes(@"\Fencrypt\Elgamal\decrypted" + _type, Bob.DecryptList(elgamal_encrypted), Convert.ToInt32(elgamal_bytes.Text));
            elgamal_console.AppendText("Complete!" + Environment.NewLine);
            ShowFile(@"\Fencrypt\Elgamal\decrypted" + _type);

        }

        private void elgamal_open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            _file_path = openFileDialog1.FileName;
            _file_bytes = File.ReadAllBytes(_file_path);
            _type = Path.GetExtension(_file_path);

            elgamal_console.AppendText($"File {_file_path} succesfully readed!" + Environment.NewLine + Environment.NewLine);
            elgamal_console.AppendText($"Readed {_file_bytes.Length} bytes" + Environment.NewLine + Environment.NewLine);
        }

        private void elgamal_show_btn_Click(object sender, EventArgs e)
        {
            ShowFile(_file_path);
        }
        //
        //
        //
        // Shamir
        //
        //
        //
        Shamir a = null;
        Shamir b = null;
        private void shamir_gen_numb_btn_Click(object sender, EventArgs e)
        {
            shamir_message_box.Text = CryptoFunctions.GenerateRandomNumber(Convert.ToInt32(shamir_key_size.Text) - 1).ToString();
        }

        private void shamir_encrypt_btn_Click(object sender, EventArgs e)
        {
            shamir_console.Text = "";
            Shamir.Init(Convert.ToInt32(shamir_key_size.Text));
            a = new Shamir();
            b = new Shamir();

            var res = Shamir.EncryptDecrypt(BigInteger.Parse(shamir_message_box.Text), a, b);

            shamir_console.AppendText($"A: x1 = {a.x1}" + Environment.NewLine);
            shamir_console.AppendText($"Send..." + Environment.NewLine);
            shamir_console.AppendText($"B: x2 = {a.x2}" + Environment.NewLine);
            shamir_console.AppendText($"Send..." + Environment.NewLine);
            shamir_console.AppendText($"A: x3 = {a.x3}" + Environment.NewLine);
            shamir_console.AppendText($"Send..." + Environment.NewLine);
            shamir_console.AppendText($"B: x4 = {b.x4}" + Environment.NewLine);

            shamir_result.Text = res.ToString();
        }

        private void elgamal_signature_btn_Click(object sender, EventArgs e)
        {
            elgamal_console.AppendText("Computing rsa e-sig...");

            var sig = rsa.ComputeSignatyre(_file_bytes);
            var fileName = Path.GetFileName(_file_path);
            var name = fileName.Split('.')[0];
            File.WriteAllBytes(@"/Fencrypt/RSA/Signature/" + name + ".sig", sig);

            console_box.AppendText("Complete!" + Environment.NewLine + Environment.NewLine);
        }
    }
}