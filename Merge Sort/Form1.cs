namespace Merge_Sort
{
    public partial class Form1 : Form
    {
        int size = 0;
        byte minSize = 10;
        List<int> listToSort;

        public Form1()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (size != 0)
            {
                MergeSort.Sort(listToSort, 0, listToSort.Count - 1);

                FillSortedDataGridView();
            }
            else
            {
                warningLabel.Text = "Первая таблица не заполнена";
            }
        }

        private void FillSortedDataGridView()
        {
            sortedDataGridView.Rows.Clear();

            while (sortedDataGridView.Rows.Count < unsortedDataGridView.Rows.Count)
                sortedDataGridView.Rows.Add(1);

            for (int i = 0; i < listToSort.Count; i++)
            {
                sortedDataGridView[0, i].Value = listToSort[i];
            }
        }

        private void fillWithRandomButton_Click(object sender, EventArgs e)
        {
            if (size >= minSize)
            {
                FillDataGridViewWithRandom();

                listToSort.Clear();

                listToSort = SetValuesForList();
            }
            else
            {
                warningLabel.Text = $"Размер слишком мал; задайте больше {minSize} элементов";
            }
        }

        private void FillDataGridViewWithRandom()
        {
            Random random = new();

            unsortedDataGridView.Rows.Clear();

            while (unsortedDataGridView.Rows.Count < size)
                unsortedDataGridView.Rows.Add(1);

            for (int i = 0; i < size; i++)
            {
                unsortedDataGridView[0, i].Value = random.Next();
            }

        }

        private List<int> SetValuesForList()
        {
            List<int> tempList = new();
            
            for (int i = 0; i < unsortedDataGridView.Rows.Count; i++)
            {
                tempList.Insert(0, (int)unsortedDataGridView[0, i].Value);
            }

            return tempList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool safe = true;

            warningLabel.Text = "";

            try
            {
                size = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                safe = false;
                warningLabel.Text = "Неверный формат данных";
            }

            if (safe)
            {
                listToSort = new();
            }
        }
    }
}