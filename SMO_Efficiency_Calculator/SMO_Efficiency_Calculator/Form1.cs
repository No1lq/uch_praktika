using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMO_Efficiency_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyStyles(); // Применяем стили после инициализации компонентов
        }

        private void ApplyStyles()
        {
            // Устанавливаем стиль формы (темный или светлый)
            this.BackColor = Color.FromArgb(30, 30, 30); // Темный фон
            this.ForeColor = Color.White; // Белый цвет текста

            // Устанавливаем стиль кнопок
            calculateButton.BackColor = Color.FromArgb(0, 122, 204); // Голубая кнопка
            calculateButton.ForeColor = Color.White; // Белый текст на кнопке
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.Font = new Font("Arial", 12, FontStyle.Bold);

            // Устанавливаем размеры кнопки, чтобы текст был виден полностью
            calculateButton.AutoSize = true;  // Автоматически подстраивает размер кнопки под текст
            calculateButton.Padding = new Padding(10); // Добавим отступы внутри кнопки для улучшенного внешнего вида

            // Устанавливаем стиль текстовых полей
            textBoxLambda.BackColor = Color.FromArgb(45, 45, 45);
            textBoxLambda.ForeColor = Color.White;
            textBoxLambda.Font = new Font("Arial", 12);

            textBoxMu.BackColor = Color.FromArgb(45, 45, 45);
            textBoxMu.ForeColor = Color.White;
            textBoxMu.Font = new Font("Arial", 12);

            textBoxN.BackColor = Color.FromArgb(45, 45, 45);
            textBoxN.ForeColor = Color.White;
            textBoxN.Font = new Font("Arial", 12);

            // Устанавливаем стиль меток (label)
            labelPotk.ForeColor = Color.White;
            labelQ.ForeColor = Color.White;
            labelA.ForeColor = Color.White;

            // Сделаем отступы, чтобы элементы выглядели красиво
            labelPotk.Font = new Font("Arial", 12);
            labelQ.Font = new Font("Arial", 12);
            labelA.Font = new Font("Arial", 12);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем входные данные
                double lambda = double.Parse(textBoxLambda.Text);
                double mu = double.Parse(textBoxMu.Text);
                int N = int.Parse(textBoxN.Text);

                // Вычисляем коэффициент нагрузки
                double rho = lambda / mu;
                double P0 = 0;

                // Вычисляем P0
                for (int k = 0; k <= N; k++)
                {
                    P0 += Math.Pow(rho, k) / Factorial(k);
                }
                P0 = 1.0 / P0;

                // Вероятность отказа
                double potk = (Math.Pow(rho, N) / Factorial(N)) * P0;

                // Относительная пропускная способность
                double Q = 1 - potk;

                // Абсолютная пропускная способность
                double A = lambda * Q;

                // Отображаем результаты в соответствующих текстовых полях или метках
                labelPotk.Text = $"Вероятность отказа: {potk:F4}";
                labelQ.Text = $"Отн. пропускная способность Q: {Q:F4}";
                labelA.Text = $"Абс. пропускная способность A: {A:F4}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Убедитесь, что все значения корректны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            double result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }
}
