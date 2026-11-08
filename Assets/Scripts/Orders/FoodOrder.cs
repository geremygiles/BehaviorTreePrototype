using System.Collections.Generic;
using UnityEngine;

public class FoodOrder
{
    private Dictionary<string, int> order = new();
    private string orderString = string.Empty;

    public string OrderString
    {
        get
        {
            if (orderString == string.Empty)
            {
                orderString = CreateOrderString();
            }
            return orderString;
        }
    }

    public FoodOrder()
    {
        CreateOrder();
        CreateOrderString();
    }

    public void CreateOrder()
    {
        // Keep track of all the ingredients that have yet to be added
        List<int> notYetOrdered = new();
        for (int i = 0; i < FoodData.Ingredients.Length; i++) { notYetOrdered.Add(i); }

        int ingredientCount = Random.Range(2, FoodData.Ingredients.Length);
        for (int i = 0; i < ingredientCount; i++)
        {
            int index = notYetOrdered[Random.Range(0, notYetOrdered.Count)];
            notYetOrdered.Remove(index);

            // Generate a quantity: 0: none, 1-3: light, 4-7: normal, 8-10: extra
            int quantity = Random.Range(0, 11);

            // Add to the order dictionary
            order.Add(FoodData.Ingredients[index], quantity);

        }


        
    }

    private string CreateOrderString()
    {
        // Create a string to build order
        string orderString = string.Empty;

        // Add a random greeting
        int greetingIndex = Random.Range(0, FoodData.Greetings.Length);
        orderString += FoodData.Greetings[greetingIndex];
        orderString += " a burger with ";

        int index = -1;
        foreach ((string food, int quantity) in order)
        {
            index++;
            if (quantity <= 0) { orderString += FoodData.Modifiers[0] + " "; } // No
            else if (quantity <= 3) { orderString += FoodData.Modifiers[1] + " "; } // Light
            else if (quantity > 7) { orderString += FoodData.Modifiers[2] + " "; } // Extra

            orderString += food;

            if (index < order.Count - 2)
            {
                orderString += ", ";
            }
            else if (index < order.Count - 1)
            {
                orderString += ", and ";
            }           
        }
        if (greetingIndex < 1) { orderString += "?"; } // Customer phrased it like a question at the beginning.
        else { orderString += "."; }
        orderString += " " + FoodData.Closings[Random.Range(0, FoodData.Closings.Length)];

        return orderString;
    }
}

public static class FoodData
{
    public static string[] Greetings =
    {
        "Hey, how's it goin? Can I get",
        "Hi. I'll have",
        "Hello! I'd like",
        "Yo, what's up? Let me get",
    };

    public static string[] Ingredients =
    {
        "tomato",
        "lettuce",
        "cheese",
        "onion",
        "jalapeno",
        "avocado",
        "mushroom",
        "bacon",
        "ketchup",
        "mustard",
        "mayo",
        "barbeque sauce"
    };

    public static string[] Modifiers =
    {
        "no",
        "extra",
        "a little"
    };

    public static string[] Closings =
    {
        "Thanks!",
        "That's all. Thank you.",
        "Got it?",
        "I appreciate it!",
        "You're the best!"
    };
}

