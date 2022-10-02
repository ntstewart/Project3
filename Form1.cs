namespace Project3
{
    public partial class Form1 : Form
    {
        int[] scoreTotal1 = new int[SIZE];
        const int SIZE = 9;
        int score1;
        int i = 0;
        int j = 0;
        int sum1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            if (i < SIZE)
            {
                scoreTotal1[i] = int.Parse(textBox3.Text);
                listBox1.Items.Add(scoreTotal1[i]);
                sum1 += Convert.ToInt32(listBox1.Items[i++]);
                textBox3.Text = "";
                j++;
                label4.Text = "Hole Number: " + j;
                label6.Text = "Total Score: " + sum1;
            }
            else
            {
                textBox3.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}