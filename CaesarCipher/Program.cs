using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //get string input from the user
            Console.WriteLine("Enter a text to encrypt: ");
            string plainText = Console.ReadLine();

            //get number to encrypt by
            Console.WriteLine("Enter an encryption number: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Encrypt(plainText, key));
        }


        static string Encrypt(string plainText, int key)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //convert the message to an array of chars
            char[] splitText = plainText.ToCharArray();

            //create an array the same length as the message
            char[] encryptedText = new char[splitText.Length];

            //loop though the plain text
            for (int i = 0; i < splitText.Length; i++)
            {
                //find the position of each letter in the alphabet
                char letter = splitText[i];
                int position = Array.IndexOf(alphabet, letter);
                //rotate each letter by key amount, looping around after position 26
                position = (position + key) % 26;
                //assign new letter
                letter = alphabet[position];
                encryptedText[i] = letter;
            }

            //Join the array together as a string
            string finalMessage = String.Join("", encryptedText);
            return finalMessage;

        }

    }
}
