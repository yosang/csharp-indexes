namespace IndexerExample
{
    public class Program
    {
        public static void Main()
        {
            Animals myAnimals = new Animals(new string[] { "Ella", "Yoda" });

            // With indexer
            Console.WriteLine(myAnimals[0]);
            Console.WriteLine(myAnimals[1]);
            // Console.WriteLine(myAnimals[2]); // just an empty space in memory since the array has a size of 5 by default
            // Console.WriteLine(myAnimals[5]); // Outside of boundry, animals can only contain 5 animals

            // Without indexer
            // Does the same thing, but here we are calling a method and passing it an int
            // With an indexer we can simply use brackets like we would do with a normal array
            // Console.WriteLine(myAnimals.GetAnimal(0));

            // Multidimensional Indexer
            myAnimals[0, 1] = "Buddy";

            Console.WriteLine(myAnimals[0, 1]); // Buddy

        }
    }

    public class Animals
    {
        static public int size = 5;
        static public int sizeX = 2;
        static public int sizeY = 3;
        private string[] animalList = new string[size];
        private string[,] animalMatrix = new string[sizeX, sizeY];

        // Constructor - Alows us to pass it an array and fill out the rest of the spots
        public Animals(string[] arr)
        {
            int slots = 0;

            // Copy the array of animals passed
            for (int i = 0; i < arr.Length; i++)
            {
                animalList[i] = arr[i];
                slots++;
            }
        }

        // Indexer
        // They allow us access control to a class member that can be indexed like an array
        // Similar to properties, but we use this as the name
        // Declared with square brackets [] instead of braces ()
        // The get method returns animalList[index]
        // The set method assigns value to animalList[index]
        // Without an indexer we would have to design a method that does the same thing and call it like Animals.GetAnimal(0)
        public string this[int index]
        {
            get => animalList[index];
            set => animalList[index] = value;
        }

        // Without an indexer we would have to use this
        public string GetAnimal(int index)
        {
            return animalList[index];
        }

        public string this[int row, int col]
        {
            get => animalMatrix[row, col];
            set => animalMatrix[row, col] = value;
        }
    }

}