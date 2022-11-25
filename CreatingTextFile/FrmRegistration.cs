using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
    

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                 "BS Information Technology",
                 "BS Computer Science",
                 "BS Information Systems",
                 "BS in Accountancy",
                 "BS in Hospitality Management",
                 "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
        }
        /////return methods 
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFileName fn = new FrmFileName();
            fn.ShowDialog();

            String getStudentNo = txtStudentNo.Text;
            String getProgram = cbPrograms.Text;
            String getFirstName = txtFirstName.Text;
            String getLastName = txtLastName.Text;
            String getMiddleInitial = txtMiddleInitial.Text;
            String getAge = txtAge.Text;
            String getGender = cbGender.Text;
            String getBirthday = datePickerBirthday.Text;
            String getContactNo = txtContactNo.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No: " + getStudentNo);
                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + "," + getMiddleInitial);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No: " + getContactNo);

                Console.WriteLine("Student No: " + getStudentNo);
                Console.WriteLine("Full Name: " + getLastName + ", " + getFirstName + "," + getMiddleInitial);
                Console.WriteLine("Program: " + getProgram);
                Console.WriteLine("Gender: " + getGender);
                Console.WriteLine("Age: " + getAge);
                Console.WriteLine("Birthday: " + getBirthday);
                Console.WriteLine("Contact No: " + getContactNo);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    }   
