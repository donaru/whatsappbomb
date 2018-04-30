using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace BulkGroupCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            
            String victim = textBox_victim.Text;
            String groupName = textBox_groupName.Text;
            int number = Convert.ToInt32(textBox_number.Text);

            AutoItX3 _autoit = new AutoItX3();
            _autoit.WinActivate("WhatsApp");

            for (int i = 0; i < number; i++)
            {
                _autoit.Send("{CTRLDOWN}{SHIFTDOWN}n{CTRLUP}{SHIFTUP}");

                _autoit.Send(victim);
                _autoit.Send("{ENTER}");
                _autoit.Send("{ENTER}");

                String newGroupName = " " + groupName + " " + i.ToString();
                _autoit.Send(newGroupName);
                _autoit.Send("{ENTER}");

                _autoit.Send("hi");
                _autoit.Send("{ENTER}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
