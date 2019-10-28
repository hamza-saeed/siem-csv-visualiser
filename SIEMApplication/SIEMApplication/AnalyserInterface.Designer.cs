namespace SIEMApplication
{
    partial class AnalyserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDelimiter = new System.Windows.Forms.ComboBox();
            this.txtHash = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboColumn = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpChartType = new System.Windows.Forms.GroupBox();
            this.radioBar = new System.Windows.Forms.RadioButton();
            this.radioColumn = new System.Windows.Forms.RadioButton();
            this.radioPie = new System.Windows.Forms.RadioButton();
            this.radioPyramid = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHashMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpChartType.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFrequency
            // 
            chartArea7.Name = "ChartArea1";
            this.chartFrequency.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartFrequency.Legends.Add(legend7);
            this.chartFrequency.Location = new System.Drawing.Point(15, 376);
            this.chartFrequency.Name = "chartFrequency";
            this.chartFrequency.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.BorderColor = System.Drawing.Color.ForestGreen;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.Color = System.Drawing.Color.Purple;
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.Name = "Frequency";
            series7.YValuesPerPoint = 6;
            this.chartFrequency.Series.Add(series7);
            this.chartFrequency.Size = new System.Drawing.Size(625, 271);
            this.chartFrequency.TabIndex = 0;
            this.chartFrequency.Text = "chart1";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(92, 41);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(335, 25);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(450, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHashMessage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDelimiter);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtHash);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 194);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Delimiter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "MD5 Hash:";
            // 
            // cboDelimiter
            // 
            this.cboDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDelimiter.FormattingEnabled = true;
            this.cboDelimiter.Items.AddRange(new object[] {
            ",",
            ";",
            "|",
            "^",
            "~"});
            this.cboDelimiter.Location = new System.Drawing.Point(235, 87);
            this.cboDelimiter.Name = "cboDelimiter";
            this.cboDelimiter.Size = new System.Drawing.Size(121, 26);
            this.cboDelimiter.TabIndex = 9;
            // 
            // txtHash
            // 
            this.txtHash.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHash.Location = new System.Drawing.Point(92, 149);
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(335, 24);
            this.txtHash.TabIndex = 9;
            this.txtHash.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(450, 89);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(78, 27);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Log File Analyser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.cboColumn);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(164, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Column:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Column:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(92, 73);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(78, 27);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboColumn
            // 
            this.cboColumn.FormattingEnabled = true;
            this.cboColumn.Location = new System.Drawing.Point(103, 43);
            this.cboColumn.Name = "cboColumn";
            this.cboColumn.Size = new System.Drawing.Size(121, 26);
            this.cboColumn.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(228, 552);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(202, 646);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(174, 30);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export Chart to PNG";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpChartType
            // 
            this.grpChartType.Controls.Add(this.btnUpdate);
            this.grpChartType.Controls.Add(this.radioPyramid);
            this.grpChartType.Controls.Add(this.radioPie);
            this.grpChartType.Controls.Add(this.radioColumn);
            this.grpChartType.Controls.Add(this.radioBar);
            this.grpChartType.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChartType.Location = new System.Drawing.Point(15, 682);
            this.grpChartType.Name = "grpChartType";
            this.grpChartType.Size = new System.Drawing.Size(625, 62);
            this.grpChartType.TabIndex = 11;
            this.grpChartType.TabStop = false;
            this.grpChartType.Text = "Change Chart Type";
            // 
            // radioBar
            // 
            this.radioBar.AutoSize = true;
            this.radioBar.Location = new System.Drawing.Point(24, 30);
            this.radioBar.Name = "radioBar";
            this.radioBar.Size = new System.Drawing.Size(91, 22);
            this.radioBar.TabIndex = 3;
            this.radioBar.TabStop = true;
            this.radioBar.Text = "Bar Chart";
            this.radioBar.UseVisualStyleBackColor = true;
            // 
            // radioColumn
            // 
            this.radioColumn.AutoSize = true;
            this.radioColumn.Location = new System.Drawing.Point(125, 30);
            this.radioColumn.Name = "radioColumn";
            this.radioColumn.Size = new System.Drawing.Size(117, 22);
            this.radioColumn.TabIndex = 4;
            this.radioColumn.TabStop = true;
            this.radioColumn.Text = "Column Chart";
            this.radioColumn.UseVisualStyleBackColor = true;
            // 
            // radioPie
            // 
            this.radioPie.AutoSize = true;
            this.radioPie.Location = new System.Drawing.Point(251, 30);
            this.radioPie.Name = "radioPie";
            this.radioPie.Size = new System.Drawing.Size(88, 22);
            this.radioPie.TabIndex = 5;
            this.radioPie.TabStop = true;
            this.radioPie.Text = "Pie Chart";
            this.radioPie.UseVisualStyleBackColor = true;
            // 
            // radioPyramid
            // 
            this.radioPyramid.AutoSize = true;
            this.radioPyramid.Location = new System.Drawing.Point(359, 30);
            this.radioPyramid.Name = "radioPyramid";
            this.radioPyramid.Size = new System.Drawing.Size(122, 22);
            this.radioPyramid.TabIndex = 6;
            this.radioPyramid.TabStop = true;
            this.radioPyramid.Text = "Pyramid Chart";
            this.radioPyramid.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioPyramid.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(511, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHashMessage
            // 
            this.lblHashMessage.AutoSize = true;
            this.lblHashMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHashMessage.Location = new System.Drawing.Point(169, 173);
            this.lblHashMessage.Name = "lblHashMessage";
            this.lblHashMessage.Size = new System.Drawing.Size(123, 18);
            this.lblHashMessage.TabIndex = 12;
            this.lblHashMessage.Text = "                       ";
            // 
            // AnalyserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(913, 755);
            this.Controls.Add(this.grpChartType);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartFrequency);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(929, 794);
            this.MinimumSize = new System.Drawing.Size(929, 794);
            this.Name = "AnalyserInterface";
            this.Text = "Log File Analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequency)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpChartType.ResumeLayout(false);
            this.grpChartType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequency;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColumn;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox txtHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDelimiter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox grpChartType;
        private System.Windows.Forms.RadioButton radioPie;
        private System.Windows.Forms.RadioButton radioColumn;
        private System.Windows.Forms.RadioButton radioBar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton radioPyramid;
        private System.Windows.Forms.Label lblHashMessage;
    }
}

