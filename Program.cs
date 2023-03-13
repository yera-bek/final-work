 string[] array = { "robot", "dog", "1578", "box", "-7", "moon" };

        string[] returnArray = GetShortText(array);

        Console.WriteLine("Short text:");
        foreach (string word in returnArray)
        {
            Console.WriteLine(word);
        }

        
string[] GetShortText(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] shortText = new string[count];

        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                shortText[index] = array[i];
                index++;
            }
        }

        return shortText;
    }
