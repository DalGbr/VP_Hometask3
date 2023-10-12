namespace VisualProgramming_EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double weight;
                double height;
                double index;

                weight = double.Parse(textBox1.Text);
                height = double.Parse(textBox2.Text);
                index = Math.Round(weight / (height * height) * 703, 2);

                if (index < 18.5)
                {
                    textBox3.Text = "BMI: " + index + ". Status: underweight";
                }
                else if (index > 18.5 & index < 25)
                {
                    textBox3.Text = "BMI: " + index + ". Status: normal";
                }
                else
                {
                    textBox3.Text = "BMI: " + index + ". Status: overweight";
                }

            }
            catch
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}