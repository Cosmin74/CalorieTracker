/**************************************************************************
 *                                                                        *
 *  File:        Class1.cs                                                *
 *                                                                        *
 *  Descriere:  Foloseste design pattern Facade care este un model de     *
 *  proiectare structurală care oferă o interfață simplificată la o       *
 *  bibliotecă, un cadru sau orice alt set complex de clase.              *
 *                                                                        *
 *                                                                        *
 *  Autor:                                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BazadeDate;

namespace BazaDeDateFacade
{
    public class BazaDeDateFacade
    {
        /// <summary>
        /// Variabilă pentru a folosi funcțiile din DLL-ul bazei de date
        /// </summary>
        private DB db;

        public BazaDeDateFacade()
        {
            ///<summary>
            ///Instașierea clasei pentru baza de date
            /// </summary>
            db = new DB();
        }

        public int Check(string mailAddress)
        {
            /// <summary>
            /// Verificarea mail-ului
            /// </summary>
            return db.check(mailAddress);
        }

        public void AddInTable(string lastName, string firstName, string mailAddress, string password, string gender, string activity, string weight, string height, string age)
        {
            /// <summary>
            /// Introducerea datelor noului utilizator în baza de date
            /// </summary>
            db.AddinTable(lastName, firstName, mailAddress, password, gender, activity, weight, height, age);
        }

        public int Verifica(string mailAddress, string password)
        {
            /// <summary>
            /// Verificare dacă utilizatorul este înregistrat în baza de date
            /// </summary>
            return db.Verificare(mailAddress, password);
        }
    }
}
