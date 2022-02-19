using System.Text;
namespace Income_And_Expenses
{
    public partial class Form1 : Form
    {
        เก็บข้อมูล oGPACal = new เก็บข้อมูล();

        //private string sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()== DialogResult.OK) {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBox1.Text = data;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.textBox1.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;

                File.WriteAllText(filepath, data, Encoding.UTF8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBox3.Text;
            string name = this.textBox4.Text;
            string comb = this.comboBox1.Text;

            //double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(comb, input, name);

            //double gpax = oGPACal.getGPAx();
            //textBoxGPAx.Text = gpax.ToString();

            //textBoxMaxGPA.Text = oGPACal.getMax().ToString();
            //textBoxMaxName.Text = oGPACal.getMaxName().ToString();

            //textBoxMinGPA.Text = oGPACal.getMin().ToString();
            //textBoxMinName.Text = oGPACal.getMinName().ToString();

            textBox4.Text = "";
            textBox3.Text = string.Empty;
            textBox1.Text = oGPACal.getAlldata();

            //textBox1.Text = oGPACal.getAlldata();
            // textBox1.Text = "\r\n"+ textBox3.Text +", "+ textBox4.Text + ", " + comboBox1.Text+ getAlldata();

            /*string te1 = textBox3.Text;
            string te2 = textBox4.Text;
            string te3 = comboBox1.Text;

            double sum = te1 + ", " + te2 + ", " + te3 + "\r\n";
            double dI = double.Parse(strInput);

            sum = sum+ dI;
            //sum = te1 + ", " + te2 + ", " + te3 + "\r\n";
            textBox1.Text = sum.ToString();
            */

            //textBox1.Text =textBox3.Text;
            // + textBox4.Text + comboBox1.Text;
        }
    }
}