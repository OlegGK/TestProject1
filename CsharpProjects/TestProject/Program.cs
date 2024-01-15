using System;

public class CaesarCipher
{
    private static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    public static string Encrypt(string text, int shift)
    {
        var encryptedText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            var index = alphabet.IndexOf(text[i]);

            if (index != -1)
            {
                var encryptedIndex = (index + shift) % alphabet.Length;
                encryptedText.Append(alphabet[encryptedIndex]);
            }
            else
            {
                encryptedText.Append(text[i]);
            }
        }

        return encryptedText.ToString();
    }

    public static string Decrypt(string text, int shift)
    {
        return Encrypt(text, -shift);
    }

    public static void Main(string[] args)
    {
        var text = "Hello, world!";
        var shift = 3;

        var encryptedText = Encrypt(text, shift);
        var decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Original text:   " + text);
        Console.WriteLine("Encrypted text: " + encryptedText);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}