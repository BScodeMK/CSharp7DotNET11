using Quizz;

Console.WriteLine("Hello");

//Bonus dadete opcija na userot da odbere kategorija

QuizzQestions.SetGeographyQuestions();

foreach (Question question in QuizzQestions.Questions)
{
    Console.WriteLine(question.Text);
	for (int i = 0; i < question.Options.Length; i++)
	{
        Console.WriteLine($"{i + 1}. {question.Options[i]}");
    }
    string userAnswer = Console.ReadLine().Trim();

    if (userAnswer.ToLower() == question.Answer.ToLower()) {
        Console.WriteLine("You guessed right!");
    }
    else {
        Console.WriteLine($"The right answer was {question.Answer}");
    }
    Console.WriteLine();
}

bool newGame = Console.ReadLine().ToLower() == "yes";

if (newGame)
{
    // Treba da napravite nova igra so druga kategorija
    // primer QuizzQestions.SetHistoryQuestions();
    Question[] questions = QuizzQestions.SetMathQuestions();
    foreach (var item in questions)
    {
        
    }
}