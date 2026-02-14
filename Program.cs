namespace IndexerExample
{
    public class Program
    {
        public static void Main()
        {
            Animals myAnimals = new Animals(new string[] { "Ella", "Yoda" });

            // Console.WriteLine(myAnimals[0]);
            // Console.WriteLine(myAnimals[1]);
            // Console.WriteLine(myAnimals[2]);
            // Console.WriteLine(myAnimals[3]);
            // Console.WriteLine(myAnimals[4]);
            // Console.WriteLine(myAnimals[5]); // Outside of boundry, animals can only contain 5 animals

            // Does the same thing, but here we are calling a method and passing it an int
            // With an indexer we can simply use brackets like we would do with a normal array
            Console.WriteLine(myAnimals.GetAnimal(0));

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

        public string GetAnimal(int index)
        {
            return animalList[index];
        }
    }

}