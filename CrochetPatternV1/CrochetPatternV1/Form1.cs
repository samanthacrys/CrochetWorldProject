using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrochetPatternV1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            CrochetWorld.Text = "Welcome to Crochet World.";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Label AdditionalLabel = new Label();
            AdditionalLabel.Text = "Crochet World";
            AdditionalLabel.Location = new Point(150, 70);
            AdditionalLabel.AutoSize = true;
            AdditionalLabel.Font = new Font("Verdana", 12);
            AdditionalLabel.ForeColor = Color.Red;

            this.Controls.Add(AdditionalLabel);
        }
    }
}
