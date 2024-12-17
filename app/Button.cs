/*
    Represents a single button on a phone's keypad that maps a digit to a string of alphabets (size upto 1 to 4). This class allows to get a letter based on the number of times the button is pressed.
*/
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
