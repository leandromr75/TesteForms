using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteForms
{
    public partial class Form1 : Form
    {
        //adiciona button
        Button a = new Button()
        {
            BackColor = Color.Aqua,
            Height = 60,
            Width = 100,
            Location = new Point(10, 10),
            Text = "Clique"
        };
        Label l = new Label()
        {
            ForeColor = Color.Red,
            Location = new Point(10, 80)
        };

        int cont = 1;
        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(a);
            this.Controls.Add(l);
            a.Click += new EventHandler(a_click);
        }

        public void a_click(Object sender, EventArgs e){
            l.Text = cont.ToString();
            cont++;
        }

    }
}
