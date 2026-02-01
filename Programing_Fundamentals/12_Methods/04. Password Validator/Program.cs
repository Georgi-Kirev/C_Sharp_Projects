// Input

string password = Console.ReadLine();

// Output
if (PasswordContains6To10Symbols(password) == true && PasswordContainOnlyLettersAndDigits(password) == true && PasswordHave2Digits(password) == true)
{
    Console.WriteLine("Password is valid");
}
if (PasswordContains6To10Symbols(password) == false)
{
    Console.WriteLine("Password must be between 6 and 10 characters");
}
if (PasswordContainOnlyLettersAndDigits(password) == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
}
if (PasswordHave2Digits(password) == false)
{
    Console.WriteLine("Password must have at least 2 digits");
}

// Methods

static bool PasswordContains6To10Symbols(string passwordText)
{
    if (passwordText.Length > 5 && passwordText.Length < 11)
    {
        return true;
    }
    return false;
}

static bool PasswordContainOnlyLettersAndDigits(string passwordText)
{
    for (int i = 0; i < passwordText.Length; i++)
    {
        if (!char.IsLetterOrDigit(passwordText[i]))
        {
            return false;
        }
    }
    return true;
}

static bool PasswordHave2Digits(string passwordText)
{
    int isDigit = 0;
    for (int i = 0; i < passwordText.Length; i++)
    {
        if (char.IsDigit(passwordText[i]))
        {
            isDigit++;
        }
    }

    if (isDigit >= 2)
    {
        return true;
    }
    else
    {
        return false;
    }
}