using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public List<string> Data = new List<string> { };
        public List<string> replaceableList = new List<string> { };
        public string FileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void ScrubData()
        {
            // Put each line of the text file into an array
            string[] preParse = File.ReadAllLines(FileName);

            // Instance a new StringBuilder to append items into a text string
            StringBuilder builder = new StringBuilder();

            // Foreach item in the array preParse, append text in the StringBuilder.
            foreach (string item in preParse)
            {
                builder.Append(item);
                builder.Append("-");
                Data.Add(item);
            }

            StringBuilder builder2 = new StringBuilder();
            foreach (string item in Data)
            {
                builder2.Append(item);
            }

            ReplaceData();
        }

        private void ReplaceData()
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in Data)
            {
                // Add items to the secondary list for replacing.
                replaceableList.Add(item);
                builder.Append(item);
            }

            //Console.WriteLine(Data.Count);
            foreach (string item in Data)
            {
                // Write all items out to the console.
                Console.WriteLine(item);
                List<string> items = new List<string> { };

                string[] itemAr = item.Split('|');

                foreach (string item2 in itemAr)
                {
                    items.Add(item2);
                }
                
                // Replace the first item in the array with a random sequence of strings and integers.
                items[0] = GetRandomMix(7);
                items[2] = GetRandomString(items[2].Length);
                items[3] = replaceX(items[3]);


                StringBuilder builder2 = new StringBuilder();

                Console.WriteLine(items.Count);
                foreach (string item3 in items)
                {
                    builder2.Append(item3);
                    builder2.Append("|");
                }

                if (float.Parse(items[4]) > 100)
                {
                    builder2.Append("yes");
                }
                else
                {
                    builder2.Append("no");
                }

                string path =  Path.Combine("C:/Users/" + Environment.UserName + "/Desktop", "data_scrubbed.txt");

                string fileContents = String.Empty;

                if (File.Exists(path))
                {
                    fileContents = File.ReadAllText(path);
                }

                File.WriteAllText(path, fileContents + builder2.ToString() + "\r\n");
            }
            string scrubbedPath = Path.Combine("C:/Users/" + Environment.UserName + "/Desktop", "data_scrubbed.txt");
        }

        // 'Void' for returning a random sequence of numbers and letters.

        private string replaceX(string item)
        {
            List<char> itemList = new List<char> {};
            foreach (char i in item)
            {
                itemList.Add(i);
            }

            foreach (char item2 in itemList)
            {
                Console.Write(item2);
            }

            int itemListLength = itemList.Count;
            string newString = randomX(13);

            newString = newString + itemList[itemListLength - 4] + itemList[itemListLength - 3] + itemList[itemListLength - 2] + itemList[itemListLength -1];

            return newString;
        }
        private string GetRandomMix(int Size)
        {
            Random random = new Random();
            string input = "0123456789";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public string GetRandomString(int Size)
        {
            Random random = new Random();
            string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                ch = input[random.Next(0, input.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public string randomX(int Size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < Size; i++)
            {
                // Add x to the string
                ch = 'x';
                builder.Append(ch);
            }
            return builder.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // If no file was selected, return an error.
            if (String.IsNullOrEmpty(FileName))
            {
                MessageBox.Show("Please select a file.");
                return;
            }

            ScrubData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Use an Open File Dialog to select the file with the information
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (!ofd.FileName.Contains("data.txt"))
            {
                MessageBox.Show("Please upload data.txt");
                return;
            }

            FileName = ofd.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
