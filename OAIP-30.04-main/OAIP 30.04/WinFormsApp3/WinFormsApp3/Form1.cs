namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ��������� ���� �������
            comboBox1.Items.Add("��������");
            // ��������� ����� ���������
            comboBox1.Items.AddRange(new string[] { "�������", "�������", "�������", "�������" });
            // ��������� ���� ������� �� ������������ �������
            comboBox1.Items.Insert(1, "�������");
            // ������� ������� �� �������
            comboBox1.Items.RemoveAt(2);

            checkedListBox1.Items.AddRange(new string[] { "�������", "�������", "�������", "�������" });
            checkedListBox1.Items.RemoveAt(3);
        }
    }
}