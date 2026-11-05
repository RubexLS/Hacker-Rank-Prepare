using System.Text;

int n = Convert.ToInt32(Console.ReadLine()!.Trim());
string s = Console.ReadLine()!;
int k = Convert.ToInt32(Console.ReadLine()!.Trim());
string result = caesarCipher(s, k);

Console.WriteLine(result);



static string caesarCipher(string s, int k){
    k %= 26; 
    StringBuilder encryptedString = new StringBuilder();

    foreach (char c in s)
    {
        if (char.IsLower(c))
        {
            char cipherChar = (char)(((c - 'a' + k) % 26) + 'a');
            encryptedString.Append(cipherChar);
        }
        else if (char.IsUpper(c))
        {
            char cipherChar = (char)(((c - 'A' + k) % 26) + 'A');
            encryptedString.Append(cipherChar);
        }
        else
        {
            encryptedString.Append(c);
        }
    }

    return encryptedString.ToString();
}