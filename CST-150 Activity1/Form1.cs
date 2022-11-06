namespace CST_150_Activity1
{
    public partial class Form1 : Form
    {
        private readonly object Form1BackColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonhello_Click(object sender, EventArgs e)
        {
            lable_hellomessage.Text = "Nice to Meet you";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}