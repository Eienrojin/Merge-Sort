using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    internal class MergeSort
    {
		private static void Merge(List<int> list, int left, int middle, int right)
		{
			int k = left;
			int i = 0; // Индексы для подмассиов
			int j = 0;

			// Нахождение размеров двух подмассивов
			int leftSize = middle - left + 1;
			int rightSize = right - middle;

			int[] tempLeft = new int[leftSize];
			int[] tempRight = new int[rightSize];

			// Копирование во временные массивы
			for (i = 0; i < leftSize; i++)
				tempLeft[i] = list[left + i];

			for (j = 0; j < rightSize; j++)
				tempRight[j] = list[middle + 1 + j];

			// Merge the temp arrays

			i = 0;
			j = 0;

			while (i < leftSize && j < rightSize)
			{
				if (tempLeft[i] <= tempRight[j])
				{
					list[k] = tempLeft[i];
					i++;
				}
				else
				{
					list[k] = tempRight[j];
					j++;
				}

				k++;
			}

			// Copy remaining elements of L[] if any
			while (i < leftSize)
			{
				list[k] = tempLeft[i];

				i++;
				k++;
			}

			// Copy remaining elements of R[] if any
			while (j < rightSize)
			{
				list[k] = tempRight[j];

				j++;
				k++;
			}
		}

		public static void Sort(List<int> list, int left, int right)
		{
			if (left < right)
			{
				//finding the middle point
				int middle = left + (right - left) / 2;

				//sort two subarrays
				Sort(list, left, middle);
				Sort(list, middle + 1, right);

				//merge two subarrays
				Merge(list, left, middle, right);
			}
		}
	}
}