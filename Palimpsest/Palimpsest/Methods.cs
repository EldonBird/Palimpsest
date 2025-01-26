using System.Runtime.InteropServices.JavaScript;

namespace Palimpsest;

using System;
using System.Collections.Generic;
using System.IO;

public class Methods {

    static char[] charTable = new char[] { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
        'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
        'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '&', ',', '.', '?', '!', ';',
        ':', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};


    // just a linear search to get the number for the character so it can be proccessed
    public static int GetCharacterIndex(char input) {

        for (int i = 0; i < charTable.Length; i++) {
            if (input == charTable[i]) {
                return i;
            }
        }
        return -1;

    }


    public static String OffsetDecrypt(String input, int offset) {

        String output = "";

        for (int i = 0; i < input.Length; i++) {

            int index = GetCharacterIndex(input[i]);


            if (index < 0) { // basically it is not on the char list
                output += "*";
            }
            else {
                output += charTable[(index - offset) % charTable.Length];
            }


        }

        return output;
    }


    public static String OffsetEncrypt(String input, int offset) {

        String output = "";

        for (int i = 0; i < input.Length; i++) {


            int index = GetCharacterIndex(input[i]);


            if (index < 0) { // basically it is not on the char list
                output += "*";
            }
            else {
                output += charTable[(index + offset) % charTable.Length];
            }

        }

        return output;
    }

    public static String RotationEncrypt(String input, int offset) {
        return OffsetEncrypt(input, offset + 90);
    }

    public static String RotationDecrypt(String input, int offset) {
        return OffsetDecrypt(input, offset + 90);
    }


    public static String Decrypt(String dir, String key) {

        String output = "";

        String ReadText = File.ReadAllText(dir);


        return OffsetDecrypt(ReadText, int.Parse(key));
    }

    // the over all call so that I only have one public statement for both encryption and decryption
    public static String Encrypt(String dir, String key) {

        String output = "";

        String readText = File.ReadAllText(dir);


        return OffsetEncrypt(readText, int.Parse(key));
    }


    // is the middle step in dividing up the initial file(String) input in a way that is humanly digestible
    private static String[] middlestep(String input, String key) {

        String[] output = new String[input.Length];

        for (int i = 0; i < input.Length; i++) {

            output[(i + 1) % key.Length] += input[i];

        }

        return output;

    }


    // returns the index of the lowest char in the string
    private static int lowest(String key) {

        int lowest = 0;

        for (int i = 1; i < key.Length; i++) {

            if (GetCharacterIndex(key[i]) < GetCharacterIndex(key[lowest])) {
                lowest = i;
            }

        }

        return lowest;
    }


    private static String[] permutation(String input, String key) {

        List<Char> keylist = key.ToCharArray().ToList();

        String[] output = new String[key.Length];

        String[] middle = middlestep(input, key);

        for (int i = 0; i < key.Length; i++) {

            if (keylist.Count < 1) {
                continue;
            }

            int low = lowest(keylist.ToString());

            output[i] = middle[low];
            keylist.RemoveAt(low);

        }
        return output;
    }



}