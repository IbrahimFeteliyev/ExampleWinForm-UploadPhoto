namespace ExampleWinForm
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = opnfd.FileName;
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }



        private void Submit_Click(object sender, EventArgs e)
        {
         
            Form2 frm2 = new Form2(pictureBox1.Image);

            frm2.Show();

            File.Copy(textBox1.Text, Path.Combine(@"E:\C#\source\repos\ExampleWinForm\ExampleWinForm\Images\",Path.GetFileName(textBox1.Text)),true);
        }
    }
}