public class Button
{
    public char Digit { get; private set; }
    public string Alphabet { get; private set; }
    private int Size;

    public Button(char digit, string alphabet)
    {
        Digit = digit;
        Alphabet = alphabet;
        Size = Alphabet.Length;
    }

    public char GetLetter(int count)
    {
        return Alphabet[(count - 1) % Size];
    }
}
