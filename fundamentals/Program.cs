﻿using Microsoft.VisualBasic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using YakhaLibrary.DesignPatterns.FactoryMethod;
using YakhaLibrary.Exercism;
using YakhaLibrary.Exercism.Cipher;
using YakhaLibrary.Exercism.Graphs;
using YakhaLibrary.Exercism.Loops.Recursion;
using YakhaLibrary.Exercism.Types.Equalities;
using YakhaLibrary.Exercism.Types.Integrals;
using YakhaLibrary.Exercism.Types.Strings;
using YakhaLibrary.Modules;
using static YakhaLibrary.Exercism.Types.Equalities.Faceid2;

namespace Fundamentals
{

    class MyFirstProgram
    {
        public static void Main(string[] args)
        {
            // Inheritance.Inherit();

            // Enums.Enumerate();

            // CollatzConjecture.Steps(16);
            // CollatzConjecture.StepsR(16);

            // int[] input = [1, 2, 5, 7, 10, 12, 13, 561];
            // int resR = BinarySearch.FindR(input, 0, 0, input.Length - 1);
            // int res = BinarySearch.Find(input, 0);

            // SimpleLinkedList<int> list = new([1, 3, -5, 8]);
            // list.Reverse();
            // foreach (var i in list) Console.WriteLine(i);

            //Identifier.Clean("à-ḃç");

            //Faceid2 fi2 = new Faceid2();
            //Authenticator auth = new();

            // BinarySearchTree bst = new([ 5, 4 ]);

            // EventsDelegates.Click += EventHandlerClass.ButtonClickHandler;
            // EventsDelegates.SimulateClick();

            // RegEx.RegExMatching();

            // RotationalCipher.Rotate("abcdefghijklmnopqrstuvwxyz", 2);

            Logistics logistics = new SeaAirLandLogistics();
            Transport clientTransport = logistics.ManageTransportForCustomer();

            Console.ReadKey();
        }   
    }
}