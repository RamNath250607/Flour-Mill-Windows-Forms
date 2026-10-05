namespace WinFormsApp1
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
            Form2 registerForm = new Form2(); // Create Form2 object
            registerForm.Show();              // Show Form2
            this.Hide();
        }
    }
}
