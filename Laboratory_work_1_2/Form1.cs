using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1_2
{
    public partial class Form1 : Form
    {
        private const string DEFAULT_MESSAGE = "Enter a message here";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxEnableMessage.Checked = true;
            checkBoxEnableProgram.Checked = true;
            checkBoxShowProgram.Checked = true;
            checkBoxShowMessage.Checked = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxMessage.Text);
        }
        private void buttonClearMessage_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = string.Empty;
        }
        private void buttonDefaultMessage_Click(object sender, EventArgs e)
        {
            textBoxMessage.Text = DEFAULT_MESSAGE;
        }
        private void buttonRunAProgram_Click(object sender, EventArgs e)
        {
            try
            {
                string chosenProgram = string.Empty;
                if (comboBoxChooseProgram.Text == "Блокнот")
                {
                    chosenProgram = "notepad.exe";
                }
                else if (comboBoxChooseProgram.Text == "Калькулятор")
                {
                    chosenProgram = "calc.exe";
                }
                else if (comboBoxChooseProgram.Text == "Paint")
                {
                    chosenProgram = "mspaint.exe";
                }
                else if (comboBoxChooseProgram.Text == "Панель управления")
                {
                    chosenProgram = "CONTROL.exe";
                }
                else if (comboBoxChooseProgram.Text == "Командная строка")
                {
                    chosenProgram = "cmd.exe";
                }
                Process.Start(chosenProgram);
            }
            catch (Exception)
            {
                MessageBox.Show("Виникла помилка при запуску програми");
            }
        }
        private void labelRunAProgram_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxChooseProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBoxShow_Enter(object sender, EventArgs e)
        {

        }
        private void groupBoxEnable_Enter(object sender, EventArgs e)
        {

        }
        private void checkBoxEnableMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableMessage.Checked)
            {
                buttonShowMessage.Enabled = true;
                buttonDefaultMessage.Enabled = true;
                buttonClearMessage.Enabled = true;
                textBoxMessage.Enabled = true;
            }
            else
            {
                buttonShowMessage.Enabled = false;
                buttonDefaultMessage.Enabled = false;
                buttonClearMessage.Enabled = false;
                textBoxMessage.Enabled = false;
            }
        }
        private void checkBoxEnableProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableProgram.Checked)
            {
                buttonRunAProgram.Enabled = true;
                comboBoxChooseProgram.Enabled = true;
                buttonGet_Text.Enabled = true;
            }
            else
            {
                buttonRunAProgram.Enabled = false;
                comboBoxChooseProgram.Enabled = false;
                buttonGet_Text.Enabled = false;
            }
        }
        private void checkBoxShowMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowMessage.Checked)
            {
                buttonShowMessage.Show();
                buttonDefaultMessage.Show();
                buttonClearMessage.Show();
                textBoxMessage.Show();
            }
            else
            {
                buttonShowMessage.Hide();
                buttonDefaultMessage.Hide();
                buttonClearMessage.Hide();
                textBoxMessage.Hide();
            }
        }
        private void checkBoxShowProgram_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowProgram.Checked)
            {
                buttonRunAProgram.Show();
                comboBoxChooseProgram.Show();
                buttonGet_Text.Show();
            }
            else
            {
                buttonRunAProgram.Hide();
                comboBoxChooseProgram.Hide();
                buttonGet_Text.Hide();
            }
        }
        private void buttonGet_Text_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxChooseProgram.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRunExtraProgram_Click(object sender, EventArgs e)
        {
            if (textBoxExtraName.Text.Length >= 1 && textBoxExtraPath.Text.Contains(".exe"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = textBoxExtraName.Text;
                startInfo.Arguments = "\"" + textBoxExtraPath.Text + "\"";
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Ведіть коректні дані");
            }
        }

        private void textBoxExtraName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExtraPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
