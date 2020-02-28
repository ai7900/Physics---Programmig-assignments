using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {

        Game1 myGame;
        public Form1(Game1 myGame)
        {
            this.myGame = myGame;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float myValue;
            if (float.TryParse(textBox1.Text, out myValue))
                myGame.SetValue(myValue);
            else
                MessageBox.Show("ej giltigtflyttalsformat");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
