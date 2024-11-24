namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBox1.Text);
            string tabla = "";

            for (int i = 0; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }

            this.richTextBox1.AppendText(tabla);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
