
public class Card
{
    public int cardValue;
    public int lastCardValue;

    Random randomGenerator = new Random();
    public Card()
    {
        cardValue = randomGenerator.Next(1,14);
        lastCardValue = randomGenerator.Next(1,14); 
    }

    public void Update()
    {
        lastCardValue = cardValue;
        cardValue = randomGenerator.Next(1,14);
    }
}





// using System;


// namespace Unit02.Game
// {
//     // TODO: Implement the Die class as follows...
//     // 1) Add the class declaration. Use the following class comment.
//     public class Die
//     {
//         public int points;
//         public int value;
    

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 


    // 2) Create the class constructor. Use the following method comment.
    // public Die()
    // {

    // }

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>

    
    // 3) Create the Roll() method. Use the following method comment.
//     public void Roll()
//     {
//         Random randomGenerator = new Random();
//         int die = randomGenerator.Next(1,13);
//         value = die;
        
//         if (die == 1)
//         {
//             points = 100;
//         }

//         else if (die == 5)
//         {
//             points = 50;
//         }

//         else
//         {
//             points = 0;
//         }

//     }
//         /// <summary>
//         /// Generates a new random value and calculates the points for the die. Fives are 
//         /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
//         /// </summary>

//     }
        
// }
// public class 
// {
//     Random randomGenerator = new Random();

//     public card()
//     {

//     }

//     public int GetNewCard()
//     {
//         int card = randomGenerator.Next(1,14);
//         return card;
//     }
// }