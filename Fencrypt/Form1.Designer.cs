
namespace Fencrypt
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRsa = new System.Windows.Forms.TabPage();
            this.console_box = new System.Windows.Forms.TextBox();
            this.time_box = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.show_file_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.message_file_open_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rsa_signature_check = new System.Windows.Forms.Button();
            this.rsa_signature_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.show_key_btn = new System.Windows.Forms.Button();
            this.key_size = new System.Windows.Forms.TextBox();
            this.generate_keys_btn = new System.Windows.Forms.Button();
            this.tabVernam = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.vernam_key_open = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.vernam_key_path = new System.Windows.Forms.TextBox();
            this.vernam_time_box = new System.Windows.Forms.TextBox();
            this.vernam_progress_bar = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.vernam_open_file = new System.Windows.Forms.Button();
            this.vernam_show_file = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vernam_decrypt_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vernam_encrypt_btn = new System.Windows.Forms.Button();
            this.vernam_bytes = new System.Windows.Forms.TextBox();
            this.vernam_console_box = new System.Windows.Forms.TextBox();
            this.tabShamir = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.shamir_key_size = new System.Windows.Forms.TextBox();
            this.shamir_gen_numb_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.shamir_result = new System.Windows.Forms.TextBox();
            this.shamir_encrypt_btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.shamir_message_box = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.shamir_console = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.elgamal_encrypt_btn = new System.Windows.Forms.Button();
            this.elgamal_decrypt_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.elgamal_bytes = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.elgamal_open_btn = new System.Windows.Forms.Button();
            this.elgamal_show_btn = new System.Windows.Forms.Button();
            this.elgamal_console = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.elgamal_signature_btn = new System.Windows.Forms.Button();
            this.elgamal_signature_check = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabRsa.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabVernam.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabShamir.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRsa);
            this.tabControl.Controls.Add(this.tabVernam);
            this.tabControl.Controls.Add(this.tabShamir);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl.Location = new System.Drawing.Point(18, 51);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(540, 657);
            this.tabControl.TabIndex = 0;
            // 
            // tabRsa
            // 
            this.tabRsa.Controls.Add(this.console_box);
            this.tabRsa.Controls.Add(this.time_box);
            this.tabRsa.Controls.Add(this.panel5);
            this.tabRsa.Controls.Add(this.panel4);
            this.tabRsa.Controls.Add(this.panel3);
            this.tabRsa.Controls.Add(this.progressBar1);
            this.tabRsa.Controls.Add(this.panel1);
            this.tabRsa.Location = new System.Drawing.Point(4, 29);
            this.tabRsa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRsa.Name = "tabRsa";
            this.tabRsa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabRsa.Size = new System.Drawing.Size(532, 624);
            this.tabRsa.TabIndex = 0;
            this.tabRsa.Text = "RSA";
            this.tabRsa.UseVisualStyleBackColor = true;
            // 
            // console_box
            // 
            this.console_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.console_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console_box.ForeColor = System.Drawing.Color.Lime;
            this.console_box.Location = new System.Drawing.Point(9, 205);
            this.console_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.console_box.Multiline = true;
            this.console_box.Name = "console_box";
            this.console_box.ReadOnly = true;
            this.console_box.Size = new System.Drawing.Size(508, 304);
            this.console_box.TabIndex = 8;
            // 
            // time_box
            // 
            this.time_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.time_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_box.ForeColor = System.Drawing.Color.Lime;
            this.time_box.Location = new System.Drawing.Point(9, 565);
            this.time_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.time_box.Multiline = true;
            this.time_box.Name = "time_box";
            this.time_box.ReadOnly = true;
            this.time_box.Size = new System.Drawing.Size(508, 35);
            this.time_box.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.show_file_btn);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.message_file_open_btn);
            this.panel5.Location = new System.Drawing.Point(9, 120);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 75);
            this.panel5.TabIndex = 5;
            // 
            // show_file_btn
            // 
            this.show_file_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_file_btn.Location = new System.Drawing.Point(129, 28);
            this.show_file_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_file_btn.Name = "show_file_btn";
            this.show_file_btn.Size = new System.Drawing.Size(112, 35);
            this.show_file_btn.TabIndex = 6;
            this.show_file_btn.Text = "Show file";
            this.show_file_btn.UseVisualStyleBackColor = true;
            this.show_file_btn.Click += new System.EventHandler(this.show_file_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose message";
            // 
            // message_file_open_btn
            // 
            this.message_file_open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message_file_open_btn.Location = new System.Drawing.Point(9, 28);
            this.message_file_open_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.message_file_open_btn.Name = "message_file_open_btn";
            this.message_file_open_btn.Size = new System.Drawing.Size(112, 35);
            this.message_file_open_btn.TabIndex = 4;
            this.message_file_open_btn.Text = "Open file";
            this.message_file_open_btn.UseVisualStyleBackColor = true;
            this.message_file_open_btn.Click += new System.EventHandler(this.message_file_open_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.rsa_signature_check);
            this.panel4.Controls.Add(this.rsa_signature_btn);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(268, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 102);
            this.panel4.TabIndex = 4;
            // 
            // rsa_signature_check
            // 
            this.rsa_signature_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsa_signature_check.Location = new System.Drawing.Point(126, 55);
            this.rsa_signature_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rsa_signature_check.Name = "rsa_signature_check";
            this.rsa_signature_check.Size = new System.Drawing.Size(112, 35);
            this.rsa_signature_check.TabIndex = 7;
            this.rsa_signature_check.Text = "Check";
            this.rsa_signature_check.UseVisualStyleBackColor = true;
            this.rsa_signature_check.Click += new System.EventHandler(this.rsa_signature_check_Click);
            // 
            // rsa_signature_btn
            // 
            this.rsa_signature_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rsa_signature_btn.Location = new System.Drawing.Point(4, 55);
            this.rsa_signature_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rsa_signature_btn.Name = "rsa_signature_btn";
            this.rsa_signature_btn.Size = new System.Drawing.Size(112, 35);
            this.rsa_signature_btn.TabIndex = 4;
            this.rsa_signature_btn.Text = "Compute";
            this.rsa_signature_btn.UseVisualStyleBackColor = true;
            this.rsa_signature_btn.Click += new System.EventHandler(this.rsa_signature_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Signature";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.decrypt_btn);
            this.panel3.Controls.Add(this.encrypt_btn);
            this.panel3.Location = new System.Drawing.Point(268, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 75);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encryption control";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypt_btn.Location = new System.Drawing.Point(126, 28);
            this.decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(112, 35);
            this.decrypt_btn.TabIndex = 4;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt_btn.Location = new System.Drawing.Point(4, 28);
            this.encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(112, 35);
            this.encrypt_btn.TabIndex = 3;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 520);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(510, 35);
            this.progressBar1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.show_key_btn);
            this.panel1.Controls.Add(this.key_size);
            this.panel1.Controls.Add(this.generate_keys_btn);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 102);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key size (bytes):";
            // 
            // show_key_btn
            // 
            this.show_key_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_key_btn.Location = new System.Drawing.Point(129, 55);
            this.show_key_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_key_btn.Name = "show_key_btn";
            this.show_key_btn.Size = new System.Drawing.Size(117, 35);
            this.show_key_btn.TabIndex = 2;
            this.show_key_btn.Text = "Show key";
            this.show_key_btn.UseVisualStyleBackColor = true;
            this.show_key_btn.Click += new System.EventHandler(this.show_key_btn_Click);
            // 
            // key_size
            // 
            this.key_size.Location = new System.Drawing.Point(129, 9);
            this.key_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.key_size.Name = "key_size";
            this.key_size.Size = new System.Drawing.Size(115, 26);
            this.key_size.TabIndex = 1;
            this.key_size.Text = "16";
            this.key_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_size_KeyPress);
            // 
            // generate_keys_btn
            // 
            this.generate_keys_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_keys_btn.Location = new System.Drawing.Point(9, 55);
            this.generate_keys_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generate_keys_btn.Name = "generate_keys_btn";
            this.generate_keys_btn.Size = new System.Drawing.Size(112, 35);
            this.generate_keys_btn.TabIndex = 0;
            this.generate_keys_btn.Text = "Generate";
            this.generate_keys_btn.UseVisualStyleBackColor = true;
            this.generate_keys_btn.Click += new System.EventHandler(this.generate_keys_btn_Click);
            // 
            // tabVernam
            // 
            this.tabVernam.Controls.Add(this.panel7);
            this.tabVernam.Controls.Add(this.vernam_time_box);
            this.tabVernam.Controls.Add(this.vernam_progress_bar);
            this.tabVernam.Controls.Add(this.panel6);
            this.tabVernam.Controls.Add(this.panel2);
            this.tabVernam.Controls.Add(this.vernam_console_box);
            this.tabVernam.Location = new System.Drawing.Point(4, 29);
            this.tabVernam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabVernam.Name = "tabVernam";
            this.tabVernam.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabVernam.Size = new System.Drawing.Size(532, 624);
            this.tabVernam.TabIndex = 1;
            this.tabVernam.Text = "Vernam";
            this.tabVernam.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.vernam_key_open);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.vernam_key_path);
            this.panel7.Location = new System.Drawing.Point(165, 9);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(354, 91);
            this.panel7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter key path or press the button";
            // 
            // vernam_key_open
            // 
            this.vernam_key_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernam_key_open.Location = new System.Drawing.Point(232, 46);
            this.vernam_key_open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_key_open.Name = "vernam_key_open";
            this.vernam_key_open.Size = new System.Drawing.Size(117, 35);
            this.vernam_key_open.TabIndex = 7;
            this.vernam_key_open.Text = "Open key";
            this.vernam_key_open.UseVisualStyleBackColor = true;
            this.vernam_key_open.Click += new System.EventHandler(this.vernam_key_open_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Key path:";
            // 
            // vernam_key_path
            // 
            this.vernam_key_path.Location = new System.Drawing.Point(87, 49);
            this.vernam_key_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_key_path.Name = "vernam_key_path";
            this.vernam_key_path.Size = new System.Drawing.Size(134, 26);
            this.vernam_key_path.TabIndex = 4;
            this.vernam_key_path.TextChanged += new System.EventHandler(this.vernam_key_path_TextChanged);
            // 
            // vernam_time_box
            // 
            this.vernam_time_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.vernam_time_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vernam_time_box.ForeColor = System.Drawing.Color.Lime;
            this.vernam_time_box.Location = new System.Drawing.Point(9, 565);
            this.vernam_time_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_time_box.Multiline = true;
            this.vernam_time_box.Name = "vernam_time_box";
            this.vernam_time_box.ReadOnly = true;
            this.vernam_time_box.Size = new System.Drawing.Size(508, 35);
            this.vernam_time_box.TabIndex = 11;
            // 
            // vernam_progress_bar
            // 
            this.vernam_progress_bar.Location = new System.Drawing.Point(9, 520);
            this.vernam_progress_bar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_progress_bar.Name = "vernam_progress_bar";
            this.vernam_progress_bar.Size = new System.Drawing.Size(510, 35);
            this.vernam_progress_bar.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.vernam_open_file);
            this.panel6.Controls.Add(this.vernam_show_file);
            this.panel6.Location = new System.Drawing.Point(165, 109);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(354, 86);
            this.panel6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "File";
            // 
            // vernam_open_file
            // 
            this.vernam_open_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernam_open_file.Location = new System.Drawing.Point(9, 29);
            this.vernam_open_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_open_file.Name = "vernam_open_file";
            this.vernam_open_file.Size = new System.Drawing.Size(117, 35);
            this.vernam_open_file.TabIndex = 1;
            this.vernam_open_file.Text = "Open file";
            this.vernam_open_file.UseVisualStyleBackColor = true;
            this.vernam_open_file.Click += new System.EventHandler(this.vernam_open_file_Click);
            // 
            // vernam_show_file
            // 
            this.vernam_show_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernam_show_file.Location = new System.Drawing.Point(135, 29);
            this.vernam_show_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_show_file.Name = "vernam_show_file";
            this.vernam_show_file.Size = new System.Drawing.Size(117, 35);
            this.vernam_show_file.TabIndex = 2;
            this.vernam_show_file.Text = "Show file";
            this.vernam_show_file.UseVisualStyleBackColor = true;
            this.vernam_show_file.Click += new System.EventHandler(this.vernam_show_file_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.vernam_decrypt_btn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.vernam_encrypt_btn);
            this.panel2.Controls.Add(this.vernam_bytes);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 186);
            this.panel2.TabIndex = 8;
            // 
            // vernam_decrypt_btn
            // 
            this.vernam_decrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernam_decrypt_btn.Location = new System.Drawing.Point(9, 78);
            this.vernam_decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_decrypt_btn.Name = "vernam_decrypt_btn";
            this.vernam_decrypt_btn.Size = new System.Drawing.Size(129, 35);
            this.vernam_decrypt_btn.TabIndex = 6;
            this.vernam_decrypt_btn.Text = "Decrypt";
            this.vernam_decrypt_btn.UseVisualStyleBackColor = true;
            this.vernam_decrypt_btn.Click += new System.EventHandler(this.vernam_decrypt_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bytes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "NotePad";
            // 
            // vernam_encrypt_btn
            // 
            this.vernam_encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vernam_encrypt_btn.Location = new System.Drawing.Point(9, 34);
            this.vernam_encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_encrypt_btn.Name = "vernam_encrypt_btn";
            this.vernam_encrypt_btn.Size = new System.Drawing.Size(129, 35);
            this.vernam_encrypt_btn.TabIndex = 0;
            this.vernam_encrypt_btn.Text = "Encrypt";
            this.vernam_encrypt_btn.UseVisualStyleBackColor = true;
            this.vernam_encrypt_btn.Click += new System.EventHandler(this.vernam_encrypt_btn_Click);
            // 
            // vernam_bytes
            // 
            this.vernam_bytes.Location = new System.Drawing.Point(68, 132);
            this.vernam_bytes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_bytes.Name = "vernam_bytes";
            this.vernam_bytes.Size = new System.Drawing.Size(68, 26);
            this.vernam_bytes.TabIndex = 4;
            this.vernam_bytes.Text = "1024";
            // 
            // vernam_console_box
            // 
            this.vernam_console_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.vernam_console_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vernam_console_box.ForeColor = System.Drawing.Color.Lime;
            this.vernam_console_box.Location = new System.Drawing.Point(9, 205);
            this.vernam_console_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vernam_console_box.Multiline = true;
            this.vernam_console_box.Name = "vernam_console_box";
            this.vernam_console_box.ReadOnly = true;
            this.vernam_console_box.Size = new System.Drawing.Size(508, 304);
            this.vernam_console_box.TabIndex = 7;
            // 
            // tabShamir
            // 
            this.tabShamir.Controls.Add(this.label15);
            this.tabShamir.Controls.Add(this.shamir_key_size);
            this.tabShamir.Controls.Add(this.shamir_gen_numb_btn);
            this.tabShamir.Controls.Add(this.label14);
            this.tabShamir.Controls.Add(this.shamir_result);
            this.tabShamir.Controls.Add(this.shamir_encrypt_btn);
            this.tabShamir.Controls.Add(this.label13);
            this.tabShamir.Controls.Add(this.shamir_message_box);
            this.tabShamir.Controls.Add(this.textBox4);
            this.tabShamir.Controls.Add(this.progressBar3);
            this.tabShamir.Controls.Add(this.shamir_console);
            this.tabShamir.Location = new System.Drawing.Point(4, 29);
            this.tabShamir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabShamir.Name = "tabShamir";
            this.tabShamir.Size = new System.Drawing.Size(532, 624);
            this.tabShamir.TabIndex = 2;
            this.tabShamir.Text = "Shamir";
            this.tabShamir.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Size (bytes):";
            // 
            // shamir_key_size
            // 
            this.shamir_key_size.Location = new System.Drawing.Point(123, 23);
            this.shamir_key_size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_key_size.Name = "shamir_key_size";
            this.shamir_key_size.Size = new System.Drawing.Size(115, 26);
            this.shamir_key_size.TabIndex = 21;
            this.shamir_key_size.Text = "16";
            this.shamir_key_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_size_KeyPress);
            // 
            // shamir_gen_numb_btn
            // 
            this.shamir_gen_numb_btn.Location = new System.Drawing.Point(201, 103);
            this.shamir_gen_numb_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_gen_numb_btn.Name = "shamir_gen_numb_btn";
            this.shamir_gen_numb_btn.Size = new System.Drawing.Size(154, 34);
            this.shamir_gen_numb_btn.TabIndex = 20;
            this.shamir_gen_numb_btn.Text = "Generate number";
            this.shamir_gen_numb_btn.UseVisualStyleBackColor = true;
            this.shamir_gen_numb_btn.Click += new System.EventHandler(this.shamir_gen_numb_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 158);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Result number:";
            // 
            // shamir_result
            // 
            this.shamir_result.Location = new System.Drawing.Point(123, 154);
            this.shamir_result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_result.Name = "shamir_result";
            this.shamir_result.ReadOnly = true;
            this.shamir_result.Size = new System.Drawing.Size(394, 26);
            this.shamir_result.TabIndex = 18;
            // 
            // shamir_encrypt_btn
            // 
            this.shamir_encrypt_btn.Location = new System.Drawing.Point(364, 103);
            this.shamir_encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_encrypt_btn.Name = "shamir_encrypt_btn";
            this.shamir_encrypt_btn.Size = new System.Drawing.Size(154, 34);
            this.shamir_encrypt_btn.TabIndex = 17;
            this.shamir_encrypt_btn.Text = "Encrypt/Decrypt";
            this.shamir_encrypt_btn.UseVisualStyleBackColor = true;
            this.shamir_encrypt_btn.Click += new System.EventHandler(this.shamir_encrypt_btn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Enter number:";
            // 
            // shamir_message_box
            // 
            this.shamir_message_box.Location = new System.Drawing.Point(123, 63);
            this.shamir_message_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_message_box.Name = "shamir_message_box";
            this.shamir_message_box.Size = new System.Drawing.Size(394, 26);
            this.shamir_message_box.TabIndex = 15;
            this.shamir_message_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_size_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(9, 565);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(508, 35);
            this.textBox4.TabIndex = 14;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(9, 520);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(510, 35);
            this.progressBar3.TabIndex = 13;
            // 
            // shamir_console
            // 
            this.shamir_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.shamir_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shamir_console.ForeColor = System.Drawing.Color.Lime;
            this.shamir_console.Location = new System.Drawing.Point(9, 205);
            this.shamir_console.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shamir_console.Multiline = true;
            this.shamir_console.Name = "shamir_console";
            this.shamir_console.ReadOnly = true;
            this.shamir_console.Size = new System.Drawing.Size(508, 304);
            this.shamir_console.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel10);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.progressBar2);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Controls.Add(this.elgamal_console);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(532, 624);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Elgamal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(9, 565);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(508, 35);
            this.textBox2.TabIndex = 13;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(9, 520);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(510, 35);
            this.progressBar2.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Controls.Add(this.elgamal_encrypt_btn);
            this.panel9.Controls.Add(this.elgamal_decrypt_btn);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.elgamal_bytes);
            this.panel9.Location = new System.Drawing.Point(9, 100);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(510, 95);
            this.panel9.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Encypting";
            // 
            // elgamal_encrypt_btn
            // 
            this.elgamal_encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_encrypt_btn.Location = new System.Drawing.Point(8, 33);
            this.elgamal_encrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_encrypt_btn.Name = "elgamal_encrypt_btn";
            this.elgamal_encrypt_btn.Size = new System.Drawing.Size(117, 35);
            this.elgamal_encrypt_btn.TabIndex = 3;
            this.elgamal_encrypt_btn.Text = "Encrypt";
            this.elgamal_encrypt_btn.UseVisualStyleBackColor = true;
            this.elgamal_encrypt_btn.Click += new System.EventHandler(this.elgamal_encrypt_btn_Click);
            // 
            // elgamal_decrypt_btn
            // 
            this.elgamal_decrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_decrypt_btn.Location = new System.Drawing.Point(133, 33);
            this.elgamal_decrypt_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_decrypt_btn.Name = "elgamal_decrypt_btn";
            this.elgamal_decrypt_btn.Size = new System.Drawing.Size(117, 35);
            this.elgamal_decrypt_btn.TabIndex = 4;
            this.elgamal_decrypt_btn.Text = "Decrypt";
            this.elgamal_decrypt_btn.UseVisualStyleBackColor = true;
            this.elgamal_decrypt_btn.Click += new System.EventHandler(this.elgamal_decrypt_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Key size (bytes):";
            // 
            // elgamal_bytes
            // 
            this.elgamal_bytes.Location = new System.Drawing.Point(416, 37);
            this.elgamal_bytes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_bytes.Name = "elgamal_bytes";
            this.elgamal_bytes.Size = new System.Drawing.Size(88, 26);
            this.elgamal_bytes.TabIndex = 5;
            this.elgamal_bytes.Text = "16";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.elgamal_open_btn);
            this.panel8.Controls.Add(this.elgamal_show_btn);
            this.panel8.Location = new System.Drawing.Point(9, 5);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 85);
            this.panel8.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "File";
            // 
            // elgamal_open_btn
            // 
            this.elgamal_open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_open_btn.Location = new System.Drawing.Point(8, 30);
            this.elgamal_open_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_open_btn.Name = "elgamal_open_btn";
            this.elgamal_open_btn.Size = new System.Drawing.Size(117, 35);
            this.elgamal_open_btn.TabIndex = 1;
            this.elgamal_open_btn.Text = "Open file";
            this.elgamal_open_btn.UseVisualStyleBackColor = true;
            this.elgamal_open_btn.Click += new System.EventHandler(this.elgamal_open_btn_Click);
            // 
            // elgamal_show_btn
            // 
            this.elgamal_show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_show_btn.Location = new System.Drawing.Point(133, 30);
            this.elgamal_show_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_show_btn.Name = "elgamal_show_btn";
            this.elgamal_show_btn.Size = new System.Drawing.Size(117, 35);
            this.elgamal_show_btn.TabIndex = 2;
            this.elgamal_show_btn.Text = "Show file";
            this.elgamal_show_btn.UseVisualStyleBackColor = true;
            this.elgamal_show_btn.Click += new System.EventHandler(this.elgamal_show_btn_Click);
            // 
            // elgamal_console
            // 
            this.elgamal_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.elgamal_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elgamal_console.ForeColor = System.Drawing.Color.Lime;
            this.elgamal_console.Location = new System.Drawing.Point(9, 205);
            this.elgamal_console.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_console.Multiline = true;
            this.elgamal_console.Name = "elgamal_console";
            this.elgamal_console.ReadOnly = true;
            this.elgamal_console.Size = new System.Drawing.Size(508, 304);
            this.elgamal_console.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "test.txt";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "secret.key";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(576, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Controls.Add(this.elgamal_signature_check);
            this.panel10.Controls.Add(this.elgamal_signature_btn);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Location = new System.Drawing.Point(279, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 85);
            this.panel10.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "E-Signature";
            // 
            // elgamal_signature_btn
            // 
            this.elgamal_signature_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_signature_btn.Location = new System.Drawing.Point(4, 30);
            this.elgamal_signature_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_signature_btn.Name = "elgamal_signature_btn";
            this.elgamal_signature_btn.Size = new System.Drawing.Size(112, 35);
            this.elgamal_signature_btn.TabIndex = 5;
            this.elgamal_signature_btn.Text = "Compute";
            this.elgamal_signature_btn.UseVisualStyleBackColor = true;
            this.elgamal_signature_btn.Click += new System.EventHandler(this.elgamal_signature_btn_Click);
            // 
            // elgamal_signature_check
            // 
            this.elgamal_signature_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elgamal_signature_check.Location = new System.Drawing.Point(122, 30);
            this.elgamal_signature_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elgamal_signature_check.Name = "elgamal_signature_check";
            this.elgamal_signature_check.Size = new System.Drawing.Size(112, 35);
            this.elgamal_signature_check.TabIndex = 8;
            this.elgamal_signature_check.Text = "Check";
            this.elgamal_signature_check.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(576, 726);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fencrypt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRsa.ResumeLayout(false);
            this.tabRsa.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabVernam.ResumeLayout(false);
            this.tabVernam.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabShamir.ResumeLayout(false);
            this.tabShamir.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRsa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_key_btn;
        private System.Windows.Forms.TextBox key_size;
        private System.Windows.Forms.Button generate_keys_btn;
        private System.Windows.Forms.TabPage tabVernam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button show_file_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button message_file_open_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox time_box;
        private System.Windows.Forms.TabPage tabShamir;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button vernam_show_file;
        private System.Windows.Forms.Button vernam_open_file;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button vernam_encrypt_btn;
        private System.Windows.Forms.TextBox vernam_console_box;
        private System.Windows.Forms.TextBox vernam_time_box;
        private System.Windows.Forms.ProgressBar vernam_progress_bar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox vernam_bytes;
        private System.Windows.Forms.Button vernam_decrypt_btn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vernam_key_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button vernam_key_open;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox elgamal_bytes;
        private System.Windows.Forms.Button elgamal_decrypt_btn;
        private System.Windows.Forms.Button elgamal_encrypt_btn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.TextBox shamir_console;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button elgamal_open_btn;
        private System.Windows.Forms.Button elgamal_show_btn;
        private System.Windows.Forms.TextBox elgamal_console;
        private System.Windows.Forms.TextBox shamir_message_box;
        private System.Windows.Forms.Button shamir_gen_numb_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox shamir_result;
        private System.Windows.Forms.Button shamir_encrypt_btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox shamir_key_size;
        private System.Windows.Forms.Button rsa_signature_check;
        private System.Windows.Forms.Button rsa_signature_btn;
        private System.Windows.Forms.TextBox console_box;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button elgamal_signature_check;
        private System.Windows.Forms.Button elgamal_signature_btn;
        private System.Windows.Forms.Label label16;
    }
}

