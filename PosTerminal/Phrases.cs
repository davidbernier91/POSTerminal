using System;

namespace PosTerminal {
    public class Phrases {
        public static string Welcome = $"Welcome to the Grand Circus Store{NewLine}";
        public static string Continue = $"Would you like to continue? (y/n){NewLine}";
        public static string Receipt = $"Would you like to see your receipt? (y/n){NewLine}";
        public static string ChooseFood = $"Choose a food item by its index: {NewLine}";
        public static string NotANumber = $"Error: Input is not a number{NewLine}";
        public static string NotAnIndex = $"Error: Not a valid index{NewLine}";
        public static string YesOrNoError = $"Error: Select 'y' or 'n'{NewLine}";
        public static string TerminateProgram = $"Program Terminated{NewLine}";
        public static string AskQuantity = $"Please enter quantity? {NewLine}";
        public static string NewLine = $"{Environment.NewLine}";

        }
    }
