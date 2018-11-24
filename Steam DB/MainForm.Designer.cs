namespace Steam_DB {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.checkSuppContrl = new System.Windows.Forms.CheckBox();
            this.checkWindows = new System.Windows.Forms.CheckBox();
            this.checkLinux = new System.Windows.Forms.CheckBox();
            this.checkMac = new System.Windows.Forms.CheckBox();
            this.checkSinglePlayer = new System.Windows.Forms.CheckBox();
            this.checkMulti = new System.Windows.Forms.CheckBox();
            this.checkMultiCoop = new System.Windows.Forms.CheckBox();
            this.checkEditNiveis = new System.Windows.Forms.CheckBox();
            this.checkVR = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(438, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(245, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(438, 5);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // checkSuppContrl
            // 
            this.checkSuppContrl.AutoSize = true;
            this.checkSuppContrl.Location = new System.Drawing.Point(403, 52);
            this.checkSuppContrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkSuppContrl.Name = "checkSuppContrl";
            this.checkSuppContrl.Size = new System.Drawing.Size(99, 17);
            this.checkSuppContrl.TabIndex = 5;
            this.checkSuppContrl.Text = "Suporte Control";
            this.checkSuppContrl.UseVisualStyleBackColor = true;
            // 
            // checkWindows
            // 
            this.checkWindows.AutoSize = true;
            this.checkWindows.Checked = true;
            this.checkWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWindows.Location = new System.Drawing.Point(403, 73);
            this.checkWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkWindows.Name = "checkWindows";
            this.checkWindows.Size = new System.Drawing.Size(70, 17);
            this.checkWindows.TabIndex = 6;
            this.checkWindows.Text = "Windows";
            this.checkWindows.UseVisualStyleBackColor = true;
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.Location = new System.Drawing.Point(514, 52);
            this.checkLinux.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(51, 17);
            this.checkLinux.TabIndex = 7;
            this.checkLinux.Text = "Linux";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkMac
            // 
            this.checkMac.AutoSize = true;
            this.checkMac.Location = new System.Drawing.Point(514, 75);
            this.checkMac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMac.Name = "checkMac";
            this.checkMac.Size = new System.Drawing.Size(47, 17);
            this.checkMac.TabIndex = 8;
            this.checkMac.Text = "Mac";
            this.checkMac.UseVisualStyleBackColor = true;
            // 
            // checkSinglePlayer
            // 
            this.checkSinglePlayer.AutoSize = true;
            this.checkSinglePlayer.Location = new System.Drawing.Point(580, 52);
            this.checkSinglePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkSinglePlayer.Name = "checkSinglePlayer";
            this.checkSinglePlayer.Size = new System.Drawing.Size(84, 17);
            this.checkSinglePlayer.TabIndex = 9;
            this.checkSinglePlayer.Text = "SinglePlayer";
            this.checkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // checkMulti
            // 
            this.checkMulti.AutoSize = true;
            this.checkMulti.Location = new System.Drawing.Point(580, 75);
            this.checkMulti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(77, 17);
            this.checkMulti.TabIndex = 10;
            this.checkMulti.Text = "MultiPlayer";
            this.checkMulti.UseVisualStyleBackColor = true;
            // 
            // checkMultiCoop
            // 
            this.checkMultiCoop.AutoSize = true;
            this.checkMultiCoop.Location = new System.Drawing.Point(676, 52);
            this.checkMultiCoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkMultiCoop.Name = "checkMultiCoop";
            this.checkMultiCoop.Size = new System.Drawing.Size(89, 17);
            this.checkMultiCoop.TabIndex = 11;
            this.checkMultiCoop.Text = "Multi P. Coop";
            this.checkMultiCoop.UseVisualStyleBackColor = true;
            // 
            // checkEditNiveis
            // 
            this.checkEditNiveis.AutoSize = true;
            this.checkEditNiveis.Location = new System.Drawing.Point(676, 74);
            this.checkEditNiveis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkEditNiveis.Name = "checkEditNiveis";
            this.checkEditNiveis.Size = new System.Drawing.Size(85, 17);
            this.checkEditNiveis.TabIndex = 12;
            this.checkEditNiveis.Text = "Editor Niveis";
            this.checkEditNiveis.UseVisualStyleBackColor = true;
            // 
            // checkVR
            // 
            this.checkVR.AutoSize = true;
            this.checkVR.Location = new System.Drawing.Point(772, 52);
            this.checkVR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkVR.Name = "checkVR";
            this.checkVR.Size = new System.Drawing.Size(41, 17);
            this.checkVR.TabIndex = 13;
            this.checkVR.Text = "VR";
            this.checkVR.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(410, 7);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(400, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(855, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(658, 7);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 572);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.checkVR);
            this.Controls.Add(this.checkEditNiveis);
            this.Controls.Add(this.checkMultiCoop);
            this.Controls.Add(this.checkMulti);
            this.Controls.Add(this.checkSinglePlayer);
            this.Controls.Add(this.checkMac);
            this.Controls.Add(this.checkLinux);
            this.Controls.Add(this.checkWindows);
            this.Controls.Add(this.checkSuppContrl);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Steam DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox checkSuppContrl;
        private System.Windows.Forms.CheckBox checkWindows;
        private System.Windows.Forms.CheckBox checkLinux;
        private System.Windows.Forms.CheckBox checkMac;
        private System.Windows.Forms.CheckBox checkSinglePlayer;
        private System.Windows.Forms.CheckBox checkMulti;
        private System.Windows.Forms.CheckBox checkMultiCoop;
        private System.Windows.Forms.CheckBox checkEditNiveis;
        private System.Windows.Forms.CheckBox checkVR;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

