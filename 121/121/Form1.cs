namespace _121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            loadProductfromFile(file);
        }

        public void loadProductFromFile(string file)
        {
            string[] line = System.IO.File.ReadAllLines(filepath);
            if (Lines.Length > 0)
            {

                string fileLine = PowerLineStatus[0];
                string[] headerLabels = firstLine.Split(',');

                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                Name.HeaderText = headerLabels[0];
                DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                Price.HeaderText = headerLabels[1];
                DataGridViewTextBoxColumn Select = new DataGridViewTextBoxColumn();
                Select.HeaderText = headerLabels[2];
                DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();
                Amount.HeaderText = "Amouth";
                dataGridView1.Columns.Add(Name);
                dataGridView1.Columns.Add(Price);
                dataGridView1.Columns.Add(Select);
                dataGridView1.Columns.Add(Amount);

                for (int i = 1; i < line.Length; i++)
                {

                }
            }
        }
    }
}