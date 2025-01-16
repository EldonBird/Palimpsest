namespace Palimpsest;

using System;
using System.Collections.Generic;
using System.IO;

public class Methods {

    static char[] charTable = new char[] { ' ', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '&', ',', '.', '?', '!', ';', ':', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};


    // just a linear search to get the number for the character so it can be proccessed
    public static int GetCharacterIndex(char input) {

        for (int i = 0; i < charTable.Length; i++) {
            if (input == charTable[i]) {
                return i;
            }
        }
        return -1;

    }



    public static String OffsetEncrypt(String input, int offset) {

        String output = "";

        for (int i = 0; i < input.Length; i++) {

            int index = GetCharacterIndex(input[i]);

            if (index < 0) { // basically it is not on the char list
                output.Append('^');
            }
            else {
                output.Append(charTable[(index + offset) % charTable.Length]);
            }
        }




        return output;
    }


    public void BeginEncryption(String startDir, String endDir, int offset) {

        String readText = File.ReadAllText(startDir);

        File.WriteAllText(endDir, OffsetEncrypt(readText, offset));

    }












}