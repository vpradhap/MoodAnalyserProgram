using MoodAnalyserProgram;

Console.WriteLine("\n\t\tMood Analyser program");
Console.Write("\nHow are you feeling today : ");
string message = Console.ReadLine();
MoodAnalyser moodAnalyser = new MoodAnalyser(message);
Console.WriteLine(moodAnalyser.AnalyseMood());