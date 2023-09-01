/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *                                                                        *
 *  Descriere:   Calculam caloriile fiecarui client in functie de ce      *
 *              doreste sa faca, sa creasca sau sa scada in greutate      *
 *              si ii generam un target care trebuie sa il indeplineasca  *
 *              in fiecare zi                                             *
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
using BazadeDate;
using Meals;

namespace CalculatorCaloric
{
 
    public partial class MainForm : Form
    {
        /// <summary>
        /// Varaibilă de acces la interfața cu graficul
        /// </summary>
        private ProgressForm _progressForm;

        /// <summary>
        /// Instatierea clselor din DLL-uri
        /// </summary>
        private CalculatorDLL.Calculator _calculator;
        private BazadeDate.DB db = new BazadeDate.DB();

        /// <summary>
        /// Listă cu mesele dintr-o zi
        /// </summary>
        private List<Meals.Meals> _meals;

        private string _email;
        private string _password;
        public string Email{
            get { return _email; }
            set { _email = value; }
        }
        public string Password{
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// Varaiblilă ce sumează caloriile dintr-o zi
        /// </summary>
        private double dayCaloriesSum = 0;
        public MainForm()
        {
            /// <summary>
            /// Inițializare interfațe și componete ce vor fi folosite
            /// </summary>
            InitializeComponent();
            _meals = new List<Meals.Meals>();
            _progressForm = new ProgressForm();
        }


        private void buttonCalculate_Click(object sender, EventArgs e) {
            string gen;
            string activity;
            double weight;
            double height;
            int age;

            ///<summary>
            /// Extragere informații din baza de date
            ///</summary>
            gen = db.getGender(Email, Password);
            activity = db.getActivity(Email, Password);
            weight = db.getWeight(Email, Password);
            height = db.getHeight(Email, Password);
            age = db.getAge(Email, Password);

            _calculator = new CalculatorDLL.Calculator(gen, activity, weight, height, age);
            ///<summary>
            ///Cazul în care s-a apăsat butonul de pierdere greutate
            ///</summary>
            if (radioButtonLoseWeight.Checked){            
                textBoxResult.Text = _calculator.loseWeightResults();
                updateTargetCalories();

            }

            /// <summary>
            /// Cazul în care s-a apăsat butonul de crestere greutate
            /// </summary>
            else if (radioButtonGainWeight.Checked){ 
                textBoxResult.Text = _calculator.gainWeightResults();
                updateTargetCalories();

            }
        }

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            try
            {
                string stringCalories = textBoxAddCalories.Text;
                double calories;
                /// <summary>
                /// Preluare calorii masa respectivă
                /// </summary>
                if (!Double.TryParse(stringCalories, out calories))
                {
                    throw new ArgumentException("Invalid input for calories");
                }
                /// <summary>
                /// Adăugare la totalul de calorii zilnic
                /// </summary>
                dayCaloriesSum += calories;
                string mealListResult = "";
                double caloriesTotal = 0;
                /// <summary>
                /// Adăugare meniu în listă
                /// </summary>
                _meals.Add(new Meals.Meals(comboBoxMealType.SelectedItem.ToString(), double.Parse(textBoxAddCalories.Text)));
                foreach (Meals.Meals meal in _meals) {
                    mealListResult += Environment.NewLine + " " + meal.type + ": " + meal.calories + " kcal." + System.Environment.NewLine;
                    caloriesTotal += meal.calories;
                }
                textBoxMealsList.Text = mealListResult;
                textBoxDayCalories.Text = caloriesTotal.ToString();
                /// <summary>
                /// Actualizare target
                /// </summary>
                updateTargetCalories();
            }
            catch (Exception ex)
            {
                ///<summary>
                ///Mesaj de atentonare in cazul in care datele nu au fost introduse bine
                /// </summary>
                MessageBox.Show(ex.Message);
                comboBoxMealType.SelectedIndex = 0;
                textBoxAddCalories.Text = 1.ToString();
            }
        }


        private void textBoxTargetCalories_KeyUp(object sender, KeyEventArgs e){
            try{
                ///<summary>
                /// Se actualizează caloriile din target
                /// </summary>
                updateTargetCalories();  
            }
            catch (Exception ex){
                ///<summary>
                ///Se tratează cazul în care nu au fost bine introduse datele
                ///</summary>
                MessageBox.Show(ex.Message);
                textBoxTargetCalories.Text = "";
            }   
        }

        private void updateTargetCalories(){
            ///<summary>
            ///Verificare dacă există informații în textbox-uri cu calorii actuale și target
            ///</summary>
            if (!string.IsNullOrEmpty(textBoxTargetCalories.Text) && !string.IsNullOrEmpty(textBoxDayCalories.Text))
            {
                ///<summary>
                ///Verificare dacă targetul a fost atins și afișarea unui mesaj pentru fiecare caz
                ///</summary>
                if (int.Parse(textBoxDayCalories.Text) >= int.Parse(textBoxTargetCalories.Text))
                {
                    if (radioButtonGainWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target atins!";
                    else if (radioButtonLoseWeight.Checked)
                        textBoxCaloriesToTarget.Text = "Target depasit!";
                }
                else
                {
                    ///<summary>
                    ///Scade caloriile din target când a fost adăugată o nouă
                    ///</summary>
                    textBoxCaloriesToTarget.Text = (int.Parse(textBoxTargetCalories.Text) - int.Parse(textBoxDayCalories.Text)).ToString();
                }
            }
        }

        private void buttonShowProgress_Click(object sender, EventArgs e){
            //<summary>
            ///Apelarea interfeței cu grafice   
            ///</summary>    
            _progressForm.ShowDialog();
        }

        private void AddDayButon_Click(object sender, EventArgs e){
            ///<summary>
            ///Adăugare numărului de calorii dintr-o zi 
            ///</summary> 
            _progressForm.caloriesVector.Add(dayCaloriesSum);

            ///<summary>
            ///Resetarea tuturor câmpurilor de pe interfață
            ///</summary>
            dayCaloriesSum = 0;
            textBoxMealsList.Text = "";
            textBoxAddCalories.Text = "";
            textBoxTargetCalories.Text = "";
            textBoxCaloriesToTarget.Text = "";
            textBoxDayCalories.Text = "";
            _meals.Clear();

            ///<summary>
            ///Afișare calorii pe ziua respectivă
            ///</summary>
            MessageBox.Show("Total calorii adăugat");
        }

        private void textBoxAddCalories_TextChanged(object sender, EventArgs e){

        }

        private void button1_Click(object sender, EventArgs e){
            //_progressForm.caloriesVector.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e){
            ///<summary>
            ///Adăugare target zilnic pentru a putea fi afișat pe grafic
            ///</summary>
            if (textBoxTargetCalories.Text != null){
                string TargetCaloriesString = textBoxTargetCalories.Text;
                double TargetCalories = Convert.ToDouble(TargetCaloriesString);
                _progressForm.caloriesVector.Add(TargetCalories);
            }

            ///<summary>
            ///Afișare target zilnic
            ///</summary>
            MessageBox.Show("Target adăugat");
        }

        private void comboBoxMealType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
