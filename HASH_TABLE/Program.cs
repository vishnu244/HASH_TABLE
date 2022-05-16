// See https://aka.ms/new-console-template for more information
using HASH_TABLE;

Console.WriteLine("WELCOME TO HASHTABLE PROBLEM!");


while (true)
{
    Console.WriteLine("Please choose the option :\n1)Frequency of a sentence\n2)Frequency of a Paragraph\n3)Removing words");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            HashMethods<string, int> hash = new HashMethods<string, int>(5);
            string Words = "To be or not to be";
            string[] array = Words.Split(' ');
            LinkedList<string> checkForDuplicationS = new LinkedList<string>();
            foreach (string element in array)
            {
                int count = 0;
                foreach (string match in array)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplicationS.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplicationS.Contains(element))
                {
                    checkForDuplicationS.AddLast(element);
                    hash.Add(element, count);
                }
            }
            hash.Display();
            break;

        case 2:
            HashMethods<string, int> hash2 = new HashMethods<string, int>(5);
            string Word = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] array2 = Word.Split(' ');
            LinkedList<string> checkForDuplication2 = new LinkedList<string>();
            foreach (string element in array2)
            {
                int count = 0;
                foreach (string match in array2)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplication2.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplication2.Contains(element))
                {
                    checkForDuplication2.AddLast(element);
                    hash2.Add(element, count);
                }
            }
            hash2.Display();
            break;
        case 3:
            HashMethods<string, int> hash3 = new HashMethods<string, int>(5);
            string Para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr = Para.Split(' ');
            LinkedList<string> checkForduplication = new LinkedList<string>();
            foreach (string element in arr)
            {
                int count = 0;
                foreach (string match in arr)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForduplication.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForduplication.Contains(element))
                {
                    checkForduplication.AddLast(element);
                    hash3.Add(element, count);
                }
            }
            hash3.Display();
            Console.WriteLine("Please enter the word u want to remove :");
            string WordToRemove = Console.ReadLine();
            hash3.Remove(WordToRemove);
            hash3.Display();
            break;
    }
}