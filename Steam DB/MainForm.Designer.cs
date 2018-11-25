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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
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
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.labelIdade = new System.Windows.Forms.Label();
            this.txtMetacritic = new System.Windows.Forms.TextBox();
            this.labelMeta = new System.Windows.Forms.Label();
            this.txtRecomend = new System.Windows.Forms.TextBox();
            this.labelRecomend = new System.Windows.Forms.Label();
            this.labelFilters = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOrderBy = new System.Windows.Forms.Label();
            this.cboxOrderBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 576);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(400, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBoxType.Location = new System.Drawing.Point(109, 91);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(399, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 4;
            // 
            // checkSuppContrl
            // 
            this.checkSuppContrl.AutoSize = true;
            this.checkSuppContrl.Location = new System.Drawing.Point(427, 126);
            this.checkSuppContrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSuppContrl.Name = "checkSuppContrl";
            this.checkSuppContrl.Size = new System.Drawing.Size(145, 21);
            this.checkSuppContrl.TabIndex = 5;
            this.checkSuppContrl.Text = "Controller Support";
            this.checkSuppContrl.UseVisualStyleBackColor = true;
            // 
            // checkWindows
            // 
            this.checkWindows.AutoSize = true;
            this.checkWindows.Location = new System.Drawing.Point(427, 152);
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
            this.checkLinux.Location = new System.Drawing.Point(576, 126);
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
            this.checkMac.Location = new System.Drawing.Point(576, 154);
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
            this.checkSinglePlayer.Location = new System.Drawing.Point(664, 126);
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
            this.checkMulti.Location = new System.Drawing.Point(664, 154);
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
            this.checkMultiCoop.Location = new System.Drawing.Point(792, 126);
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
            this.checkEditNiveis.Location = new System.Drawing.Point(792, 153);
            this.checkEditNiveis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkEditNiveis.Name = "checkEditNiveis";
            this.checkEditNiveis.Size = new System.Drawing.Size(105, 21);
            this.checkEditNiveis.TabIndex = 12;
            this.checkEditNiveis.Text = "Level Editor";
            this.checkEditNiveis.UseVisualStyleBackColor = true;
            // 
            // checkVR
            // 
            this.checkVR.AutoSize = true;
            this.checkVR.Location = new System.Drawing.Point(920, 126);
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
            this.lblID.Location = new System.Drawing.Point(372, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(348, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(1050, 36);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(87, 39);
            this.buttonFilter.TabIndex = 16;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilterClick);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(109, 62);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxValue.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(639, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(539, 47);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(94, 17);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "Release Date";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(639, 80);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(103, 22);
            this.txtIdade.TabIndex = 20;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(599, 80);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(33, 17);
            this.labelIdade.TabIndex = 21;
            this.labelIdade.Text = "Age";
            // 
            // txtMetacritic
            // 
            this.txtMetacritic.Location = new System.Drawing.Point(884, 44);
            this.txtMetacritic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetacritic.Name = "txtMetacritic";
            this.txtMetacritic.Size = new System.Drawing.Size(100, 22);
            this.txtMetacritic.TabIndex = 22;
            // 
            // labelMeta
            // 
            this.labelMeta.AutoSize = true;
            this.labelMeta.Location = new System.Drawing.Point(765, 47);
            this.labelMeta.Name = "labelMeta";
            this.labelMeta.Size = new System.Drawing.Size(113, 17);
            this.labelMeta.TabIndex = 23;
            this.labelMeta.Text = "Metacritic Rating";
            // 
            // txtRecomend
            // 
            this.txtRecomend.Location = new System.Drawing.Point(884, 78);
            this.txtRecomend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecomend.Name = "txtRecomend";
            this.txtRecomend.Size = new System.Drawing.Size(100, 22);
            this.txtRecomend.TabIndex = 24;
            // 
            // labelRecomend
            // 
            this.labelRecomend.AutoSize = true;
            this.labelRecomend.Location = new System.Drawing.Point(764, 81);
            this.labelRecomend.Name = "labelRecomend";
            this.labelRecomend.Size = new System.Drawing.Size(114, 17);
            this.labelRecomend.TabIndex = 25;
            this.labelRecomend.Text = "Recomendations";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(685, 12);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(158, 17);
            this.labelFilters.TabIndex = 26;
            this.labelFilters.Text = "Search in the DataBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Show information about a Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(59, 65);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(44, 17);
            this.labelValue.TabIndex = 28;
            this.labelValue.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Type";
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Location = new System.Drawing.Point(1047, 110);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(65, 17);
            this.labelOrderBy.TabIndex = 30;
            this.labelOrderBy.Text = "Order By";
            // 
            // cboxOrderBy
            // 
            this.cboxOrderBy.FormattingEnabled = true;
            this.cboxOrderBy.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Release Date",
            "Number of DLC´s",
            "Metacritic",
            "Recommendations",
            "People who have",
            "People who play",
            "Achievements"});
            this.cboxOrderBy.Location = new System.Drawing.Point(1013, 138);
            this.cboxOrderBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxOrderBy.Name = "cboxOrderBy";
            this.cboxOrderBy.Size = new System.Drawing.Size(131, 24);
            this.cboxOrderBy.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(309, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 166);
            this.label3.TabIndex = 32;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(109, 140);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 28);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Show Details";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 774);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxOrderBy);
            this.Controls.Add(this.labelOrderBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.labelRecomend);
            this.Controls.Add(this.txtRecomend);
            this.Controls.Add(this.labelMeta);
            this.Controls.Add(this.txtMetacritic);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonFilter);
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
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Steam DB";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboBoxType;
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
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox txtMetacritic;
        private System.Windows.Forms.Label labelMeta;
        private System.Windows.Forms.TextBox txtRecomend;
        private System.Windows.Forms.Label labelRecomend;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOrderBy;
        private System.Windows.Forms.ComboBox cboxOrderBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
    }
}

