namespace estudos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            if (text == "")
            {
                MessageBox.Show("campo esta vazio por favor preencher");
            }

            else
            {
                MessageBox.Show(text);
            }
        }
    }
}
