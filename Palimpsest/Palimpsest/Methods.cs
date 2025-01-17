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
        return OffsetEncrypt(input, offset);
    }

    public static String RotationDecrypt(String input, int offset) {
        return OffsetDecrypt(input, offset);
    }


    public static String BeginEncryption(String startDir, int offset, bool rotation) {

        String readText = File.ReadAllText(startDir);

        if (rotation) {
            return RotationEncrypt(readText, offset);
        }

        return OffsetEncrypt(readText, offset);



    }

    public static String BeginDecryption(String startDir, int offset, bool rotation) {

        String readText = File.ReadAllText(startDir);

        if (rotation) {
            return RotationDecrypt(readText, offset);
        }

        return OffsetDecrypt(readText, offset);

    }

    private static String Decrypt(String dir, String key) {

        String output = "";

        String ReadText = File.ReadAllText(dir);




        return output;
    }

    private static String Encrypt(String dir, String key) {

        String output = "";

        String readText = File.ReadAllText(dir);

        foreach (String s in middlestep(readText, key)) {
            output += s;
        }


        return output;
    }


    private static String[] middlestep(String input, String key) {
        String[] output;

        output = new String[key.Length];

        int tick = 0;

        for (int i = 0; i < input.Length; i++) {


            output[tick] += input[i];


            tick = (tick + 1) % key.Length;
        }




        return output;
    }









}