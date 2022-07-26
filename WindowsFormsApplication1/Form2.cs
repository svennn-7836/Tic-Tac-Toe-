using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form

    {
        //Turns between Player X and O
        bool playerturn = true;
        int playerturn_count = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button_click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (playerturn)
                x.Text = "X";

            else
                x.Text = "O";

            playerturn = !playerturn;
            x.Enabled = false;
            
        
       
        
            

            

   

            

            
            
        }
        










        private void button9_Click(object sender, EventArgs e)
        {
            //Transition from Form2 Back to Form1

            Form1 FORM2 = new Form1();
            FORM2.Show();
            this.Hide();

            
    }
        


    
    }
}
