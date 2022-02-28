using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace _2048plus
{
    public partial class FrmGioco : Form
    {
        Random generatore = new Random();
        int punteggio_MAX;
        FrmMain Fprincipale = null;
        bool raggiunto = false;
        public FrmGioco(FrmMain principale)
        {
            InitializeComponent();

            Fprincipale = principale;

            //impostazioni iniziali
            Score();
            Modalità();
            CreazioneGriglia();

            //form di gioco
            this.ShowDialog();
        }

        private void CreazioneGriglia()
        {
            int wBtn = flpGriglia.Height / 4;
            //ciclo che crea n pulsanti
            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button();
 
                // diamo uno stile "flat" al pulsante
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 5;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.Margin = new Padding(0);
                
                btn.BackColor = Color.DarkGray;
                btn.ForeColor = Color.Black;
               
               

                btn.Width = btn.Height = wBtn;
                btn.TabIndex = i + 1;

                //dimensioni del font
                btn.Font = new Font("Trebuchet MS", 30);
                

                flpGriglia.Controls.Add(btn); //inserisco il bottone nel flowlayoutpanel
            }
        }

        /// <summary>
        /// livello di difficoltà
        /// </summary>
        private void Modalità()
        {
            if (Fprincipale.livello == 1)
            {
                btnModalità.Text = "EASY MODE";
                btnModalità.BackColor = Color.Gold;
                punteggio_MAX = 512;
            }
            else
            {
                if (Fprincipale.livello == 2)
                {
                    btnModalità.Text = "NORMAL MODE";
                    btnModalità.BackColor = Color.Orange;
                    punteggio_MAX = 1024;
                }
                else
                {
                    if (Fprincipale.livello == 3)
                    {
                        btnModalità.Text = "DIFFICULT MODE";
                        btnModalità.BackColor = Color.DarkOrange;
                        punteggio_MAX = 2048;
                    }
                    else
                    {
                        btnModalità.Text = "HARDCORE MODE";
                        btnModalità.BackColor = Color.Brown;
 
                        punteggio_MAX = 4096;
                    }

                }
            }
        }

        private void Score()
        {
            if (!File.Exists("highscore.csv"))
                lblScore.Text = "0";
            else
            {
                StreamReader sr = new StreamReader("highscore.csv");
                lblScore.Text = sr.ReadLine();
                sr.Close();
            }

            lblScore2.Text = "0";
        }

        /// <summary>
        /// Inizio del GIOCO, spawno i primi 2 bottoni 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGame_Click(object sender, EventArgs e)
        {
            flpGriglia.Enabled = true;
             StreamWriter sw = new StreamWriter("highscore.csv");

             sw.WriteLine(lblScore.Text);


             sw.Close();

            lblScore2.Text = "0";

            for (int j = 0; j < 16; j++) {
                flpGriglia.Controls[j].BackColor = Color.DarkGray;
                flpGriglia.Controls[j].Text = "";
            }

            int p= 0;
            for(int i=0; i < 2; i++)
            {
                int n = generatore.Next(1, 5);

                string button;
                if (n == 4)
                {
                    button = "4";
                }
                else
                    button = "2";

                int posizione = generatore.Next(1, 17);

                if (posizione != p)
                {
                    for (int j = 0; j < 16; j++)
                        if (flpGriglia.Controls[j].TabIndex == posizione)
                        {
                            flpGriglia.Controls[j].Text = button;
                            ColoraBottone(flpGriglia.Controls[j].Text, j);
                        }
                    p = posizione;
                }   
                else
                    i--;

            }
        }

        /// <summary>
        /// COLOR PALETTE: i vari colori assunti dai bottoni
        /// </summary>
        /// <param name="text"></param>
        /// <param name="j"></param>
        private void ColoraBottone(string text, int j)
        {
            if (Convert.ToInt32(text) >= 4096)
                text = "4096";

            switch (text)
            {
                case "2": flpGriglia.Controls[j].BackColor = Color.White; break;
                case "4": flpGriglia.Controls[j].BackColor = Color.LightGoldenrodYellow; break;
                case "8": flpGriglia.Controls[j].BackColor = Color.SandyBrown; break;
                case "16": flpGriglia.Controls[j].BackColor = Color.Orange; break;
                case "32": flpGriglia.Controls[j].BackColor = Color.DarkOrange; break;
                case "64": flpGriglia.Controls[j].BackColor = Color.Red; break;
                case "128": flpGriglia.Controls[j].BackColor = Color.Khaki; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 25); break;
                case "256": flpGriglia.Controls[j].BackColor = Color.Gold; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 25); break;
                case "512": flpGriglia.Controls[j].BackColor = Color.Yellow; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 25); break;
                case "1024": flpGriglia.Controls[j].BackColor = Color.Goldenrod; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 20); break;
                case "2048": flpGriglia.Controls[j].BackColor = Color.DarkGoldenrod; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 20); break;
                case "4096": flpGriglia.Controls[j].BackColor = Color.Black; flpGriglia.Controls[j].Font = new Font("Trebuchet MS", 20); flpGriglia.Controls[j].ForeColor= Color.White; break;
            }
        }

        
        /// <summary>
        /// Gestisce l'input dell'utente delle quattro frecce tramite cui si gioca il gioco
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool spostamento = false;

            if (keyData == Keys.Up)
                BtnSopraSotto(-4, ref spostamento);

            if (keyData == Keys.Down)
                BtnSopraSotto(+4, ref spostamento);

            if (keyData == Keys.Left)
                BtnDestraSinistra(-1, ref spostamento);

            if (keyData == Keys.Right)
                BtnDestraSinistra(+1, ref spostamento);
  

            //in caso almeno uno spostamento di blocco...spawno un bottone 
            if (spostamento)
            {
                SpawnBottone();
            }

            ControlloPartita();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Controlla se durante la partita l'utente perde, vince, il suo punteggio
        /// </summary>
        private void ControlloPartita()
        {
            //VEDERE SE HO PERSO E LANCIARE IL MESSAGGIO
            //guarda se nelle cella adiacienti ci sono text uguali

            bool bloccato = true;
            for (int i = 0; i < 16 && bloccato; i++)
                if (flpGriglia.Controls[i].BackColor == Color.DarkGray)
                    bloccato = false;

            if (bloccato)
            {
                bool fallito=true;
                for (int i = 0; i < 16 && fallito; i++)
                {
                    fallito = true;
                    int colonna = i % 4;

                    int start = -1, end = 1;
                    if (colonna == 0) start = 0;
                    if (colonna == 4 - 1) end = 0;

                    //controllo UNA CELLA, se possiede collegamenti
                    //ciclo sulle righe
                    for (int c1 = -1; c1 <= 1 && fallito; c1++)
                    {
                        //ciclo sulle colonne
                        for (int c2 = start; c2 <= end && fallito; c2++)
                        {
                            int np = i + 4 * c1 + c2;
                            if (np >= 0 && np < 16 && np!=i && np!=i+5 && np!= i-5 && np!= i-3 && np != i+3)
                                if (flpGriglia.Controls[np].Text == flpGriglia.Controls[i].Text)
                                    fallito = false;
                        }
                    }
                }

                if (fallito)
                {
                    flpGriglia.Enabled = false;
                    MessageBox.Show("GAME OVER!", "Fallito 2048+", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

            //messaggio di vittoria in caso di vincita
            if (!raggiunto)
            {
                int s;
                for (int i = 0; i < 16 && !raggiunto; i++)
                {
                    int.TryParse(flpGriglia.Controls[i].Text, out s);
                    if (s == punteggio_MAX)
                    {
                        MessageBox.Show("HAI VINTO!\nContinua a giocare per diventare ancora più forte!", "Vinto 2048+", MessageBoxButtons.OK, MessageBoxIcon.None);
                        raggiunto = true; 
                    }
                }
            }
        }

        /// <summary>
        /// Entra in azione quando viene premuta la freccia DESTRA o SINISTRA
        /// </summary>
        /// <param name="n"></param>
        /// <param name="spostamento"></param>
        private void BtnDestraSinistra(int n, ref bool spostamento)
        {
            Clear();
            int k; int s; int j;

            if (n == +1)
            {
                k = +1;
                s = 15;
            }
            else
            {
                k = 0;
                s = 0;
            }

            bool unito = false;

            for (int i=0; i < 16; i++)
            {
                if (n == +1)
                {
                    j = i + s;
                    s -= 2;
                }
                else
                    j = i;

                bool esito = true;
                unito = false;
                if (flpGriglia.Controls[j].BackColor != Color.DarkGray)
                {
                    string text = flpGriglia.Controls[j].Text;
                    int posizionef = j;
                    while ((posizionef+k) % 4 != 0 && !unito && posizionef < 16 && posizionef >= 0 && esito)
                    {
                        posizionef += n;

                        if (!unito && posizionef < 16 && posizionef >= 0)
                        {
                            if (flpGriglia.Controls[posizionef].BackColor == Color.DarkGray)
                            {
                                ColoraBottone(text, posizionef);
                                flpGriglia.Controls[posizionef].Text = text;
                                spostamento = true;
                            }
                            else
                            {
                                unito = UnisciBottoni(posizionef, text);
                                esito = false;
                            }
 
                            if (!esito)
                            {
                                if (unito)
                                {
                                    ResetCella(posizionef-n);
                                    spostamento = true;
                                }
                            }
                            else
                            {
                                ResetCella(posizionef - n);
                            }
                        }
                    }

                }
            }
        }

        private void ResetCella(int n)
        {
            flpGriglia.Controls[n].BackColor = Color.DarkGray;
            flpGriglia.Controls[n].Text = "";
            flpGriglia.Controls[n].Font = new Font("Trebuchet MS", 30);
            flpGriglia.Controls[n].Tag = null;
        }



        /// <summary>
        /// Entra in azione quando viene premuta la freccia SU o GIU'
        /// </summary>
        /// <param name="n"></param>
        /// <param name="spostamento"></param>
        private void BtnSopraSotto(int n, ref bool spostamento)
        {
            Clear();
            int s; int j;

            if (n == +4)
            {
                s = 15;
            }
            else
            {
                s = 0;
            }

            bool unito = false;
            for (int i = 0; i < 16; i++)
            {
                if (n == +4)
                {
                    j = i + s;
                    s -= 2;
                }
                else
                    j = i;

                unito =false;
                if (flpGriglia.Controls[j].BackColor != Color.DarkGray)
                {
                    string text = flpGriglia.Controls[j].Text;
                    ResetCella(j);
                    int posizionef = j +n;
                    while (posizionef < 16 && posizionef >= 0 )
                    {
                        if (flpGriglia.Controls[posizionef].BackColor == Color.DarkGray)
                            posizionef += n;
                        else
                        {
                            unito = UnisciBottoni(posizionef, text);
                            break;
                        }
                    }

                    posizionef -= n;
                    if (posizionef < 16 && posizionef >= 0 &&  !unito)
                    {
                        flpGriglia.Controls[posizionef].Text = text;
                        ColoraBottone(text, posizionef);

                        if (posizionef != j)
                            spostamento =true;
                    }

                    if (unito)
                    {
                        spostamento = true;
                    }

                }
                
            }
        
        }

        private void Clear()
        {
            for (int i = 0; i < 16; i++)
                flpGriglia.Controls[i].Tag = null;
        }


        /// <summary>
        /// genera casualmente un blocco da 2 o 4 sulla tavola ( con 2 +frequente)
        /// </summary>
        private void SpawnBottone()
        {
            //controllo che la posizione non sia occupata
            int pos = generatore.Next(0, 16);

            while(flpGriglia.Controls[pos].BackColor!=Color.DarkGray)
                pos = generatore.Next(0, 16);

            int numero = generatore.Next(1, 11);

            if (numero == 10)
            {
                flpGriglia.Controls[pos].Text = "4";
                ColoraBottone("4", pos);
            }
            else
            {
                flpGriglia.Controls[pos].Text = "2";
                ColoraBottone("2", pos);
            }


        }

        private bool UnisciBottoni(int a,  string text)
        {
            if (text == flpGriglia.Controls[a].Text && flpGriglia.Controls[a].Tag == null) //in caso si potessero unire 
            {
                flpGriglia.Controls[a].Text = Convert.ToString(Convert.ToInt32(text) + Convert.ToInt32(flpGriglia.Controls[a].Text));
                ColoraBottone(flpGriglia.Controls[a].Text, a);

                flpGriglia.Controls[a].Tag = 1;
                AumentaScore(text);

                return true;
            }
            else
                return false;
        }

        private void AumentaScore(string text)
        {
            int n = Convert.ToInt32(lblScore2.Text) + (Convert.ToInt32(text)*2);

            lblScore2.Text = Convert.ToString(n);

            if (Convert.ToInt32(lblScore.Text) < Convert.ToInt32(lblScore2.Text))
            {
                lblScore.Text = lblScore2.Text;
            }

        
        }


     
        private void FrmGioco_Load(object sender, EventArgs e)
        {

        }

        private void FrmGioco_FormClosing(object sender, FormClosingEventArgs e)
        {

            StreamWriter sw = new StreamWriter("highscore.csv");

            sw.WriteLine(lblScore.Text);


            sw.Close();
        }

        private void FrmGioco_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                StreamWriter sw = new StreamWriter("highscore.csv");

                sw.WriteLine(lblScore.Text);


                sw.Close();

        }

        private void flpGriglia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGame_MouseEnter(object sender, EventArgs e)
        {
            btnGame.BackColor = Color.Red;
        }

        private void btnGame_MouseLeave(object sender, EventArgs e)
        {
            btnGame.BackColor = Color.Black;
        }
    }
}
