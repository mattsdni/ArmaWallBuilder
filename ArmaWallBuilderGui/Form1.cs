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
        String outCode = "";
        String itemName = "";
        String fileName = "wall.sqm";
        double positionX = 0, positionY = 0, positionZ = 0;
        double incX = 0, incY = 0, incZ = 0;
        double azimut = 0, azInc = 0;
        int numBlocks = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Add error checking to these inputs
            //parse fields into variables
            itemName = this.itemName_text.Text;
            if (!String.IsNullOrEmpty(this.posX_text.Text))
                positionX = Convert.ToDouble(this.posX_text.Text);

            if (!String.IsNullOrEmpty(this.posY_text.Text))
                positionY = Convert.ToDouble(this.posY_text.Text);

            if (!String.IsNullOrEmpty(this.posZ_text.Text))
                positionZ = Convert.ToDouble(this.posZ_text.Text);

            if (!String.IsNullOrEmpty(this.incX_text.Text))
                incX = Convert.ToDouble(this.incX_text.Text);

            if (!String.IsNullOrEmpty(this.incY_text.Text))
                incY = Convert.ToDouble(this.incY_text.Text);

            if (!String.IsNullOrEmpty(this.incZ_text.Text))
                incZ = Convert.ToDouble(this.incZ_text.Text);

            if (!String.IsNullOrEmpty(this.azimut_text.Text))
                azimut = Convert.ToDouble(this.azimut_text.Text);

            if (!String.IsNullOrEmpty(this.azInc_text.Text))
                azInc = Convert.ToDouble(this.azInc_text.Text);

            if (!String.IsNullOrEmpty(this.numBlocks_text.Text))
                numBlocks = Convert.ToInt32(this.numBlocks_text.Text);

            if (!String.IsNullOrEmpty(this.fileName_text.Text))
                fileName = this.fileName_text.Text;

            //generate code for wall
            outCode += "\tclass Vehicles\n";
            outCode += "\t{\n";   //{ newline
            outCode += "\t\t";    //tab
            outCode += "items=" + numBlocks + ";\n"; //items=220;
            for (int i = 0; i < numBlocks; i++)
            {
                outCode += "\t\tclass Item" + i + "\n";
                outCode += "\t\t{\n";
                outCode += "\t\t\tposition[]={" + (positionX + (incX * i)) + "," + 5 + "," + (positionZ + (incZ * i)) + "};\n";
                outCode += "\t\t\tazimut=" + (azimut + (azInc * i)) + ";\n";
                outCode += "\t\t\toffsetY=" + (positionY + (incY * i)) + ";\n";
                outCode += "\t\t\tid=" + i + ";\n";
                outCode += "\t\t\tside=\"EMPTY\";\n";
                outCode += "\t\t\tvehicle=\"" + itemName + "\";\n";
                outCode += "\t\t\tskill=1;\n";
                outCode += "\t\t};\n";
            }
            outCode += "\t}";

            this.preview_text.Text = outCode;
            //output sqm file
            System.IO.File.WriteAllText(@Application.StartupPath + "\\" + fileName + ".sqm", outCode);
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
