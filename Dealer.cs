public class Dealer
{
    public string guess;
    public string keepPlaying;

    public int playersPoints = 300;
    public int winningbonus = 100;
    public int losingloss = 75;

    
    
    public Dealer ()
    {
        
    }

    public void startGame()
    {
        int playersPoints = 300;
        string keepPlaying = "y";
        string guess = " ";
        int winningbonus = 100;
        int losingloss = 75;

        Card c = new Card();


        while (keepPlaying == "y")
        {

            
            // d.HighorLow();
            // c.Update();
            Console.WriteLine($"The card is: {c.lastCardValue}");

            Console.Write("Higher or lower? [h/l] " );
            guess = Console.ReadLine();
            Console.WriteLine($"The next card was: {c.cardValue}");
            

            if (guess.Equals("h") && c.lastCardValue < c.cardValue){
                            playersPoints += winningbonus;
            }

            else if(guess.Equals("l") && c.lastCardValue > c.cardValue)
            {
                playersPoints += winningbonus;
            }

            else if(guess.Equals("h") && c.lastCardValue > c.cardValue)
            {
            playersPoints -= losingloss;
                if (playersPoints < 0)
                {
                playersPoints = 0;
                }
            }
            else if(guess.Equals("l") && c.lastCardValue < c.cardValue)
            {
                playersPoints -= losingloss;
                if (playersPoints < 0)
                {
                    playersPoints = 0;
                }
            }
            
            c.Update();
        
            // d.PlayAgain();
            Console.WriteLine("Your score is: " + playersPoints);
            Console.Write("Play again? [y/n] ");
            keepPlaying = Console.ReadLine();
            Console.WriteLine("\n");
            
            if (playersPoints == 0)
            {
                Console.WriteLine("Game over! ");
                break;
            
            }
            else if (keepPlaying == "n")
            {
                Console.WriteLine("Thanks for playing! ");
                break;
                
            }
            
        


        }


    
  

        
    }




}
 
