int n = Convert.ToInt32(Console.ReadLine()!.Trim());
string password = Console.ReadLine()!;

int answer = minimumNumber(n, password);

Console.WriteLine(answer);



static int minimumNumber(int n, string password)
{
    string numbers = "0123456789";
    string lowerCase = "abcdefghijklmnopqrstuvwxyz";
    string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string specialChars = "!@#$%^&*()-+";

    int missingTypes = 0;

    if (!password.Any(c => numbers.Contains(c))) missingTypes++;
    if (!password.Any(c => lowerCase.Contains(c))) missingTypes++;
    if (!password.Any(c => upperCase.Contains(c))) missingTypes++;
    if (!password.Any(c => specialChars.Contains(c))) missingTypes++;

    return Math.Max(missingTypes, 6 - n);
}