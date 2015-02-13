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
        decimal l = 0;

        public Form1()
        {
            InitializeComponent();
            //this.AddHandler(TextBox.TextChangedEvent, new TextChangedEventHandler(TextChanged));
        }

        String outCode = "";
        String itemName = "";
        String fileName = "wall";
        double positionX = 0, positionY = 0, positionZ = 0;
        double incX = 0, incY = 0, incZ = 0;
        double azimut = 0, azInc = 0;
        int numBlocks = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void richTextBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }


        private void button1_Click(object sender, EventArgs e)
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
            outCode += "\t}";

            this.preview_text.Text = outCode;
            //output sqm file
            System.IO.File.WriteAllText(@Application.StartupPath + "\\" + fileName + ".sqm", outCode);
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
            outCode += "  class Vehicles\r\r\n";
            outCode += "  {\r\n";   //{ newline
            outCode += "    ";    //tab
            outCode += "items=" + numBlocks + ";\r\n"; //items=220;

            outCode += "    class 0tem" + 0 + "\r\n";
            outCode += "    {\r\n";
            outCode += "      position[]={" + (positionX) + "," + 5 + "," + positionZ + "};\r\n";
            outCode += "      azimut=" + (azimut) + ";\r\n";
            outCode += "      offsetY=" + (positionY) + ";\r\n";
            outCode += "      id=" + 0 + ";\r\n";
            outCode += "      side=\"EMPTY\";\r\n";
            outCode += "      vehicle=\"" + itemName + "\";\r\n";
            outCode += "      skill=1;\r\n";
            outCode += "    };\r\n";

            outCode += "  }";

            this.preview_text.Text = outCode;
        }

    }
}
