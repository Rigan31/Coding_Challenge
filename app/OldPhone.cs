public class OldPhone
{
    private Dictionary<char, Button> KeyPad;

    public OldPhone()
    {
        KeyPad = new Dictionary<char, Button>();
    }

    public void InsertButton(char digit, string alphabet)
    {
        if (KeyPad.ContainsKey(digit))
        {
            return;
        }

        Button newButton = new(digit, alphabet);
        KeyPad[digit] = newButton;
    }

    public void RemoveButton(char digit)
    {
        KeyPad.Remove(digit);
    }

    public char GetLetter(char digit, int count)
    {
        if (KeyPad.ContainsKey(digit))
        {
            return KeyPad[digit].GetLetter(count);
        }

        return '\0';
    }
}