using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Printing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double cost = 0.00;
        public double costpp = 0.00;
        string ID = "";

        private double calcPrintCharge(int pages)
        {
            switch (lboxColour.SelectedItem)
            {
                case ("Black"):
                    costpp = 0.30 * pages;
                    break;
                case ("Colour"):
                    costpp = 5.00 * pages;
                    break;
                case ("Colour Gloss"):
                    costpp = 7.50 * pages;
                    break;
                case ("Colour Canvas"):
                    costpp = 50.00 * pages;
                    break;
                default:
                    MessageBox.Show("No colour selected");
                    break;
            }
            return (costpp);

        }

        private string generateJobID(string surname, int pages)
        {
            Random rand = new Random();
            int irandom = rand.Next(1, 11);
            ID = surname + irandom + pages;
            return ID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNewWindow.Visible = false;
            btnProcess.Visible = false;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string myFile = openFileDialog1.FileName;

                    StreamReader input = File.OpenText(myFile);

                    string myline = input.ReadLine();

                    while (myline != null)
                    {
                        lboxColour.Items.Add(myline);
                        myline = input.ReadLine();
                    }
                    input.Close();
                }
                else
                {
                    MessageBox.Show("File could not be opened");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTerms_CheckedChanged(object sender, EventArgs e)
        {
            btnProcess.Visible = true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string surname = tbSurname.Text;
            if (int.TryParse(tbPages.Text, out int pages))
            {
                if (surname != "")
                {
                    if (lboxColour.SelectedIndex != -1)
                    {
                        btnNewWindow.Visible = true;
                        string ID = generateJobID(surname, pages);
                        cost = calcPrintCharge(pages);

                        lboxResult.Items.Add("Job ID: " + ID);
                        lboxResult.Items.Add("Print charge: " + cost.ToString("C"));
                    }
                    else
                    {
                        MessageBox.Show("Please select a colour");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid surname");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for number of pages");
            }
        }

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            frmShow myform = new frmShow();

            myform.lblPrintCharge.Text = cost.ToString("C");

            myform.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSurname.Clear();
            tbStudentNum.Clear();
            tbPages.Clear();
            lboxResult.Items.Clear();
            tbSurname.Focus();
            cbTerms.Checked = false;
        }
    }
}
