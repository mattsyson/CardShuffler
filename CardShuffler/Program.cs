using CardShuffler;

internal class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new();

        List<Card> unshuffled = deck.GetDeck();

        var shuffled = Deck.Shuffle(unshuffled);
        Console.WriteLine("Count: " + shuffled.Count);

        foreach( var card in shuffled)
        {
            Console.WriteLine(card.Value + card.Suit);
           
        }
    }

    
}