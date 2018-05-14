using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Katon Bingham
 * May 13, 2018
 */

namespace W3ProgrammingExercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string junk;

            // !!! replace with your own file directory when testing !!!
            openFile.InitialDirectory =
                @"C:\Users\Katon Desktop\Documents\School\CST117\W3ProgrammingExercise3\W3ProgrammingExercise3";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);
                try
                {
                    // ensure listBox is empty
                    listBox.Items.Clear();
                    while (!inputFile.EndOfStream)
                    {
                        // read each txt line and add to listBox
                        junk = inputFile.ReadLine();
                        listBox.Items.Add(junk);
                    }
                    // close file
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    // show error message
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("you clicked cancel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string junk;
            var sb = new System.Text.StringBuilder();
            string lbString = "";

            try
            {
                for (int x = 0; x < listBox.Items.Count; x++)
                {
                    // extract items from initial listBox
                    junk = listBox.Items[x].ToString();
                    // convert string to lowercase
                    junk = junk.ToLower();
                    // add to listBoxParsed
                    listBoxToLower.Items.Add(junk);
                    // build lbString while we're here
                    sb.AppendLine(junk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // send that StringBuilder monstrosity to a string we can use
            lbString = sb.ToString();
            // create a string array to contain strings with individual words
            string[] words = lbString.Split(new[] { " ", "!", ",", ".", "?" },
                StringSplitOptions.RemoveEmptyEntries);
            // create string for individual words
            string word = "";
            // create coutner variable
            int ctr = 0;
            // begin comparison loop
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            // add result to the correct listBox
            listBoxLongestWord.Items.Clear();
            listBoxLongestWord.Items.Add(word);

            // Find first and last words alphabetically
            string[] alphabetical = lbString.Split(new[] { " ", "!", ",", ".", "?"},
                StringSplitOptions.RemoveEmptyEntries);
            // order array descending alphabetically
            alphabetical = alphabetical.OrderBy(d => d).ToArray();
            // add first alphabetically (length corrected to avoid overflow error)
            listBoxAlphabet.Items.Add(alphabetical[alphabetical.Length-2]);
            // and last alphabetically
            listBoxAlphabet.Items.Add(alphabetical[0]);

            // find which word has the most vowels
            // repurpose previous variables
            word = "";
            ctr = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (String v in alphabetical)
            {
                int total = 0;
                for (int i = 0; i < v.Length; i++)
                {
                    if (vowels.Contains(v[i]))
                    {
                        total++;
                        word = v;
                    }
                }
            }

            listBoxMostVowels.Items.Add(word);
        }
    }
}