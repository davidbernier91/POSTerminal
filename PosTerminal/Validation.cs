using System;
using System.Linq;

namespace PosTerminal {
    public class Validation {

        public static int ValidateNumber() {

            string userInput = Console.ReadLine();
            bool validateNumber = Int32.TryParse(userInput, out int value);

            while(!validateNumber) {
                Console.WriteLine(Phrases.NotANumber);
                userInput = Console.ReadLine();
                validateNumber = Int32.TryParse(userInput, out value);
                }
            return value;
            }

        public static bool ValidateWithinRange(int userInput) {
            int upperRange = Store.GetUpperRange();

            if(!Enumerable.Range(1, upperRange).Contains(userInput)) {
                Console.WriteLine(Phrases.NotAnIndex);
                return false;
                }
            else {
                return true;
                }
            }

        public static int ValidateFoodChoice() {
            while(true) {
                int userInput = Validation.ValidateNumber();
                bool isInRange = Validation.ValidateWithinRange(userInput);
                if(!isInRange) {
                    continue;
                    }
                else {
                    return userInput;
                    }
                }
            }

        public static bool AskYesOrNo() {

            string userInput = Console.ReadLine().ToLower();
            while(userInput != "y" && userInput != "n") {
                Console.WriteLine(Phrases.YesOrNoError);
                userInput = Console.ReadLine().ToLower();
                }
            if(userInput == "n") {
                Console.WriteLine(Phrases.TerminateProgram);
                return false;
                }
            else {
                return true;
                }
            }

        }
    }
