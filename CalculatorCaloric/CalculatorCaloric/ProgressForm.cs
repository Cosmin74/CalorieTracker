/**************************************************************************
 *                                                                        *
 *  File:        ProgressFrom.cs                                          *
 *                                                                        *
 *  Descriere:Se afișează un grafic cu evoluția pe zile                   *
 *              a progresului utilizatorului                              *
 *                                                                        *
 *                                                                        *
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
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace CalculatorCaloric
{
    public partial class ProgressForm : Form
    {
        /// <summary>
        /// Control foslosit pentru afișarea graficului
        /// </summary>
        private PictureBox pictureBox;


        /// <summary>
        /// Vector ce ține minte numărul zilnic de calorii
        /// </summary>
        public List<double> caloriesVector = new List<double>();
        public ProgressForm(){
            InitializeComponent();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox == null)
                {
                    /// <summary>
                    /// Inițializare picture box pentru grafic 
                    /// </summary>
                    pictureBox = new PictureBox();
                    pictureBox.Width = 800;
                    pictureBox.Height = 500;
                    pictureBox.Location = new Point(0, 0);
                    pictureBox.BackColor = Color.White;
                    Controls.Add(pictureBox);
                }

                using (Graphics graphics = pictureBox.CreateGraphics())
                {
                    graphics.Clear(Color.White);

                    /// <summary>
                    /// Setare coordonate grafic
                    /// </summary>
                    int xStart = 50;
                    int yStart = pictureBox.Height - 50;

                    int xMax = pictureBox.Width - 50;
                    int yMax = 50;

                    /// <summary>
                    /// Desenare axe
                    /// </summary>
                    Pen axisPen = new Pen(Color.Black, 2);
                    graphics.DrawLine(axisPen, xStart, yStart, xMax, yStart);
                    graphics.DrawLine(axisPen, xStart, yStart, xStart, yMax);

                    int pointRadius = 5;

                    /// <summary>
                    /// Setare culori pentru axe și valori
                    /// </summary>
                    Brush pointBrush = new SolidBrush(Color.Blue);
                    for (int i = 0; i < caloriesVector.Count; i++)
                    {
                        float x = xStart + (float)(((caloriesVector[i] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                        float y = yStart - (float)(((double)i / (double)(caloriesVector.Count - 1)) * (yStart - yMax));

                        graphics.FillEllipse(pointBrush, x - pointRadius, y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                        if (i > 0)
                        {
                            float xPrev = xStart + (float)(((caloriesVector[i - 1] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                            float yPrev = yStart - (float)(((double)(i - 1) / (double)(caloriesVector.Count - 1)) * (yStart - yMax));
                            Pen linePen = new Pen(Color.Blue, 2);
                            graphics.DrawLine(linePen, xPrev, yPrev, x, y);
                        }
                    }

                    /// <summary>
                    /// Setare valori axe
                    /// </summary>
                    int numTicks = 5;
                    double xIncrement = (caloriesVector.Count - 1) / (double)numTicks;
                    double yIncrement = (caloriesVector.Max() - caloriesVector.Min()) / numTicks;
                    double xTickValue = 0;
                    double yTickValue = caloriesVector.Min();
                    Font font = new Font("Arial", 10);
                    Brush textBrush = new SolidBrush(Color.Green);

                    /// <summary>
                    /// Desenare valori pe axe
                    /// </summary>
                    for (int i = 0; i <= numTicks; i++)
                    {
                        int y = yStart - (int)((yTickValue - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min()) * (yStart - yMax));
                        if (y >= yMax && y <= yStart)
                        {
                            graphics.DrawLine(axisPen, xStart - 5, y, xStart, y);
                        }
                        graphics.DrawString(yTickValue.ToString("N2"), font, textBrush, xStart - 45, y - 6);
                        yTickValue += yIncrement;
                    }
                }
            }
            catch (Exception ex)
            {
                /// <summary>
                /// Gestionare erori de desenare
                /// </summary>
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox == null)
                {
                    /// <summary>
                    /// Inițializare picture box pentru grafic 
                    /// </summary>
                    pictureBox = new PictureBox();
                    pictureBox.Width = 800;
                    pictureBox.Height = 500;
                    pictureBox.Location = new Point(0, 0);
                    pictureBox.BackColor = Color.White;
                    Controls.Add(pictureBox);
                }

                using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.White);

                        /// <summary>
                        /// Setare coordonate grafic
                        /// </summary>
                        int xStart = 50;
                        int yStart = pictureBox.Height - 50;

                        int xMax = pictureBox.Width - 50;
                        int yMax = 50;

                        /// <summary>
                        /// Desenare axe
                        /// </summary>
                        Pen axisPen = new Pen(Color.Black, 2);
                        graphics.DrawLine(axisPen, xStart, yStart, xMax, yStart);
                        graphics.DrawLine(axisPen, xStart, yStart, xStart, yMax);

                        int pointRadius = 5;

                        /// <summary>
                        /// Setare culori pentru axe și valori
                        /// </summary>
                        Brush pointBrush = new SolidBrush(Color.Blue);
                        for (int i = 0; i < caloriesVector.Count; i++)
                        {
                            float x = xStart + (float)(((caloriesVector[i] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                            float y = yStart - (float)(((double)i / (double)(caloriesVector.Count - 1)) * (yStart - yMax));

                            graphics.FillEllipse(pointBrush, x - pointRadius, y - pointRadius, 2 * pointRadius, 2 * pointRadius);
                            if (i > 0)
                            {
                                float xPrev = xStart + (float)(((caloriesVector[i - 1] - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min())) * (xMax - xStart));
                                float yPrev = yStart - (float)(((double)(i - 1) / (double)(caloriesVector.Count - 1)) * (yStart - yMax));
                                Pen linePen = new Pen(Color.Blue, 2);
                                graphics.DrawLine(linePen, xPrev, yPrev, x, y);
                            }
                        }

                        /// <summary>
                        /// Setare valori axe
                        /// </summary>
                        int numTicks = 5;
                        double xIncrement = (caloriesVector.Count - 1) / (double)numTicks;
                        double yIncrement = (caloriesVector.Max() - caloriesVector.Min()) / numTicks;
                        double xTickValue = 0;
                        double yTickValue = caloriesVector.Min();
                        Font font = new Font("Arial", 10);
                        Brush textBrush = new SolidBrush(Color.Green);

                        /// <summary>
                        /// Desenare valori pe axe
                        /// </summary>
                        for (int i = 0; i <= numTicks; i++)
                        {
                            int y = yStart - (int)((yTickValue - caloriesVector.Min()) / (caloriesVector.Max() - caloriesVector.Min()) * (yStart - yMax));
                            if (y >= yMax && y <= yStart)
                            {
                                graphics.DrawLine(axisPen, xStart - 5, y, xStart, y);
                            }
                            graphics.DrawString(yTickValue.ToString("N2"), font, textBrush, xStart - 45, y - 6);
                            yTickValue += yIncrement;
                        }
                    }

                    /// <summary>
                    /// Afișare opțiuni pentru utilizator de salvare ca poză
                    /// </summary>
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                            MessageBox.Show("Imagine salvată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                /// <summary>
                /// Gestionare erori la desenare
                /// </summary>
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}