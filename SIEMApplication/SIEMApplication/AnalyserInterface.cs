using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace SIEMApplication
{
    public partial class AnalyserInterface : Form
    {
        //classes
        FileHandler fh = new FileHandler();
        HashFile hs = new HashFile();
        //variables
        string logFile;
        string[,] values;

        public AnalyserInterface()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //open file dialog
            FileDialog fd = new OpenFileDialog();
            if (DialogResult.OK == fd.ShowDialog())
            {
                //change variable to selected path. Add to txtbox
                logFile = fd.FileName;
                txtFilePath.Text = logFile;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //call method to get md5 hash
                txtHash.Text = hs.GetFileChecksum(logFile, new MD5CryptoServiceProvider());
                //file handling
                values = fh.handleFile(cboDelimiter, cboColumn, logFile, values);
                //default value
            cboColumn.SelectedIndex = 0;
            //enable buttons
            btnConfirm.Enabled = true;
            //compare hash values and display whether they are same or different in label
           if (fh.compareHash().Trim().Equals(txtHash.Text.Trim()))
           {
                lblHashMessage.Text = "The hash values are the same!";
                lblHashMessage.ForeColor = Color.Green;
                MessageBox.Show("The hash values are the same!");
           }
           else
           {
                lblHashMessage.Text = "The hash values are different!";
                lblHashMessage.ForeColor = Color.Red;
                MessageBox.Show("The hash values are different");
           }
           //save new hash to file
           fh.saveHash(txtHash.Text);

            }
            catch
            {
                //error message
                MessageBox.Show("Error. File not input correctly.");
            }
            this.Cursor = Cursors.Default;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close application
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Please allow the graph and data view some time to load");
                this.Cursor = Cursors.WaitCursor;
                //generate graph
                fh.graphGenerator(cboColumn, values, dataGridView1, chartFrequency);
                this.Cursor = Cursors.Default;
                btnExport.Enabled = true;
                grpChartType.Enabled = true;
                radioPie.Select();
            }
            catch
            {
                MessageBox.Show("Error parsing file");
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //set values on form load
                cboDelimiter.SelectedIndex = 0;
                btnConfirm.Enabled = false;
                btnExport.Enabled = false;
                grpChartType.Enabled = false;
                //sample data to populate pie chart
                int[] sampleData = { 1, 1 };
                chartFrequency.Series[0].Points.DataBindY(sampleData);
            }
            catch
            {
                MessageBox.Show("Error loading application");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try {
                //export chart to png file
                Export ex = new Export();
                ex.exportChartToPng(chartFrequency, logFile, cboColumn.Text);
                MessageBox.Show("Image file saved to log file location");
            }
            catch
            {
                MessageBox.Show("Error exporting chart as image");
            }
       }

    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //update the chart type to one selected by database.
                MessageBox.Show("Please allow the graph some time to update");
                if (radioBar.Checked)
                {
                    chartFrequency.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                }
                else if (radioColumn.Checked)
                {
                    chartFrequency.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                }
                else if (radioPie.Checked)
                {
                    chartFrequency.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                }
                else if (radioPyramid.Checked)
                {
                    chartFrequency.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
                }
                else
                {
                    MessageBox.Show("Please select a radio button");
                }
            }
            catch
            {
                MessageBox.Show("Error changing graph type");
            }
        }
    }
}

