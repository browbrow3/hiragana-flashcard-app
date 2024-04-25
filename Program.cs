using System.Numerics;

namespace HiraganaFlashcards
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Character> hiraganaAplhabet = new List<Character>()
        {
            new Character() {
                Id = 0,
                Char = '\u3041',
                Sound = "a",
            },
            new Character() {
                Id = 1,
                Char = '\u3043',
                Sound = "i",
            },
            new Character() {
                Id = 2,
                Char = '\u3045',
                Sound = "u",
            },
            new Character() {
                Id = 3,
                Char = '\u3047',
                Sound = "e",
            },
            new Character() {
                Id = 4,
                Char = '\u3049',
                Sound = "o",
            },
            new Character() {
                Id = 5,
                Char = '\u304B',
                Sound = "ka",
            },
            new Character() {
                Id = 6,
                Char = '\u304D',
                Sound = "ki",
            },
            new Character() {
                Id = 7,
                Char = '\u304F',
                Sound = "ku",
            },
            new Character() {
                Id = 8,
                Char = '\u3051',
                Sound = "ke",
            },
            new Character() {
                Id = 9,
                Char = '\u3053',
                Sound = "ko",
            },
            new Character() {
                Id = 10,
                Char = '\u304C',
                Sound = "ga",
            },
            new Character() {
                Id = 11,
                Char = '\u304E',
                Sound = "gi",
            },
            new Character() {
                Id = 12,
                Char = '\u3050',
                Sound = "gu",
            },
            new Character() {
                Id = 13,
                Char = '\u3052',
                Sound = "ge",
            },
            new Character() {
                Id = 14,
                Char = '\u3054',
                Sound = "go",
            },
            new Character() {
                Id = 15,
                Char = '\u3055',
                Sound = "sa",
            },
            new Character() {
                Id = 16,
                Char = '\u3057',
                Sound = "shi",
            },
            new Character() {
                Id = 17,
                Char = '\u3059',
                Sound = "su",
            },
            new Character() {
                Id = 18,
                Char = '\u305B',
                Sound = "se",
            },
            new Character() {
                Id = 19,
                Char = '\u305D',
                Sound = "so",
            },
            new Character() {
                Id = 20,
                Char = '\u3056',
                Sound = "za",
            },
            new Character() {
                Id = 21,
                Char = '\u3058',
                Sound = "zi",
            },
            new Character() {
                Id = 22,
                Char = '\u305A',
                Sound = "zu",
            },
            new Character() {
                Id = 23,
                Char = '\u305C',
                Sound = "ze",
            },
            new Character() {
                Id = 24,
                Char = '\u305E',
                Sound = "zo",
            },
            new Character() {
                Id = 25,
                Char = '\u305F',
                Sound = "ta",
            },
            new Character() {
                Id = 26,
                Char = '\u3061',
                Sound = "chi",
            },
            new Character() {
                Id = 27,
                Char = '\u3063',
                Sound = "tsu",
            },
            new Character() {
                Id = 28,
                Char = '\u3066',
                Sound = "te",
            },
            new Character() {
                Id = 29,
                Char = '\u3068',
                Sound = "to",
            },
            new Character() {
                Id = 30,
                Char = '\u3060',
                Sound = "da",
            },
            new Character() {
                Id = 31,
                Char = '\u3062',
                Sound = "di",
            },
            new Character() {
                Id = 32,
                Char = '\u3065',
                Sound = "du",
            },
            new Character() {
                Id = 33,
                Char = '\u3067',
                Sound = "de",
            },
            new Character() {
                Id = 34,
                Char = '\u3069',
                Sound = "do",
            },
            new Character() {
                Id = 35,
                Char = '\u306A',
                Sound = "na",
            },
            new Character() {
                Id = 36,
                Char = '\u306B',
                Sound = "ni",
            },
            new Character() {
                Id = 37,
                Char = '\u306C',
                Sound = "nu",
            },
            new Character() {
                Id = 39,
                Char = '\u306D',
                Sound = "ne",
            },
            new Character() {
                Id = 40,
                Char = '\u306E',
                Sound = "no",
            },
            new Character() {
                Id = 41,
                Char = '\u306F',
                Sound = "ha",
            },
            new Character() {
                Id = 42,
                Char = '\u3072',
                Sound = "hi",
            },
            new Character() {
                Id = 43,
                Char = '\u3075',
                Sound = "fu",
            },
            new Character() {
                Id = 44,
                Char = '\u3078',
                Sound = "he",
            },
            new Character() {
                Id = 45,
                Char = '\u307B',
                Sound = "ho",
            },
            new Character() {
                Id = 46,
                Char = '\u3070',
                Sound = "ba",
            },
            new Character() {
                Id = 47,
                Char = '\u3073',
                Sound = "bi",
            },
            new Character() {
                Id = 48,
                Char = '\u3076',
                Sound = "bu",
            },
            new Character() {
                Id = 49,
                Char = '\u3079',
                Sound = "be",
            },
            new Character() {
                Id = 50,
                Char = '\u307C',
                Sound = "bo",
            },
            new Character() {
                Id = 51,
                Char = '\u3071',
                Sound = "pa",
            },
            new Character() {
                Id = 52,
                Char = '\u3074',
                Sound = "pi",
            },
            new Character() {
                Id = 53,
                Char = '\u3077',
                Sound = "pu",
            },
            new Character() {
                Id = 54,
                Char = '\u307A',
                Sound = "pe",
            },
            new Character() {
                Id = 55,
                Char = '\u307D',
                Sound = "po",
            },
            new Character() {
                Id = 56,
                Char = '\u307E',
                Sound = "ma",
            },
            new Character() {
                Id = 57,
                Char = '\u307F',
                Sound = "mi",
            },
            new Character() {
                Id = 58,
                Char = '\u3080',
                Sound = "mu",
            },
            new Character() {
                Id = 59,
                Char = '\u3081',
                Sound = "me",
            },
            new Character() {
                Id = 60,
                Char = '\u3082',
                Sound = "mo",
            },
            new Character() {
                Id = 61,
                Char = '\u3083',
                Sound = "ya",
            },
            new Character() {
                Id = 62,
                Char = '\u3085',
                Sound = "yu",
            },
            new Character() {
                Id = 63,
                Char = '\u3087',
                Sound = "yo",
            },
            new Character() {
                Id = 64,
                Char = '\u3089',
                Sound = "ra",
            },
            new Character() {
                Id = 65,
                Char = '\u308A',
                Sound = "ri",
            },
            new Character() {
                Id = 66,
                Char = '\u308B',
                Sound = "ru",
            },
            new Character() {
                Id = 67,
                Char = '\u308C',
                Sound = "re",
            },
            new Character() {
                Id = 68,
                Char = '\u308D',
                Sound = "ro",
            },
            new Character() {
                Id = 69,
                Char = '\u308E',
                Sound = "wa",
            },
            new Character() {
                Id = 70,
                Char = '\u3092',
                Sound = "wo",
            },
            new Character() {
                Id = 71,
                Char = '\u3093',
                Sound = "h",
            },
        };

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int questionsAsked = 0;
            int correctAnswers = 0;
            int incorrectAnswers = 0;

            List<int> mistakes = new List<int>();

            Random randomGenerator = new Random((int)DateTime.UtcNow.Ticks);

            bool exitToken = false;
            while (!exitToken)
            {
                Console.WriteLine("Welcome to Hiragana Flashcard app: ");
                int index = randomGenerator.Next() % 70;
                Console.Write($"Q: {hiraganaAplhabet[index].Char}\n>");
                questionsAsked++;
                string result = Console.ReadLine();
                if (result == "exit") exitToken = true;
                else if (result == hiraganaAplhabet[index].Sound)
                {
                    Console.WriteLine("Great Success!!");
                    correctAnswers++;
                }
                else
                {
                    Console.WriteLine("Sadly incorrect - the correct answer is: " + hiraganaAplhabet[index].Sound);
                    incorrectAnswers++;
                    mistakes.Add(hiraganaAplhabet[index].Id);
                }
                Console.WriteLine("Total Questions: " + questionsAsked);
                Console.WriteLine("Correct Answers: " + correctAnswers);
                Console.WriteLine("Incorrect Answers: " + incorrectAnswers);
                
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Total Questions: " + questionsAsked);
            Console.WriteLine("Correct Answers: " + correctAnswers);
            Console.WriteLine("Incorrect Answers: " + incorrectAnswers);

            Console.WriteLine("\nMistake Breakdown: ");

            IEnumerable<IGrouping<int, int>> groupedmistakes = mistakes.GroupBy(x => x);

            foreach (IGrouping<int,int> mistakegroup in groupedmistakes)
            {
                Character mistake = hiraganaAplhabet.Find(x => x.Id == mistakegroup.Key);
                Console.WriteLine($"{mistake.Char} ({mistake.Sound}):\t{mistakegroup.Count()}");
            }

            Console.ReadKey();
        }
    }
}