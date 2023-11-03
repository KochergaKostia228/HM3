namespace HM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fP = openFileDialog.FileName;

                string text = File.ReadAllText(fP);

                progressBar1.Maximum = text.Length;
                progressBar1.Value = 0;

                textBox1.Text = text;

                foreach (char c in text)
                {
                    progressBar1.Value++;
                }

                MessageBox.Show("The text was read successfully");
            }
        }
    }
}