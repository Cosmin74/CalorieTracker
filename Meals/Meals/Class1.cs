/**************************************************************************
 *                                                                        *
 *  File:        Class1.cs                                                *
 *                                                                        *
 *  Descriere:   Clasă în care se rețin date                              *
 *                despre mesele consumate de utilizator                   *
 *                in parcursul unei zile                                  *
 *  Autor:                                                                *
 *                                                                        *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meals
{
    public class Meals
    {
        /// <summary>
        /// Tipul mesei
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Calorii masă
        /// </summary>
        public double calories { get; set; }

        /// <summary>
        /// Constructor pentru masă
        /// </summary>
        public Meals(string mealType, double mealCalories)
        {
            /// <summary>
            /// se asigură că au foste numere date pozitive
            /// </summary>
            if (mealCalories < 1)
                throw new Exception("Numărul de calorii trebuie sa fie pozitiv.");

            type = mealType;
            calories = mealCalories;
        }
    }
}
