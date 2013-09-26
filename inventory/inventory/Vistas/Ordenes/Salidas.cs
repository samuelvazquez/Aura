using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventory
{
    class Salidas : Panel   //  public partial class Form1 : Form
    {
       Panel panel1 = new Panel();
       TextBox textBox1 = new TextBox();
       Label label1 = new Label();

       public Panel listSalidas()
       {
           Panel panel = new Panel();
           TextBox textBox1 = new TextBox();
           Label label1 = new Label();

           // Initialize the Panel control.
           //panel.Location = new Point(56, 72);
           panel.Size = new Size(694, 534);  //694, 534
           // Set the Borderstyle for the Panel to three-dimensional.
           panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;


           //panel.BackColor = System.Windows.Forms.ColorDepth.Depth4Bit;

           // Initialize the Label and TextBox controls.
           panel.Location = new Point(16, 16);
           label1.Text = "Salidas";
           label1.Size = new Size(104, 16);
           textBox1.Location = new Point(16, 32);
           textBox1.Text = "";
           textBox1.Size = new Size(152, 20);

           // Add the Panel control to the form.
           this.Controls.Add(panel);
           // Add the Label and TextBox controls to the Panel.
           panel.Controls.Add(label1);
           panel.Controls.Add(textBox1);


           return panel;
       }
    }
}
