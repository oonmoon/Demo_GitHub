using System;
using System.Windows.Forms;
using Calculatrice;

namespace CalculatriceWF
{
    public partial class Form1 : Form
    {
        Calcule unCalcul = new Calcule();
        public Form1()
        {
            InitializeComponent();

            unCalcul.NouveauResultat += afficheResultat;
        }

        private void afficheResultat(object sender, NouveauResultatEventArgs args)
        {
            lblResultat.Text = args.Resultats;    
        }

        private void checkedListBoxOperations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Calcule.MesOperations op = Calcule.MesOperations.addition;
            switch (checkedListBoxOperations.SelectedItem)
            {
                case "addition":
                    op = Calcule.MesOperations.addition;
                    //unCalcul.AjouterOp(Calcule.MesOperations.addition);
                    break;

                case "soustraction":
                    op = Calcule.MesOperations.soustraction;
                    //unCalcul.AjouterOp(Calcule.MesOperations.soustraction);
                    break;

                case "multiplication":
                    op = Calcule.MesOperations.multiplication;
                    break;

                case "division":
                    op = Calcule.MesOperations.division;
                    break;

                default:
                    break;
            }
            if (e.NewValue == CheckState.Checked)
            {
                unCalcul.AjouterOp(op);
            }
            else
                unCalcul.RetirerOp(op);

            //lblResultat.Text = unCalcul.GetMesCalculs();
        }

    }
}
