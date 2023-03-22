    public static class HighScoreMenu{
        private static string _header="High Scores: ";
        private static string _footer="Press Enter to Continue";

        public static void DisplayHighScores(HighScores highScores){
            var orderedHighScores = highScores.GetOrderedHighScores();
            Console.WriteLine($"{_header}");
            foreach (var score in orderedHighScores)
            {
                Console.WriteLine($"{score}");
            }
            Console.WriteLine($"{_footer}");
            Console.ReadLine();
            }
    }
    


