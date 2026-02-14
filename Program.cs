namespace IndexerExample
{
    public class Program
    {
        public static void Main()
        {
            Animals myAnimals = new Animals(new string[] { "Ella", "Yoda" });

            Console.WriteLine(myAnimals[0]);
            Console.WriteLine(myAnimals[1]);
            Console.WriteLine(myAnimals[2]);
            Console.WriteLine(myAnimals[3]);
            Console.WriteLine(myAnimals[4]);
            // Console.WriteLine(myAnimals[5]); // Outside of boundry, animals can only contain 5 animals
        }
    }

    public class Animals
    {
        static public int size = 5;
        private string[] animalList = new string[size];

        // Constructor - Lets us pass an array when creatin animals
        public Animals(string[] arr)
        {
            int slots = 0;

            // Copy the array of animals passed
            for (int i = 0; i < arr.Length; i++)
            {
                animalList[i] = arr[i];
                slots++;
            }

            // Fill the rest of the slots
            for (int j = slots; j < size; j++)
            {
                animalList[j] = "Empty slot";
            }
        }

        // Indexer
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException("Invalid animal index");
                }
                return animalList[index];
            }

            set
            {
                animalList[index] = value;
            }
        }
    }

}