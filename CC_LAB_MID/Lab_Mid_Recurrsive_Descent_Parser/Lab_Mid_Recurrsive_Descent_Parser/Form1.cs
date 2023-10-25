using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Mid_Recurrsive_Descent_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void parse_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            LL1Parser parser = new LL1Parser(input);
            parser.Parse();
            if (parser.currentPosition == input.Length)
            {
                outputLabel.Text = "Accepted Input";
            }
            else
            {
                outputLabel.Text = "Rejected Input";
            }

        }
    }
}
