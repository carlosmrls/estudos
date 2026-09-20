namespace Calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mais_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            var text2 = textBox2.Text;

            var calculo = int.Parse(text) - int.Parse(text2);

            MessageBox.Show(calculo.ToString());
        }
    }
}
