using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ArmaWallBuilderGui
{
    public partial class Form1 : Form
    {
        decimal l = 0;
        int mode = 0;
        double A=2.86;
        double B=1.4292;
        double C=4.42;
        double D=2.2102;
        double E=2.4755;
        double F = 3.826;
        String outCode = "";
        String itemName = "";
        String fileName = "wall";
        double positionX = 0, positionY = 0, positionZ = 0;
        double incX = 0, incY = 0, incZ = 0;
        double azimut = 0, azInc = 0;
        int numBlocks = 0;
        string mission = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void setFileStart()
        {
            //TODO: change ALL THESE for loops to while loops because the derp
            string[] words = mission.Split('\n');
            int index = 0;
            int id;
            int item, items;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("\tclass Vehicles\r"))
                {
                    //we sure done musta got done founded it
                    Console.WriteLine(words[i]);
                    index = i;
                }
            }
            //go down 2
            index += 2;
            //get number (items=???)
            string resultString = null;
            try 
            {
                Regex regexObj = new Regex(@"[^\d]");
                resultString = regexObj.Replace(words[index], "");
            } 
            catch (ArgumentException ex) 
            {
                // Syntax error in the regular expression
            }
            items = Convert.ToInt32(resultString);
            
            //search for last Item (Item-1) eg Item6 (keep track of scope with { } math
            for (int i = index; i < words.Length; i++)
            {
                if (words[i].Equals("\t\tclass Item" + (items-1) + "\r"))
                {
                    index = i;
                }
            }
            //search for next instance of id=
            for (int i = index; i < words.Length; i++)
            {
                if (words[i].Contains("\t\t\tid="))
                {
                    index = i;
                }
            }
            //remove everything but numbers
            try
            {
                Regex regexObj = new Regex(@"[^\d]");
                resultString = regexObj.Replace(words[index], "");
            }
            catch (ArgumentException ex)
            {
                // Syntax error in the regular expression
            }
            //remember id number
            id = Convert.ToInt32(resultString);
            //look for next };
            for (int i = index; i < words.Length; i++)
            {
                if (words[i].Contains("};"))
                {
                    index = i;
                }
            }

            //add one to id and Item
            id++;
            item = items;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.itemName_text.Text))
            {
                System.Windows.Forms.MessageBox.Show("You forgot to enter the item name");
            }
            else
            {
                generate();
            }
        }

        private void generate()
        {
            //make a wall
            if (mode == 0)
            {
                outCode = "";
                itemName = this.itemName_text.Text;
                if (!String.IsNullOrEmpty(this.posX_text.Text) && decimal.TryParse(posX_text.Text, out l))
                    positionX = Convert.ToDouble(this.posX_text.Text);

                if (!String.IsNullOrEmpty(this.posY_text.Text) && decimal.TryParse(posY_text.Text, out l))
                    positionY = Convert.ToDouble(this.posY_text.Text);

                if (!String.IsNullOrEmpty(this.posZ_text.Text) && decimal.TryParse(posZ_text.Text, out l))
                    positionZ = Convert.ToDouble(this.posZ_text.Text);

                if (!String.IsNullOrEmpty(this.incX_text.Text) && decimal.TryParse(incX_text.Text, out l))
                    incX = Convert.ToDouble(this.incX_text.Text);

                if (!String.IsNullOrEmpty(this.incY_text.Text) && decimal.TryParse(incY_text.Text, out l))
                    incY = Convert.ToDouble(this.incY_text.Text);

                if (!String.IsNullOrEmpty(this.incZ_text.Text) && decimal.TryParse(incZ_text.Text, out l))
                    incZ = Convert.ToDouble(this.incZ_text.Text);

                if (!String.IsNullOrEmpty(this.azimut_text.Text) && decimal.TryParse(azimut_text.Text, out l))
                    azimut = Convert.ToDouble(this.azimut_text.Text);

                if (!String.IsNullOrEmpty(this.azInc_text.Text) && decimal.TryParse(azInc_text.Text, out l))
                    azInc = Convert.ToDouble(this.azInc_text.Text);

                if (!String.IsNullOrEmpty(this.numBlocks_text.Text) && decimal.TryParse(numBlocks_text.Text, out l))
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
                outCode += "\t};";

                this.preview_text.Text = outCode;
                //output sqm file
                System.IO.File.WriteAllText(@Application.StartupPath + "\\" + fileName + ".sqm", outCode);
            }
            if (mode == 1)
            {
                if (!String.IsNullOrEmpty(this.itemName_text.Text))
                    itemName = this.itemName_text.Text;
                if (!String.IsNullOrEmpty(this.fileName_text.Text))
                    fileName = this.fileName_text.Text;
                if (!String.IsNullOrEmpty(this.posX_text.Text) && decimal.TryParse(posX_text.Text, out l))
                    positionX = Convert.ToDouble(this.posX_text.Text);
                if (!String.IsNullOrEmpty(this.posY_text.Text) && decimal.TryParse(posY_text.Text, out l))
                    positionY = Convert.ToDouble(this.posY_text.Text);
                if (!String.IsNullOrEmpty(this.posZ_text.Text) && decimal.TryParse(posZ_text.Text, out l))
                    positionZ = Convert.ToDouble(this.posZ_text.Text);

                double X = positionX;
                double Y = positionZ;

                outCode += "\tclass Vehicles\n";
                outCode += "\t{\n";   //{ newline
                outCode += "\t\t";    //tab
                outCode += "items=" + 12 + ";\n"; //items=220;
                for (int i = 0; i < 12; i++)
                {
                    //calculate x and y
                    //TODO: fix this with radians
                    if (i == 0)
                        positionZ = Y + A;
                    if (i == 1)
                    {
                        positionX = X + E;
                        positionZ = Y + B;
                    }
                    if (i == 2)
                    {
                        positionX = X + E;
                        positionZ = Y - B;
                    }
                    if (i == 3)
                    {
                        positionX = X;
                        positionZ = Y - A;
                    }
                    if (i == 4)
                    {
                        positionX = X - E;
                        positionZ = Y - B;
                    }
                    if (i == 5)
                    {
                        positionX = X - E;
                        positionZ = Y + B;
                    }
                    if (i == 6)
                    {
                        positionX = X;
                        positionZ = Y + C;
                    }
                    if (i == 7)
                    {
                        positionX = X + F;
                        positionZ = Y + D;
                    }
                    if (i == 8)
                    {
                        positionX = X + F;
                        positionZ = Y - D;
                    }
                    if (i == 9)
                    {
                        positionX = X;
                        positionZ = Y - C;
                    }
                    if (i == 10)
                    {
                        positionX = X - F;
                        positionZ = Y - D;
                    }
                    if (i == 11)
                    {
                        positionX = X - F;
                        positionZ = Y + D;
                    }

                    //write code
                    outCode += "\t\tclass Item" + i + "\n";
                    outCode += "\t\t{\n";
                    outCode += "\t\t\tposition[]={" + positionX + "," + 5 + "," + positionZ + "};\n";
                    outCode += "\t\t\tazimut=" + (i * 60) % 360 + ";\n";
                    outCode += "\t\t\toffsetY=" + positionY + ";\n";
                    outCode += "\t\t\tid=" + i + ";\n";
                    outCode += "\t\t\tside=\"EMPTY\";\n";
                    outCode += "\t\t\tvehicle=\"" + itemName + "\";\n";
                    outCode += "\t\t\tskill=1;\n";
                    outCode += "\t\t};\n";
                }
                outCode += "\t};";

                this.preview_text.Text = outCode;
                //output sqm file
                System.IO.File.WriteAllText(@Application.StartupPath + "\\" + fileName + ".sqm", outCode);
            }
        }

        private void posX_text_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }

        private void itemName_text_TextChanged(object sender, EventArgs e)
        {
            updatePreview();
        }



        private void updatePreview()
        {
            preview_text.Text = String.Empty;
            outCode = "";
            itemName = this.itemName_text.Text;
            if (!String.IsNullOrEmpty(this.posX_text.Text) && decimal.TryParse(posX_text.Text, out l))
                positionX = Convert.ToDouble(this.posX_text.Text);

            if (!String.IsNullOrEmpty(this.posY_text.Text) && decimal.TryParse(posY_text.Text, out l))
                positionY = Convert.ToDouble(this.posY_text.Text);

            if (!String.IsNullOrEmpty(this.posZ_text.Text) && decimal.TryParse(posZ_text.Text, out l))
                positionZ = Convert.ToDouble(this.posZ_text.Text);

            if (!String.IsNullOrEmpty(this.incX_text.Text) && decimal.TryParse(incX_text.Text, out l))
                incX = Convert.ToDouble(this.incX_text.Text);

            if (!String.IsNullOrEmpty(this.incY_text.Text) && decimal.TryParse(incY_text.Text, out l))
                incY = Convert.ToDouble(this.incY_text.Text);

            if (!String.IsNullOrEmpty(this.incZ_text.Text) && decimal.TryParse(incZ_text.Text, out l))
                incZ = Convert.ToDouble(this.incZ_text.Text);

            if (!String.IsNullOrEmpty(this.azimut_text.Text) && decimal.TryParse(azimut_text.Text, out l))
                azimut = Convert.ToDouble(this.azimut_text.Text);

            if (!String.IsNullOrEmpty(this.azInc_text.Text) && decimal.TryParse(azInc_text.Text, out l))
                azInc = Convert.ToDouble(this.azInc_text.Text);

            if (!String.IsNullOrEmpty(this.numBlocks_text.Text) && decimal.TryParse(numBlocks_text.Text, out l))
                numBlocks = Convert.ToInt32(this.numBlocks_text.Text);

            if (!String.IsNullOrEmpty(this.fileName_text.Text))
                fileName = this.fileName_text.Text;

            //generate code for wall
            this.preview_text.Text += "  class Vehicles\r\r\n";
            this.preview_text.Text += "  {\r\n";   //{ newline
            this.preview_text.Text += "    ";    //tab
            this.preview_text.Text += "items=" + numBlocks + ";\r\n"; //items=220;

            this.preview_text.Text += "    class Item" + numBlocks + "\r\n";
            this.preview_text.Text += "    {\r\n";
            this.preview_text.Text += "      position[]={" + (positionX) + "," + 5 + "," + positionZ + "};\r\n";
            this.preview_text.Text += "      azimut=" + (azimut) + ";\r\n";
            this.preview_text.Text += "      offsetY=" + (positionY) + ";\r\n";
            this.preview_text.Text += "      id=" + numBlocks + ";\r\n";
            this.preview_text.Text += "      side=\"EMPTY\";\r\n";
            this.preview_text.Text += "      vehicle=\"" + itemName + "\";\r\n";
            this.preview_text.Text += "      skill=1;\r\n";
            this.preview_text.Text += "    };\r\n";

            this.preview_text.Text += "  }";

            //this.preview_text.Text = outCode;
        }

        private void normal_r_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
            numBlocks_text.ReadOnly = false;
            incX_text.ReadOnly = false;
            incY_text.ReadOnly = false;
            incZ_text.ReadOnly = false;
            posY_text.ReadOnly = false;
            azInc_text.ReadOnly = false;
            azimut_text.ReadOnly = false;

        }

        private void snowflake_r_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            //numn blokcs, azimut
            numBlocks_text.ReadOnly = true;
            incX_text.ReadOnly = true;
            incY_text.ReadOnly = true;
            incZ_text.ReadOnly = true;
            posY_text.ReadOnly = true;
            azInc_text.ReadOnly = true;
            azimut_text.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                // Displays an OpenFileDialog so the user can select a Cursor.
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.Filter = "Mission files|*.sqm";
                openFileDialog2.Title = "Select a Mission File";

                // Show the Dialog.
                // If the user clicked OK in the dialog and
                // a .CUR file was selected, open it.
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    // Open the selected file to read.
                   // System.IO.Stream fileStream = openFileDialog2.FileName;
                    System.IO.StreamReader myFile = new System.IO.StreamReader(openFileDialog2.FileName);

                    //using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                    //{
                        // Read the first line from the file and write it the textbox.
                    mission = myFile.ReadToEnd();

                    setFileStart();
                    //}
                    myFile.Close();
                }
        }
    }
}
