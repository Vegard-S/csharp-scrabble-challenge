using csharp_scrabble_challenge.Main;


Console.WriteLine("Welcome to scrabble, write a word and get a score, {} is double points and [] is triple points");
Console.WriteLine("qqq to quit");

while (true)
{
    Console.WriteLine("write your word");
    string input = Console.ReadLine();
    if (input == "qqq") {  break; }
    Scrabble game = new Scrabble(input);
    int score = game.score();
    Console.WriteLine($"your score is: {score}");
}

