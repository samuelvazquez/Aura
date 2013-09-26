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
    class Proveedores : Panel
    {
       
       public Panel listProveedores()
       {
           Panel panel = new Panel();
           TextBox textBox1 = new TextBox();
           TextBox textBox2 = new TextBox();
           TextBox textBox3 = new TextBox();
           Label label1 = new Label();

           // Initialize the Panel control.
           //panel.Location = new Point(56, 72);
           panel.Size = new Size(694, 534);  //694, 534
           // Set the Borderstyle for the Panel to three-dimensional.
           panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;


           //panel.BackColor = System.Windows.Forms.ColorDepth.Depth4Bit;

           // Initialize the Label and TextBox controls.
           panel.Location = new Point(32, 32);
           label1.Text = "Proveedores";
           label1.Size = new Size(104, 16);
           textBox1.Location = new Point(16, 32);
           textBox1.Text = "";
           textBox1.Size = new Size(152, 20);

           textBox2.Location = new Point(16, 52);
           textBox2.Text = "";
           textBox2.Size = new Size(152, 20);

           textBox3.Location = new Point(16, 72);
           textBox3.Text = "";
           textBox3.Size = new Size(152, 20);

           // Add the Panel control to the form.
           this.Controls.Add(panel);
           // Add the Label and TextBox controls to the Panel.
           panel.Controls.Add(label1);
           panel.Controls.Add(textBox1);

           panel.Controls.Add(textBox2);
           panel.Controls.Add(textBox3);


           return panel;
       }
    }
}
