using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace SIEMApplication
{
    class FileHandler {
        //stores number of rows
       public int numberOfRows;
        //stores number of columns
        public int numberOfColumns;
        //stores filename of hash file
        string hashFile = "hashValue.txt";

        public string[,] handleFile(ComboBox cboDelimiter, ComboBox cboColumn, string logFile, string[,] values)
        {
            char delimiter;
            char[] temp;
            //default delimiter
            if (cboDelimiter.Text == null)
            {
                delimiter = ',';
            }
            else
            {
                temp = cboDelimiter.Text.ToCharArray();
                delimiter = temp[0];
            }
            cboColumn.Items.Clear();
            //read file
            string completeFile = System.IO.File.ReadAllText(logFile);
            completeFile = completeFile.Replace('\n', '\r');
            string[] lines = completeFile.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);
            //get number of rows and columnds
            numberOfRows = lines.Length;
            numberOfColumns = lines[0].Split(delimiter).Length;
            values = new string[numberOfRows, numberOfColumns];
            //split by delimiter
            for (int i = 0; i < numberOfRows; i++)
            {
                string[] line_r = lines[i].Split(delimiter);
                for (int j = 0; j < numberOfColumns; j++)
                {
                    values[i, j] = line_r[j];
                }
            }
            //add each column to combo box
            for (int i = 0; i < numberOfColumns; i++)
            {
                cboColumn.Items.Add(i);
            }
            return values;
        }

        public void graphGenerator(ComboBox cboColumn, string[,] values, DataGridView dataGridView1, Chart chartFrequency)
        {
            //convert column entry to number
            int column = Int32.Parse(cboColumn.Text);
            //create dictionary
            SortedDictionary<string, int> valueD = new SortedDictionary<string, int>();
            //loop through all rows
            for (int i = 0; i < numberOfRows; i++)
            {
                //if already exists in dictionary, increment int
                if (valueD.ContainsKey(values[i, column])) {
                    valueD[values[i, column]]++;
                }
                else {
                    //if not, add to dictionary
                    valueD.Add(values[i, column], 1);
                }
            }
            //bind ductionary to chart
            chartFrequency.Series[0].Points.DataBindXY(valueD.Keys, valueD.Values);
            //add data from dictionary to data grid view
            var dataFromDictionary = from row in valueD select new { Data = row.Key, Frequency = row.Value };
            dataGridView1.DataSource = dataFromDictionary.ToArray();

        }

        public void saveHash(string hashValue)
        {
            //save hash to a file
                using (StreamWriter sw = File.CreateText(hashFile))
                {
                    sw.WriteLine(hashValue);
                }
        }


        public string compareHash()
        {
            //read hash value from file
            string completeFile = System.IO.File.ReadAllText(hashFile);
            return completeFile;
        }
    }
}
