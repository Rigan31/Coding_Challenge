using System.Text;

public class Processor
{
    private StringBuilder Message;
    private OldPhone Phone;
    private char lastKey = '\0';
    private int count = 0;

    public Processor()
    {
        Phone = new OldPhone();
        Message = new StringBuilder();
        InitializePhone();
    }

    private void InitializePhone()
    {
        Phone.InsertButton('1', "&'(");
        Phone.InsertButton('2', "ABC");
        Phone.InsertButton('3', "DEF");
        Phone.InsertButton('4', "GHI");
        Phone.InsertButton('5', "JKL");
        Phone.InsertButton('6', "MNO");
        Phone.InsertButton('7', "PQRS");
        Phone.InsertButton('8', "TUV");
        Phone.InsertButton('9', "WXYZ");
        Phone.InsertButton('0', " ");
    }

    private void RemoveLastCharacter()
    {
        if (Message.Length > 0)
        {
            Message.Length--;
        }
    }

    private void AppendLastCharacter(char digit, int count)
    {
        if (count > 0 && Char.IsDigit(digit))
        {
            char letter = Phone.GetLetter(digit, count);
            if (letter != '\0'){
                Message.Append(letter);
            }
        }
    }

    public String ProcessInput(String input)
    {
        if (input.Length == 0) return String.Empty;

        foreach (char key in input)
        {
            if (key == '#')
            {
                AppendLastCharacter(lastKey, count);
                break;
            }
            else if (key == '*')
            {
                AppendLastCharacter(lastKey, count);
                RemoveLastCharacter();
                lastKey = '\0';
                count = 1;
            }
            else if (key == ' ')
            {
                AppendLastCharacter(lastKey, count);
                lastKey = '\0';
                count = 1;
            }
            else if (lastKey == key)
            {
                count++;
            }
            else
            {
                AppendLastCharacter(lastKey, count);
                lastKey = key;
                count = 1;
            }
        }
        return Message.ToString();
    }
}