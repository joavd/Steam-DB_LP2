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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboxType = new System.Windows.Forms.ComboBox();
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
            this.cboxOrder = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(8, 149);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(930, 468);
            this.dataGrid.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(457, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 2;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cboxType.Location = new System.Drawing.Point(82, 74);
            this.cboxType.Margin = new System.Windows.Forms.Padding(2);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(92, 21);
            this.cboxType.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(314, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(69, 20);
            this.txtID.TabIndex = 4;
            // 
            // checkSuppContrl
            // 
            this.checkSuppContrl.AutoSize = true;
            this.checkSuppContrl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSuppContrl.Location = new System.Drawing.Point(264, 102);
            this.checkSuppContrl.Margin = new System.Windows.Forms.Padding(2);
            this.checkSuppContrl.Name = "checkSuppContrl";
            this.checkSuppContrl.Size = new System.Drawing.Size(110, 17);
            this.checkSuppContrl.TabIndex = 5;
            this.checkSuppContrl.Text = "Controller Support";
            this.checkSuppContrl.UseVisualStyleBackColor = true;
            // 
            // checkWindows
            // 
            this.checkWindows.AutoSize = true;
            this.checkWindows.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkWindows.Location = new System.Drawing.Point(304, 123);
            this.checkWindows.Margin = new System.Windows.Forms.Padding(2);
            this.checkWindows.Name = "checkWindows";
            this.checkWindows.Size = new System.Drawing.Size(70, 17);
            this.checkWindows.TabIndex = 6;
            this.checkWindows.Text = "Windows";
            this.checkWindows.UseVisualStyleBackColor = true;
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkLinux.Location = new System.Drawing.Point(391, 102);
            this.checkLinux.Margin = new System.Windows.Forms.Padding(2);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(51, 17);
            this.checkLinux.TabIndex = 7;
            this.checkLinux.Text = "Linux";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkMac
            // 
            this.checkMac.AutoSize = true;
            this.checkMac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkMac.Location = new System.Drawing.Point(395, 125);
            this.checkMac.Margin = new System.Windows.Forms.Padding(2);
            this.checkMac.Name = "checkMac";
            this.checkMac.Size = new System.Drawing.Size(47, 17);
            this.checkMac.TabIndex = 8;
            this.checkMac.Text = "Mac";
            this.checkMac.UseVisualStyleBackColor = true;
            // 
            // checkSinglePlayer
            // 
            this.checkSinglePlayer.AutoSize = true;
            this.checkSinglePlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkSinglePlayer.Location = new System.Drawing.Point(457, 102);
            this.checkSinglePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.checkSinglePlayer.Name = "checkSinglePlayer";
            this.checkSinglePlayer.Size = new System.Drawing.Size(84, 17);
            this.checkSinglePlayer.TabIndex = 9;
            this.checkSinglePlayer.Text = "SinglePlayer";
            this.checkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // checkMulti
            // 
            this.checkMulti.AutoSize = true;
            this.checkMulti.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkMulti.Location = new System.Drawing.Point(464, 123);
            this.checkMulti.Margin = new System.Windows.Forms.Padding(2);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(77, 17);
            this.checkMulti.TabIndex = 10;
            this.checkMulti.Text = "MultiPlayer";
            this.checkMulti.UseVisualStyleBackColor = true;
            // 
            // checkMultiCoop
            // 
            this.checkMultiCoop.AutoSize = true;
            this.checkMultiCoop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkMultiCoop.Location = new System.Drawing.Point(561, 103);
            this.checkMultiCoop.Margin = new System.Windows.Forms.Padding(2);
            this.checkMultiCoop.Name = "checkMultiCoop";
            this.checkMultiCoop.Size = new System.Drawing.Size(89, 17);
            this.checkMultiCoop.TabIndex = 11;
            this.checkMultiCoop.Text = "Multi P. Coop";
            this.checkMultiCoop.UseVisualStyleBackColor = true;
            // 
            // checkEditNiveis
            // 
            this.checkEditNiveis.AutoSize = true;
            this.checkEditNiveis.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkEditNiveis.Location = new System.Drawing.Point(568, 123);
            this.checkEditNiveis.Margin = new System.Windows.Forms.Padding(2);
            this.checkEditNiveis.Name = "checkEditNiveis";
            this.checkEditNiveis.Size = new System.Drawing.Size(82, 17);
            this.checkEditNiveis.TabIndex = 12;
            this.checkEditNiveis.Text = "Level Editor";
            this.checkEditNiveis.UseVisualStyleBackColor = true;
            // 
            // checkVR
            // 
            this.checkVR.AutoSize = true;
            this.checkVR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkVR.Location = new System.Drawing.Point(674, 103);
            this.checkVR.Margin = new System.Windows.Forms.Padding(2);
            this.checkVR.Name = "checkVR";
            this.checkVR.Size = new System.Drawing.Size(41, 17);
            this.checkVR.TabIndex = 13;
            this.checkVR.Text = "VR";
            this.checkVR.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(292, 39);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(417, 38);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(786, 114);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(65, 23);
            this.buttonFilter.TabIndex = 16;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilterClick);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(82, 50);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(92, 20);
            this.textBoxValue.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(457, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(382, 65);
            this.labelData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(72, 13);
            this.labelData.TabIndex = 19;
            this.labelData.Text = "Release Date";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(314, 63);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(69, 20);
            this.txtIdade.TabIndex = 20;
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(239, 66);
            this.labelIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(72, 13);
            this.labelIdade.TabIndex = 21;
            this.labelIdade.Text = "Age Required";
            // 
            // txtMetacritic
            // 
            this.txtMetacritic.Location = new System.Drawing.Point(706, 35);
            this.txtMetacritic.Margin = new System.Windows.Forms.Padding(2);
            this.txtMetacritic.Name = "txtMetacritic";
            this.txtMetacritic.Size = new System.Drawing.Size(69, 20);
            this.txtMetacritic.TabIndex = 22;
            // 
            // labelMeta
            // 
            this.labelMeta.AutoSize = true;
            this.labelMeta.Location = new System.Drawing.Point(615, 38);
            this.labelMeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMeta.Name = "labelMeta";
            this.labelMeta.Size = new System.Drawing.Size(87, 13);
            this.labelMeta.TabIndex = 23;
            this.labelMeta.Text = "Metacritic Rating";
            // 
            // txtRecomend
            // 
            this.txtRecomend.Location = new System.Drawing.Point(706, 65);
            this.txtRecomend.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecomend.Name = "txtRecomend";
            this.txtRecomend.Size = new System.Drawing.Size(69, 20);
            this.txtRecomend.TabIndex = 24;
            // 
            // labelRecomend
            // 
            this.labelRecomend.AutoSize = true;
            this.labelRecomend.Location = new System.Drawing.Point(615, 68);
            this.labelRecomend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecomend.Name = "labelRecomend";
            this.labelRecomend.Size = new System.Drawing.Size(87, 13);
            this.labelRecomend.TabIndex = 25;
            this.labelRecomend.Text = "Recomendations";
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(514, 10);
            this.labelFilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(136, 15);
            this.labelFilters.TabIndex = 26;
            this.labelFilters.Text = "Search in the DataBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Show information about a Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(44, 53);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 28;
            this.labelValue.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Type";
            // 
            // labelOrderBy
            // 
            this.labelOrderBy.AutoSize = true;
            this.labelOrderBy.Location = new System.Drawing.Point(843, 9);
            this.labelOrderBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderBy.Name = "labelOrderBy";
            this.labelOrderBy.Size = new System.Drawing.Size(48, 13);
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
            this.cboxOrderBy.Location = new System.Drawing.Point(816, 35);
            this.cboxOrderBy.Margin = new System.Windows.Forms.Padding(2);
            this.cboxOrderBy.Name = "cboxOrderBy";
            this.cboxOrderBy.Size = new System.Drawing.Size(99, 21);
            this.cboxOrderBy.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(232, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 135);
            this.label3.TabIndex = 32;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(82, 114);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 23);
            this.buttonSearch.TabIndex = 33;
            this.buttonSearch.Text = "Show Details";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // cboxOrder
            // 
            this.cboxOrder.FormattingEnabled = true;
            this.cboxOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cboxOrder.Location = new System.Drawing.Point(816, 64);
            this.cboxOrder.Margin = new System.Windows.Forms.Padding(2);
            this.cboxOrder.Name = "cboxOrder";
            this.cboxOrder.Size = new System.Drawing.Size(99, 21);
            this.cboxOrder.TabIndex = 34;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(864, 114);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(74, 23);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 629);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.cboxOrder);
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
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Steam DB";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboxType;
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
        private System.Windows.Forms.ComboBox cboxOrder;
        private System.Windows.Forms.Button buttonClear;
    }
}

