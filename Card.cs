
public class Card
{
    public int cardValue;
    public int lastCardValue;

    Random randomGenerator = new Random();
    public Card()
    {
        //Create variable that store a number between 1 and 13
        cardValue = randomGenerator.Next(1,14);
        lastCardValue = randomGenerator.Next(1,14); 
    }

    public void Update()
    {

        //set cardValue to lastCardValue
        //update card value
        lastCardValue = cardValue;
        cardValue = randomGenerator.Next(1,14);
    }
}

