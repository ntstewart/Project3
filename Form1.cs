namespace Project3
{
    public partial class Form1 : Form
    {
        int[] scoreTotal1 = new int[SIZE];
        int[] scoreTotal2 = new int[SIZE];
        const int SIZE = 9;
        int i = 0;
        int j = 0;
        int k = 0; 
        int n = 0;
        int sum1 = 0;
        int sum2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (i < SIZE)
            {
                j++;
                label4.Text = "Hole Number: " + j;
                scoreTotal1[i] = int.Parse(textBox3.Text);
                listBox1.Items.Add(scoreTotal1[i]);
                sum1 += Convert.ToInt32(listBox1.Items[i++]);
                textBox3.Text = "";
                
                label6.Text = "Total Score: " + sum1;
            }
            else
            {
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (k < SIZE)
            {
                n++;
                label5.Text = "Hole Number: " + n;
                scoreTotal2[k] = int.Parse(textBox4.Text);
                listBox2.Items.Add(scoreTotal2[k]);
                sum2 += Convert.ToInt32(listBox2.Items[k++]);
                textBox4.Text = "";

                label7.Text = "Total Score: " + sum2;
            }
            else
            {
                textBox4.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            if (sum1 < sum2)
            {
                label8.Text = name1;
            }
            else if (sum2 < sum1)
            {
                label8.Text = name2;
            }
            else
            {
                label8.Text = "Please Enter Scores";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}