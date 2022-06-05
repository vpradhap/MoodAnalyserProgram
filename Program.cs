using MoodAnalyserProgram;

Console.WriteLine("\n\t\tMood Analyser program");
string message = null;
MoodAnalyser moodAnalyser = new MoodAnalyser(message);
Console.WriteLine(moodAnalyser.AnalyseMood());