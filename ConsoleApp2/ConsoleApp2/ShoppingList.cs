namespace ConsoleApp1;

public class ShoppingList
{
    public void Items()
    {
        string[] itemList = new string[10]; 
        int itemCount = 0; 

        while (true) 
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (input.StartsWith("+")) 
            {
                string itemToAdd = input.Substring(1).Trim(); 
                itemList[itemCount] = itemToAdd; 
                itemCount++; 
            }
            else if (input == "--") 
            {
                Array.Clear(itemList, 0, itemCount); 
                itemCount = 0;
                Console.WriteLine("List cleared.");
            }
            else if (input.StartsWith("-")) 
            {
                string itemToRemove = input.Substring(1).Trim(); 
                bool found = false;

                for (int i = 0; i < itemCount; i++)
                {
                    if (itemList[i] == itemToRemove)
                    {
                        for (int j = i; j < itemCount - 1; j++)
                        {
                            itemList[j] = itemList[j + 1];
                        }
                        itemCount--; 
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Item '{itemToRemove}' not found in the list.");
                }
            }
           
            else 
            {
                Console.WriteLine("Invalid command. Please use '+ item', '- item', or '--'.");
            }
            
            Console.WriteLine("Current list:");
            if (itemCount == 0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                for (int i = 0; i < itemCount; i++)
                {
                    Console.WriteLine("- " + itemList[i]);
                }
            }

            Console.WriteLine(); 
        }

    }
    
}