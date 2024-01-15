using System;

class CaesarCipher
{
    static string Encrypt(string plainText, int shift)
    {
        char[] result = plainText.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (Char.IsLetter(result[i]))
            {
                char offset = Char.IsUpper(result[i]) ? 'A' : 'a';
                result[i] = (char)((result[i] + shift - offset) % 26 + offset);
            }
        }

        return new string(result);
    }

    static string Decrypt(string cipherText, int shift)
    {
        return Encrypt(cipherText, 26 - shift);
    }

    static void Main()
    {
        string originalText = "Hello, World!";
        int shift = 3;

        string encryptedText = Encrypt(originalText, shift);
        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Original Text: " + originalText);
        Console.WriteLine("Encrypted Text: " + encryptedText);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }
}
