using HangmanMax;

HangmanMaxtool ht = new HangmanMaxtool();

string rozwiazanie = "";
string guessWord = "";
string whatsLettersGuessed = "";
int wrongGuesses = 0;

bool gameIsOver = false;

Console.WriteLine("Hello, play with me! Why? Becouse it's funny");

Console.WriteLine("Do a world ");
Thread.Sleep(400);
Console.Write(".");
Thread.Sleep(400);
Console.Write(".");
Thread.Sleep(400);
Console.Write(".");
Thread.Sleep(400);
Console.Write(".");

rozwiazanie = ht.TakeSomeWord();

Console.WriteLine();
Console.WriteLine("Ok, You want that word l think");

do
{
    Console.WriteLine("Give me a letter please");

    do
    {
        guessWord = Console.ReadLine();

    } while (!ht.ValidGuess(guessWord, whatsLettersGuessed));

    whatsLettersGuessed += guessWord;

    if (rozwiazanie.Contains(guessWord))
    {
        Console.WriteLine($"ok, letter {guessWord} is right letter");

        if (ht.UpdateWord(whatsLettersGuessed, rozwiazanie) == rozwiazanie)
        {
            Console.WriteLine("Omg u won, I will win next time");
            gameIsOver = true;
        }
        Console.WriteLine("Word: " + ht.UpdateWord(whatsLettersGuessed, rozwiazanie));
    }
    else // if he is wrong
    {
        Console.WriteLine($"Ohh no, the word dosen't have the letter {guessWord}.");
        wrongGuesses++;

        if (wrongGuesses < 10)
        {
            Console.WriteLine($"You have {10 - wrongGuesses} how many try left");
        }
        if (wrongGuesses >=10)
        {
            Console.WriteLine("Ohh no, you lost, try again ahahhaha");
            Console.WriteLine("the word is: " + rozwiazanie);
            gameIsOver = true;
        }
        
    }
    


} while (!gameIsOver);

Console.WriteLine("Thanks for time! If u like play again");


  