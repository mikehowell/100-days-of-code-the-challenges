using System.Collections.Generic;
using System;
using System.Text;


namespace RailFenceCipher
{
    public class RFCipher
    {
        public string Encode(string message, int numberOfRails)
        {
            List<string> rail = new List<string>();
            for (int i = 0; i < numberOfRails; i++)
            {
                rail.Add("");
            }

            int number = 0;
            int increment = 1;
            foreach (char character in message)
            {
                if (number + increment == numberOfRails)
                {
                    increment = -1;
                }
                else if (number + increment == -1)
                {
                    increment = 1;
                }
                rail[number] += character;
                number += increment;
            }

            string encodedMessage = "";
            foreach (string encodedString in rail)
            {
                encodedMessage += encodedString;
            }
            return encodedMessage;
        }

        public string Decode (string message, int numberOfRails)
        {
            int messageLength = message.Length;
            List<List<int>> decodedString = new List<List<int>>();
            for (int i = 0; i < numberOfRails; i++)
            {
                decodedString.Add(new List<int>());
            }

            int number = 0;
            int increment = 1;
            for (int i = 0; i < messageLength; i++)
            {
                if (number + increment == numberOfRails)
                {
                    increment = -1;
                }
                else if (number + increment == -1)
                {
                    increment = 1;
                }
                decodedString[number].Add(i);
                number += increment;
            }

            int counter = 0;
            char[] decodedCharacters = new char[messageLength];
            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < decodedString[i].Count; j++)
                {
                    decodedCharacters[decodedString[i][j]] = message[counter];
                    counter++;
                }
            }

            return new string(decodedCharacters);
        }
    }
}
