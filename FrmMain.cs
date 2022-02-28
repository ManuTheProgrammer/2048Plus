using _2048plus.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection; // necessario per la classe Assembly

namespace _2048plus
{
    public partial class FrmMain : Form
    {

        public int livello;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblCreatore_Click(object sender, EventArgs e)
        {

        }

        private void btnFacile_MouseLeave(object sender, EventArgs e)
        {
            btnFacile.BackColor = Color.Gold;
        }

        private void btnMedio_MouseHover(object sender, EventArgs e)
        {
            btnMedio.BackColor = Color.Red;
        }

        private void btnMedio_MouseLeave(object sender, EventArgs e)
        {
            btnMedio.BackColor = Color.Orange;
        }

   
        private void btnDifficile_MouseLeave(object sender, EventArgs e)
        {

            btnDifficile.BackColor = Color.DarkOrange;
        }

        private void btnFacile_Click(object sender, EventArgs e)
        {
            livello = 1;
            IniziaGioco();
        }

        /// <summary>
        /// Inizia il gioco, passa il comando alla form di gioco
        /// </summary>
        private void IniziaGioco()
        {
            
            FrmGioco gioco = new FrmGioco(this);
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            livello = 2;
            IniziaGioco();
        }

        private void btnDifficile_Click(object sender, EventArgs e)
        {

            livello = 3;
            IniziaGioco();
        }

        private void btnFacile_MouseEnter(object sender, EventArgs e)
        {
            btnFacile.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            livello = 4;
            IniziaGioco();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnHardcore.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnHardcore.BackColor = Color.Black;
        }

        private void btnMedio_MouseEnter(object sender, EventArgs e)
        {
            btnMedio.BackColor = Color.Red;
        }

        private void btnDifficile_MouseEnter(object sender, EventArgs e)
        {
            btnDifficile.BackColor = Color.Red;
        }

        //INFORMAZIONI APP E COME SI GIOCA
        private void comeGiocareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A 2048 si gioca su una semplice griglia di formato 4×4 in cui scorrono caselle di colori diversi, con numeri diversi (tutti i numeri sono potenze di 2), senza intralci quando un giocatore le muove.Il gioco usa i tasti freccia della tastiera per spostare tutte le caselle a sinistra o a destra oppure in alto o in basso. Se due caselle contenenti lo stesso numero si scontrano mentre si muovono, si fondono in un'unica casella che avrà come numero la somma delle due tessere che si sono scontrate e dunque il colore corrispondente\n Ad ogni turno, una nuova tessera con il valore di 2 o 4 apparirà in modo casuale in un punto vuoto sul tabellone.Inoltre, un tabellone in alto a destra tiene traccia del punteggio dell'utente. Il punteggio dell'utente inizia da zero e viene incrementato ogni volta che due tessere si combinano, con il valore della nuova casella\n Come in molti altri giochi, il miglior punteggio dell'utente viene visualizzato accanto al punteggio attuale. \n\n\n" + "Puoi inoltre scegliere la difficoltà:\n"
                + "FACILE: combina le caselle fino raggiungere 512 (utile per iniziare)\n" +
                "MEDIO: combina le caselle fino a raggiungere 1024 (per giocatori mediocri)\n" +
                "DIFFICILE: combina le caselle fino a raggiungere 2048 (classico 2048)\n" +
                "HARDCORE: combina le caselle fino a raggiungere 4096 ( per coloro a cui piacciono le sfide)\n\n" +
                "Non preoccuparti: raggiunto l'obiettivo della difficoltà potrai continuare all'infinito!\n" +
                "Buon Divertimento!", "2048+ Guida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoCreatoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Singh Sukhpreet\nun matematico, logico, crittografo e filosofo italo-americano, considerato uno dei padri dell'informatica e uno dei più grandi matematici del XXI secolo. ", "INFORMAZIONI CREATORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void infoAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Titolo: {AssemblyTitle}\nCopyright: {AssemblyCopyright}\nCompany: {AssemblyCompany}\nVersion: {AssemblyVersion}", "INFORMAZIONI APPLICAZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                // ottiene tutti gli attributi del titolo dell'assembly 
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    // seleziona il primo
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // se non c'è titolo, ritorna il nome dell'eseguibile
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                // ottiene tutti gli attributi della descrizione dell'assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                // ottiene tutti gli attributi del prodotto dell'assembly 
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                // ottiene tutti gli attributi del Copyright dell'assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                // ottiene tutti gli attributi dell'azienda dell'assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
