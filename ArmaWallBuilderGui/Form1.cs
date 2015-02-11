using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmaWallBuilderGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    /*class Vehicles
 {
  items=220;
  class Item0
  {
   position[]={145,5,0};
   azimut=90;
   id=0;
   side="EMPTY";
   vehicle="Land_CncWall4_F";
   skill=1;
   };
   
so, "items=220" is the number of blocks. It's only written once at the top. equals the highest id=x+1
from "class Item0" to the end is what repeats
So there's "class Itemx" where x increases by 1 each time
then "position[]={a,5,0}; where a increases by 5
"id=x" Where x is the same variable used for "class itemx"
get a string for vehicle="Land_CncWall4_F";
     * 
     * what would be nice is to input the value for x and z into fields, and be able to have check boxes by them to either stay constant, or to change in a specified increment (positive or negative)
*/
}
