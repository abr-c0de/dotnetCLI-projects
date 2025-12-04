string ccNum;

do
{
    Console.WriteLine("Enter the credit card id: ");
    ccNum = Console.ReadLine();
} while (string.IsNullOrEmpty(ccNum));

string maskedNum = string.Empty;

for (int i = 0; i < ccNum.Length; i++)
{
    if (ccNum[i] == '-' || char.IsWhiteSpace(ccNum[i]) || i >= ccNum.Length - 4)
        maskedNum += ccNum[i];
    else
        maskedNum += 'X';
}

//output the masked cc number
Console.WriteLine($"Your credit card number is {maskedNum}");