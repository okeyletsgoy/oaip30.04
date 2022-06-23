namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // добавляем один элемент
            comboBox1.Items.Add("Парагвай");
            // добавляем набор элементов
            comboBox1.Items.AddRange(new string[] { "Уругвай", "Румакан", "Каратан", "Эквадор" });
            // добавляем один элемент на определенную позицию
            comboBox1.Items.Insert(1, "Боливия");
            // удаляем элемент по индексу
            comboBox1.Items.RemoveAt(2);

            checkedListBox1.Items.AddRange(new string[] { "Уругвай", "Румакан", "Каратан", "Эквадор" });
            checkedListBox1.Items.RemoveAt(3);
        }
    }
}