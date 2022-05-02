using System.Text;
namespace Calculator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        bool OperandPerformed = false;

        private void NumEvent(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || OperandPerformed)
            {
                textBox1.Clear();
            }
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            OperandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            OperandPerformed = true;
        }
    }
}