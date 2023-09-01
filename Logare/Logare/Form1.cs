/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *                                                                        *
 *  Descriere:  Realizam conexiunea intre interfata de logare si cod      *
 *              utilizand funtii pentru fiecare element din interfata     *
 *                                                                        *
 *  Autor:                                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BazadeDate;
using CalculatorCaloric;
using BazaDeDateFacade;

namespace Logare{
    public partial class Form1 : Form{
        public Form1(){
            ///<summary>
            ///inițializare baza de date și interfață
            /// </summary>
            InitializeComponent();
            bazaDeDateFacade = new BazaDeDateFacade.BazaDeDateFacade();
            
        }
        /// <summary>
        /// Instațiere a clasei pentru baza de date
        /// </summary>
        private BazaDeDateFacade.BazaDeDateFacade bazaDeDateFacade;

        /// <summary>
        /// Metodă de creare unei noi interfețe atunci când utilizatorul apasa pe linkul "aici"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            /// <summary>
            /// Crearea unei noi interfețe atunci când utilizatorul apasa pe linkul "aici"
            /// </summary>
            Inregistrare f2 = new Inregistrare();
            f2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e){

            ///<summary>
            ///Verifică dacă utilizatorul a completat ambele câmpuri
            /// </summary>
            if (email.Text != "" && pass.Text != "") {
                int verifica = bazaDeDateFacade.Verifica(email.Text,pass.Text);
                    if (verifica != 1){
                    ///<summary>
                    ///Atenționează utilizatorul că nu a introdus bine parola sau adresa de mail
                    /// </summary>
                    MessageBox.Show("Eroare la introducerea adresei de mail sau a parolei");
                    }
                    else{
                    /// <summary>
                    /// Dacă interogarea a returnat 1 autentificarea e reușită și se face refresh asupra câmpurilor.
                    /// </summary>
                    MainForm mainForm = new MainForm();
                    mainForm.Email = email.Text;
                    mainForm.Password = pass.Text;
                    mainForm.Show();
                    Visible = false;
                    }
              
            }
            else{

                ///<summary>
                ///Dacă nu sunt completate ambele câmpuri, utilizatorul este avertizat să le completeze pe toate.
                /// </summary>
                MessageBox.Show("Completati toate campurile");
            }
        }

        private void button2_Click(object sender, EventArgs e){
            ///<summary>
            ///Buton pentru afișarea helper-ului
            /// </summary>
            System.Diagnostics.Process.Start("Helper.chm");
        }

        private void button3_Click(object sender, EventArgs e){
            ///<summary>
            ///Buton despre
            /// </summary>
            MessageBox.Show("Aplicație pentru contorizarea numărului de calorii consumate,pentru cei care vor să piardă în greutate sau să crească");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
