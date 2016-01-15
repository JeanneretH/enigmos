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
        private List<String> CommandesEcrites = new List<String>();

        Label lblEcranLaptop = new Label();
        TextBox tbxConsole = new TextBox();
        Button btnValider = new Button();
        PictureBox pbxEcranPc = new PictureBox();
        

        
        public HackingEnigmaPanel()
        {
            Width = 1000;
            Height = 800;
            this.pcCourant = PC.Laptop();
            this.BackgroundImage = Properties.Resources.Hacking;
            this.Width = Properties.Resources.Hacking.Width;
            this.Height = Properties.Resources.Hacking.Height;

            Controls.Add(lblEcranLaptop);
            lblEcranLaptop.Size = new Size(360, 165);
            lblEcranLaptop.Font = new Font("Courier New", 12);
            lblEcranLaptop.Location = new Point(225, 315);
            lblEcranLaptop.BackColor = Color.Transparent;
            lblEcranLaptop.ForeColor = Color.White;
            lblEcranLaptop.Text = "Vous vous êtes introduit dans le réseau de l'entreprise. Vous pouvez donc le scanner.\nLe fichier à récupèrer se trouve sur le pc du directeur.\nVous allez devoir remonter le réseau pour le pirater.\nroot@enigmos#~ ";

            Controls.Add(tbxConsole);
            tbxConsole.Size = new Size(360, 120);
            tbxConsole.Font = new Font("Courrier New", 20);
            tbxConsole.Location = new Point(225, 480);
            tbxConsole.BackColor = Color.Black;
            tbxConsole.ForeColor = Color.White;

            Controls.Add(pbxEcranPc);
            pbxEcranPc.Size = new Size(412, 333);
            pbxEcranPc.BackgroundImage = Properties.Resources.Reseau;
            pbxEcranPc.Location = new Point(695, 125);

            btnValider.Click += new EventHandler(Valider);
            ReturnHandler = btnValider;
        }
        public void AddCommandesEcrites(string ligne)
        {
            string[] lignes = ligne.Split(new string[] { "\n" },StringSplitOptions.None);
            foreach (string l in lignes)
            {
                CommandesEcrites.Add(l);
            }
            while (CommandesEcrites.Count > 8)
            {
                CommandesEcrites.RemoveAt(0);
            }
        }

        private void Valider(object sender, EventArgs e)
        {
            Command command = pcCourant.GetCommand(tbxConsole.Text);
            if (false)
            {

            }
            this.AddCommandesEcrites("root@enigmos#~ " + tbxConsole.Text);
            this.AddCommandesEcrites(command.getResultat());
            tbxConsole.Text = "";
            lblEcranLaptop.Text = string.Join("\n", CommandesEcrites);
        }
    }
}
