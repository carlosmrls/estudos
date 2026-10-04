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

            if (text == "" || text2 == "")
            {
                MessageBox.Show("preencha o espaço");
            }

            else if(text == "" && text2 == "")
            {
                MessageBox.Show("preencha o espaço");
            }

            else 
            {
                var calculo = int.Parse(text) - int.Parse(text2);

                MessageBox.Show(calculo.ToString());

                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text4 = textBox4.Text;
            var text3 = textBox3.Text;

            var calculo = int.Parse(text3) + int.Parse(text4);

            MessageBox.Show(calculo.ToString());
        }



        private void multiplicaçao_Click(object sender, EventArgs e)
        {
            var text5 = textBox5.Text;
            var text6 = textBox6.Text;

            var calculo = int.Parse(text5) * int.Parse(text6);

            MessageBox.Show(calculo.ToString());
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            var text7 = textBox7.Text;
            var text8 = textBox8.Text;

            var calculo = int.Parse(text7) / int.Parse(text8);

            MessageBox.Show(calculo.ToString());
        }

        private void divisao_Click_1(object sender, EventArgs e)
        {
            var text7 = textBox7.Text;
            var text8 = textBox8.Text;

            var calculo = int.Parse(text7) / int.Parse(text8);

            MessageBox.Show(calculo.ToString());
        }
    }
}
    
















