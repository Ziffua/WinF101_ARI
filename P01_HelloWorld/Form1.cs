namespace P01_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            label1.Text = "Hellow World";
        }

        private void Kapat(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
