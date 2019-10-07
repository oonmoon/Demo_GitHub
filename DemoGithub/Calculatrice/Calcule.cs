using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculatrice
{
    public class Calcule
    {
        public const string MSG_AJOUT_OP = "Evt ajout d'une opération";
        public const string MSG_RETIRER_OP = "Evt suppression d'une opération";
        public const string MSG_CHGT_NB1 = "Evt changement du nombre 1";
        public const string MSG_CHGT_NB2 = "Evt changement du nombre 2";
        public const string MSG_DIV_0 = "Le second nombre ne doits pas être null pour une division!";
        public const string EGAL = "=";
        public const string ADDITION = "plus";
        public const string SOUSTRACTION = "moins";
        public const string MULTIPLICATION = "multiplié par";
        public const string DIVISION = "divisé par";

        //static int addition(int x, int y) { return (x + y); }

        private Func<int, int, int> addition = (x, y) => x + y;
        //private Func<int, int, int> addition = addition;
        private Func<int, int, int> soustraction = (x, y) => x - y;
        private Func<int, int, int> multiplication = (x, y) => x * y;
        private Func<int, int, int> division = (x, y) => x / y;
        private Func<int, int, int> operations = null;

        public event NouveauResultatDelegue NouveauResultat;

        public enum MesOperations
        {
            addition,
            soustraction,
            multiplication,
            division
        }

        public void AjouterOp(MesOperations uneOperation)
        {
            switch (uneOperation)
            {
                case MesOperations.addition:
                    operations += addition;
                    break;
                case MesOperations.soustraction:
                    operations += soustraction;
                    break;
                case MesOperations.multiplication:
                    operations += multiplication;
                    break;
                case MesOperations.division:
                    operations += division;
                    break;
            }
            EnvoieNouveauxCalculs($"{MSG_AJOUT_OP}\n");
        }


        public void RetirerOp(MesOperations uneOperation)
        {
            switch (uneOperation)
            {
                case MesOperations.addition:
                    operations -= addition;
                    break;
                case MesOperations.soustraction:
                    operations -= soustraction;
                    break;
                case MesOperations.multiplication:
                    operations -= multiplication;
                    break;
                case MesOperations.division:
                    operations -= division;
                    break;
            }
            EnvoieNouveauxCalculs($"{MSG_RETIRER_OP}\n");
        }

        public string GetMesCalculs()
        {
            string resultats = "";
            if (operations != null)
            {
                Delegate[] delegates = operations.GetInvocationList();
                foreach (Func<int, int, int> d in delegates)
                {
                    try
                    {
                        int resultat = d(Nbre1, Nbre2);

                    if (d == addition)
                    {
                        resultats += $"{Nbre1} {ADDITION} {Nbre2} {EGAL} {resultat}\n";
                    }
                    else if (d == soustraction)
                    {
                        resultats += $"{Nbre1} {SOUSTRACTION} {Nbre2} {EGAL} {resultat}\n";
                    }
                    else if (d == multiplication)
                    {
                        resultats += $"{Nbre1} {MULTIPLICATION} {Nbre2} {EGAL} {resultat}\n";
                    }
                    else if (d == division)
                    {
                        resultats += $"{Nbre1} {DIVISION} {Nbre2} {EGAL} {resultat}\n";
                    }
                    }
                    catch (DivideByZeroException) { resultats += $"{MSG_DIV_0}\n"; }
                }
            }
            return resultats;
        }

        private void EnvoieNouveauxCalculs(string message)
        {
            NouveauResultatEventArgs args = new NouveauResultatEventArgs
            {
                Message = message,
                Resultats = GetMesCalculs()
            };
            if (NouveauResultat == null) {
                Console.WriteLine($"{message} avec aucune méthode enregistrée");
            }
            //    throw new ArgumentException($"{message} avec aucune méthode enregistrée");
            else
                NouveauResultat.Invoke(this, args);
        }

        private int nbre1 = 1;
        private int nbre2 = 2;

        public int Nbre1 {
            get { return nbre1; }
            set
            {
                if (value != nbre1)
                {
                    nbre1 = value;
                    EnvoieNouveauxCalculs($"{MSG_CHGT_NB1}\n");
                }
            }
        }

        public int Nbre2
        {
            get { return nbre2; }
            set
            {
                if (value != nbre2)
                {
                    nbre2 = value;
                    EnvoieNouveauxCalculs($"{MSG_CHGT_NB2}\n");
                }
            }
        }

    }
}
