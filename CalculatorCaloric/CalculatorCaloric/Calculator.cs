
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CalculatorCaloric
{
    internal class Calculator
    {
        private string _gender;
        private string _activityLevel;
        private double _weight;
        private double _height;
        private int _age;

        public Calculator(string gender, string activityLevel, double weight, double height, int age)
        {
            _gender = gender;
            _activityLevel = activityLevel;
            _weight = weight;
            _height = height;
            _age = age;
        }

        //calculate basal metabolic rate (BMR), which is the amount of energy expended per day at rest
        public double MifflinStJeorEquation()
        {
            double activityFactor;
            switch (_activityLevel)
            {
                case "Sedentary":
                    activityFactor = 1.2;
                    break;
                case "Light exercise":
                    activityFactor = 1.375;
                    break;
                case "Moderate exercise":
                    activityFactor = 1.465;
                    break;
                case "Active":
                    activityFactor = 1.55;
                    break;
                case "Very active":
                    activityFactor = 1.725;
                    break;
                case "Extra active":
                    activityFactor = 1.9;
                    break;
                default:
                    activityFactor = 1;
                    break;
            }

            if (_gender == "Male")
            {
                return (10 * _weight + 6.25 * _height - 5 * _age + 5) * activityFactor;
            }
            else
            {
                return (10 * _weight + 6.25 * _height - 5 * _age - 161) * activityFactor;
            }
        }

        // 1 pound, or approximately 0.45 kg, equates to about 3,500 calories (7 days)
        public string loseWeightResults()
        {
            double maintainWeight = MifflinStJeorEquation();
            string mentain = System.Environment.NewLine + " Menține greutatea: " + maintainWeight + " kcal." + System.Environment.NewLine;
            string mild = System.Environment.NewLine + " Pierdere ușoară în greutate: " + (maintainWeight - 250) + " kcal." + System.Environment.NewLine;
            string lose = System.Environment.NewLine + " Pierdere în greutate: " + (maintainWeight - 500) + " kcal." + System.Environment.NewLine;
            string fast = System.Environment.NewLine + " Pierdere rapidă în greutate: " + (maintainWeight - 1000) + " kcal." + System.Environment.NewLine;
            string info = System.Environment.NewLine + "  Rezultatele arată o serie de estimări zilnice de calorii care pot fi folosite ca ghid pentru câte calorii trebuie consumate în fiecare zi.";
            string results = mentain + mild + lose + fast + info;
            return results;
        }

        public string gainWeightResults()
        {
            double maintainWeight = MifflinStJeorEquation();
            string mentain = System.Environment.NewLine + " Menține greutatea: " + maintainWeight + " kcal." + System.Environment.NewLine;
            string mild = System.Environment.NewLine + " Creștere ușoară în greutate: " + (maintainWeight + 250) + " kcal." + System.Environment.NewLine;
            string gain = System.Environment.NewLine + " Creștere în greutate: " + (maintainWeight + 500) + " kcal." + System.Environment.NewLine;
            string fast = System.Environment.NewLine + " Creștere rapidă în greutate: " + (maintainWeight + 1000) + " kcal." + System.Environment.NewLine;
            string info = System.Environment.NewLine + "  Rezultatele arată o serie de estimări zilnice de calorii care pot fi folosite ca ghid pentru câte calorii trebuie consumate în fiecare zi,";
            string results = mentain + mild + gain + fast + info;
            return results;
        }
    }

}
