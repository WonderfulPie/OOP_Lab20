using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_20_OOP_Danylko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);

                double discriminant = b * b - 4 * a * c;

                double x1, x2;

                if (discriminant < 0)
                {
                    throw new Exception("Дискримінант менше нуля. Рівняння не має дійсних коренів.");
                }
                else if (discriminant == 0)
                {
                    x1 = x2 = -b / (2 * a);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }

                label1.Text = $"x1 = {x1:F5}";
                label2.Text = $"x2 = {x2:F5}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Невірний формат введених даних. Будь ласка, введіть числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Очистка введених даних у текстових полях
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }
    }
}