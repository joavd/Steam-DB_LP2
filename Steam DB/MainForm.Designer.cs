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
            this.labelData = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.labelIdade = new System.Windows.Forms.Label();
            this.txtMetacritic = new System.Windows.Forms.TextBox();
            this.labelMeta = new System.Windows.Forms.Label();
            this.txtRecomend = new System.Windows.Forms.TextBox();
            this.labelRecomend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 571);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(482, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(61, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(482, 4);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 4;
            // 
            // checkSuppContrl
            // 
            this.checkSuppContrl.AutoSize = true;
            this.checkSuppContrl.Location = new System.Drawing.Point(481, 64);
            this.checkSuppContrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSuppContrl.Name = "checkSuppContrl";
            this.checkSuppContrl.Size = new System.Drawing.Size(129, 21);
            this.checkSuppContrl.TabIndex = 5;
            this.checkSuppContrl.Text = "Suporte Control";
            this.checkSuppContrl.UseVisualStyleBackColor = true;
            // 
            // checkWindows
            // 
            this.checkWindows.AutoSize = true;
            this.checkWindows.Checked = true;
            this.checkWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWindows.Location = new System.Drawing.Point(481, 90);
            this.checkWindows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkWindows.Name = "checkWindows";
            this.checkWindows.Size = new System.Drawing.Size(86, 21);
            this.checkWindows.TabIndex = 6;
            this.checkWindows.Text = "Windows";
            this.checkWindows.UseVisualStyleBackColor = true;
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.Location = new System.Drawing.Point(629, 64);
            this.checkLinux.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(63, 21);
            this.checkLinux.TabIndex = 7;
            this.checkLinux.Text = "Linux";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkMac
            // 
            this.checkMac.AutoSize = true;
            this.checkMac.Location = new System.Drawing.Point(629, 92);
            this.checkMac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMac.Name = "checkMac";
            this.checkMac.Size = new System.Drawing.Size(56, 21);
            this.checkMac.TabIndex = 8;
            this.checkMac.Text = "Mac";
            this.checkMac.UseVisualStyleBackColor = true;
            // 
            // checkSinglePlayer
            // 
            this.checkSinglePlayer.AutoSize = true;
            this.checkSinglePlayer.Location = new System.Drawing.Point(717, 64);
            this.checkSinglePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSinglePlayer.Name = "checkSinglePlayer";
            this.checkSinglePlayer.Size = new System.Drawing.Size(109, 21);
            this.checkSinglePlayer.TabIndex = 9;
            this.checkSinglePlayer.Text = "SinglePlayer";
            this.checkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // checkMulti
            // 
            this.checkMulti.AutoSize = true;
            this.checkMulti.Location = new System.Drawing.Point(717, 92);
            this.checkMulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(99, 21);
            this.checkMulti.TabIndex = 10;
            this.checkMulti.Text = "MultiPlayer";
            this.checkMulti.UseVisualStyleBackColor = true;
            // 
            // checkMultiCoop
            // 
            this.checkMultiCoop.AutoSize = true;
            this.checkMultiCoop.Location = new System.Drawing.Point(845, 64);
            this.checkMultiCoop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMultiCoop.Name = "checkMultiCoop";
            this.checkMultiCoop.Size = new System.Drawing.Size(113, 21);
            this.checkMultiCoop.TabIndex = 11;
            this.checkMultiCoop.Text = "Multi P. Coop";
            this.checkMultiCoop.UseVisualStyleBackColor = true;
            // 
            // checkEditNiveis
            // 
            this.checkEditNiveis.AutoSize = true;
            this.checkEditNiveis.Location = new System.Drawing.Point(845, 91);
            this.checkEditNiveis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEditNiveis.Name = "checkEditNiveis";
            this.checkEditNiveis.Size = new System.Drawing.Size(109, 21);
            this.checkEditNiveis.TabIndex = 12;
            this.checkEditNiveis.Text = "Editor Niveis";
            this.checkEditNiveis.UseVisualStyleBackColor = true;
            // 
            // checkVR
            // 
            this.checkVR.AutoSize = true;
            this.checkVR.Location = new System.Drawing.Point(973, 64);
            this.checkVR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkVR.Name = "checkVR";
            this.checkVR.Size = new System.Drawing.Size(49, 21);
            this.checkVR.TabIndex = 13;
            this.checkVR.Text = "VR";
            this.checkVR.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(441, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(430, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1140, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(691, 4);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(647, 7);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 17);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "Data";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(691, 34);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(102, 22);
            this.txtIdade.TabIndex = 20;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(639, 37);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(43, 17);
            this.labelIdade.TabIndex = 21;
            this.labelIdade.Text = "Idade";
            // 
            // txtMetacritic
            // 
            this.txtMetacritic.Location = new System.Drawing.Point(928, 4);
            this.txtMetacritic.Name = "txtMetacritic";
            this.txtMetacritic.Size = new System.Drawing.Size(100, 22);
            this.txtMetacritic.TabIndex = 22;
            // 
            // labelMeta
            // 
            this.labelMeta.AutoSize = true;
            this.labelMeta.Location = new System.Drawing.Point(842, 7);
            this.labelMeta.Name = "labelMeta";
            this.labelMeta.Size = new System.Drawing.Size(68, 17);
            this.labelMeta.TabIndex = 23;
            this.labelMeta.Text = "Metacritic";
            // 
            // txtRecomend
            // 
            this.txtRecomend.Location = new System.Drawing.Point(928, 32);
            this.txtRecomend.Name = "txtRecomend";
            this.txtRecomend.Size = new System.Drawing.Size(100, 22);
            this.txtRecomend.TabIndex = 24;
            // 
            // labelRecomend
            // 
            this.labelRecomend.AutoSize = true;
            this.labelRecomend.Location = new System.Drawing.Point(808, 34);
            this.labelRecomend.Name = "labelRecomend";
            this.labelRecomend.Size = new System.Drawing.Size(114, 17);
            this.labelRecomend.TabIndex = 25;
            this.labelRecomend.Text = "Recomendaçoes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 704);
            this.Controls.Add(this.labelRecomend);
            this.Controls.Add(this.txtRecomend);
            this.Controls.Add(this.labelMeta);
            this.Controls.Add(this.txtMetacritic);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.labelData);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox txtMetacritic;
        private System.Windows.Forms.Label labelMeta;
        private System.Windows.Forms.TextBox txtRecomend;
        private System.Windows.Forms.Label labelRecomend;
    }
}

