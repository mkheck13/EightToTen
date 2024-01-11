

namespace EightToTen.Services.RestPicker;

    public class PickerService : IPickerService
    {
        public string[] pizzaArr = {"Round Table", "Dante's", "Domino's", "David's", "Papa Murphy's", "Michael's", "Eddie's", "Little Caesars", "Pizza Hut", "Pizza Guys"};

        public string[] fastArr = {"Subway", "Dairy Queen", "McDonalds", "Burger King", "Wendys", "Sonic", "In-N-Out", "Jack in the Box", "Taco Bell", "Carl's Jr."};

        public string[] mexArr = {"Miguel's", "El Señor Frog's", "Adalberto's", "Casa Flores", "Alberto's", "El Grullito", "Taco House", "Yellow House", "Arroyos", "Cancun"};

        public Random randNum = new();
        public string RestaurantPicker(string input)
        {
            int randIndex = randNum.Next(0,10);
            string userInput = input.ToLower();
            
            if(userInput == "pizza" || userInput == "fast food" || userInput == "mexican"){
                if(userInput == "pizza"){
                    return pizzaArr[randIndex];
                }
                else if(userInput == "fast food")
                {
                    return fastArr[randIndex];
                }
                else
                {
                    return mexArr[randIndex];
                }
            }
            else
            {
                return "That doesn't seem to be an option. Please pick from pizza, fast food, or mexican";
            }
        }
    }
