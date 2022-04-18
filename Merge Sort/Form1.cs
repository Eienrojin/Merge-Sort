namespace Merge_Sort
{
    public partial class Form1 : Form
    {
        int size = 0;
        byte minSize = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (size >= minSize)
            {
                FillDataGridViewWithRandom();
            }
            else
            {
                warningLabel.Text = $"Размер слишком мал; задайте больше {minSize} элементов";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void FillDataGridViewWithRandom()
        {
            Random random = new();

            if (size >= minSize)
            {
                unsortedDataGridView.Rows.Add(size - 1);

                for (int i = 0; i < size ; i++)
                {
                    unsortedDataGridView[0, i].Value = random.Next(1, 900);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            warningLabel.Text = "";

            try
            {
                size = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                warningLabel.Text = "Неверный формат данных";
            }
        }

        /*====МУСОР====*/

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

      
    }
}