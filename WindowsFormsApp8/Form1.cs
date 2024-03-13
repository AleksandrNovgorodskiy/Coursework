using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection; // Створюємо з'єднання з базою даних

        public Form1()
        {
            InitializeComponent();
            button2.Click += button2_Click; // Додаємо обробник події для кнопки 2
            button3.Click += button3_Click; // Додаємо обробник події для кнопки 3
            button4.Click += button4_Click; // Додаємо обробник події для кнопки 4
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D://Coursework.accdb;"; // Рядок підключення до бази даних
            connection = new OleDbConnection(connectionString); // Ініціалізуємо з'єднання
            connection.Open(); // Відкриваємо з'єднання
            LoadData(); // Завантажуємо дані
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Гравці"; // SQL-запит

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection)) // Створюємо адаптер даних
            {
                DataTable dataTable = new DataTable(); // Створюємо таблицю даних
                adapter.Fill(dataTable); // Заповнюємо таблицю даних
                dataGridView1.DataSource = dataTable; // Встановлюємо джерело даних для DataGridView
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Гравці WHERE [Ім'я та прізвище] IN ('Денис Гармаш', 'Андрій Борячук', 'Артем Габелок')"; // SQL-запит

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection)) // Створюємо адаптер даних
            {
                DataTable dataTable = new DataTable(); // Створюємо таблицю даних
                adapter.Fill(dataTable); // Заповнюємо таблицю даних
                dataGridView1.DataSource = dataTable; // Встановлюємо джерело даних для DataGridView
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Гравці WHERE [Зарплата($)] > 5000"; // SQL-запит

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection)) // Створюємо адаптер даних
            {
                DataTable dataTable = new DataTable(); // Створюємо таблицю даних
                adapter.Fill(dataTable); // Заповнюємо таблицю даних
                dataGridView1.DataSource = dataTable; // Встановлюємо джерело даних для DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Гравці WHERE Голи > 20 ORDER BY Голи DESC"; // SQL-запит

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection)) // Створюємо адаптер даних
            {
                DataTable dataTable = new DataTable(); // Створюємо таблицю даних
                adapter.Fill(dataTable); // Заповнюємо таблицю даних
                dataGridView1.DataSource = dataTable; // Встановлюємо джерело даних для DataGridView
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData(); // Оновлюємо дані при натисканні кнопки "Оновлення даних"
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close(); // Закриваємо з'єднання при закритті форми
            }
        }
    }
}