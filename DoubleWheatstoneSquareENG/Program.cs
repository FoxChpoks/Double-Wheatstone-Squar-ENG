﻿using System;
using DoubleWheatstoneSquareENG.Logic;

namespace DoubleWheatstoneSquareENG {
    class Program {
        static void Main(string[] args) {
            DoubleWheatstoneSquare doubleWheatstoneSquare = new DoubleWheatstoneSquare();
            doubleWheatstoneSquare.setDencryptedString("Game-S");
            doubleWheatstoneSquare.encrypt();
            Console.WriteLine(doubleWheatstoneSquare.getDencryptedString());
            Console.WriteLine(doubleWheatstoneSquare.getEncryptedString());
            // doubleWheatstoneSquare.printEncryptedTables();
            // doubleWheatstoneSquare.dencrypt();

        }
    }
}