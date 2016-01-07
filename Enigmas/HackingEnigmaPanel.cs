using Cpln.Enigmos.Enigmas.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpln.Enigmos.Enigmas
{
    class HackingEnigmaPanel : EnigmaPanel
    {
        private PC pcCourant;

        Label lblConsole = new Label();
        TextBox tbxConsole = new TextBox();

        
        public HackingEnigmaPanel()
        {
            Width = 1000;
            Height = 800;
            this.pcCourant = PC.Laptop();

            Controls.Add(lblConsole);
            lblConsole.Size = new Size(900, 600);
            lblConsole.Font = new Font("Courier New", 20);
            lblConsole.Location = new Point(50, 50);
            lblConsole.Text = "8";
            lblConsole.BackColor = Color.Black;
            lblConsole.ForeColor = Color.White;

            Controls.Add(tbxConsole);
            tbxConsole.Size = new Size(900, 20);
            tbxConsole.Font = new Font("Courrier New", 20);
            tbxConsole.Location = new Point(50, 650);
            tbxConsole.BackColor = Color.Black;
            tbxConsole.ForeColor = Color.White;
        }

        public override void PressKey(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {

            }
        }
    }
}
