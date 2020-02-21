using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Design et lille program, hvor brugeren indtaster navn. 
 * Hvis navnet et ”Børge” skrives ”Øv ud Børge”.
 * Ellers skrives ”Velkommen <indtastet navn>”
 */
namespace KEAOpgave3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variables
        string name;

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text.ToLower(); // Converts to lowercase, adds whatever in textbos into name. No discrimination except for "børge"
            if (name == "børge") // if name is børge
                labelRes.Text = "Øv ud Børge"; 
            else
                labelRes.Text = $"Velkommen {name}";
        }
    }
}
