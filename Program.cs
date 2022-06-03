using MoodAnalyserProgram;

Console.WriteLine("\n\t\tMood Analyser program");
MoodAnalyser moodAnalyser = new MoodAnalyser();
Console.Write("\nHow are you feeling today : ");
string message =Console.ReadLine();
Console.WriteLine(moodAnalyser.AnalyseMood(message));
