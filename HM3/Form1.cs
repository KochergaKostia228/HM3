namespace HM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            string user = $"{TBName.Text}, {TBSoname.Text}, {TBEmail.Text}, {TBPhone.Text}";

            listUsers.Items.Add(user);

        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count > 0)
            {
                string editUser = $"{TBName.Text}, {TBSoname.Text}, {TBEmail.Text}, {TBPhone.Text}";

                int selectedIndex = listUsers.SelectedIndex;

                listUsers.Items.RemoveAt(selectedIndex);

                listUsers.Items.Insert(selectedIndex, editUser);
            }
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count > 0)
            {
                listUsers.Items.RemoveAt(listUsers.SelectedIndex);
            }
        }

        private void BTImport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, listUsers.Items.Cast<string>());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt Files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] s = File.ReadAllLines(openFileDialog.FileName);
                    listUsers.Items.AddRange(s);
                }
            }
        }
    }
}