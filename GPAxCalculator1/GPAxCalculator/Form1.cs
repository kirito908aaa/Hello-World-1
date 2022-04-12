namespace GPAx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.GPAx();
            textBoxGPA.Text = gpax.ToString();

            double max = oGPAcal.getMAx();
            textBoxMaxGPA.text = max.ToString();
            textboxMaxName.Text = oGPAcal.getMaxName().ToString();

            double max = oGPAcal.getMin();
            textBoxMinGPA.text = min.ToString();
            textboxMinName.Text = oGPAcal.getMinName().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = string.Empty
            teatBoxALLData.Text = oGPAcal.getALLdata();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            textBoxName_input.Text = "";
            textBoxMaxName.Text = "";
            textBoxMinName.Text = "";
            textBoxALLData.Text = "";
        }
    }
}
