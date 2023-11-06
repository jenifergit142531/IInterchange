namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="jeni" && textBox2.Text=="jeni123")
            {
                MessageBox.Show("Welcome " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}