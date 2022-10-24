using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deccardextension9d11
{
    internal class extension
    {
		public static void main(String[] args)
		{
			String[] cardType = { "Clubs", "Diamonds", "Hearts", "Spades" };
			String[] cardNumb = { "201", "302", "403", "504", "605", "706", "807", "908", "1009", "Jack10", "Queen11",
				"King12", "Ace13" };
			String[] cardDeck = new String[52];
			QueueImplementedUsingLinkedList<String> queue = new QueueImplementedUsingLinkedList<String>();
			int j2 = 0;
			for (int i = 0; i < cardType.Length; i++)
			{
				for (int j = 0; j < cardNumb.Length; j++)
				{
					cardDeck[j2] = cardType[i] + " " + cardNumb[j];
					j2++;
				}
			}
			cardDeck = OOPsUtility.shuffleCardsDeck(cardDeck);
			String[] arr = new String[9];
			char[] last1 = new char[2];
			char[] last2 = new char[2];
			j2 = 0;
			String temp1, temp2, temp3, temp4;
			for (int p = 0; p < 4; p++)
			{
				for (int j = 0; j < 9; j++)
				{
					arr[j] = cardDeck[j2];
					j2++;

				}
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = 0; j < arr.Length - i - 1; j++)
					{
						temp1 = arr[j];
						temp2 = arr[j + 1];

						last1[0] = temp1.(temp1.Length() - 2);
						last1[1] = temp1.(temp1.Length() - 1);
						last2[0] = temp2.(temp2.Length() - 2);
						last2[1] = temp2.(temp2.Length() - 1);
						if (Arrays.compare(last1, last2) > 0)
						{
							temp3 = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temp3;

						}

					}

				}
				queue.enQueue("For Player " + p + " : \n");
				for (int j = 0; j < 9; j++)
				{
					temp4 = arr[j].Substring(0, arr[j].Length() - 2);
					queue.enQueue(temp4 + "-->");
				}
				queue.enQueue("\n");
			}
			Console.WriteLine(queue.showQueueWithoutSpace());

		}

	}

    internal class Arrays
    {
        internal static int compare(char[] last1, char[] last2)
        {
            throw new NotImplementedException();
        }
    }

    internal class OOPsUtility
    {
        internal static string[] shuffleCardsDeck(string[] cardDeck)
        {
            throw new NotImplementedException();
        }
    }

    internal class QueueImplementedUsingLinkedList<T>
    {
        internal void enQueue(string v)
        {
            throw new NotImplementedException();
        }

        internal bool showQueueWithoutSpace()
        {
            throw new NotImplementedException();
        }
    }
}
					
