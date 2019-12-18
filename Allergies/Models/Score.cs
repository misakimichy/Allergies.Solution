using System;
using System.Collections;
using System.Collections.Generic;
namespace Allergies.Models
{
    public class Score
    {
        public int ScoreInput {get; set; }
        static Dictionary<int, string> _scoreDict = new Dictionary<int, string>(){{128, "cats"}, {64, "pollen"}, {32, "chocolate"}, {16, "tomatoes"}, {8, "strawberries"}, {4, "shellfish"}, {2, "peanuts"}, {1, "eggs"}};
        public Score(int score)
        {
            ScoreInput = score;
        }
        public List<string> CheckAllergies()
        {
            List<string> result = new List<string>{};
            int ScoreInputCopy = ScoreInput;
            foreach (KeyValuePair<int,string> pair in _scoreDict)
            {
                if (ScoreInputCopy / pair.Key > 0)
                {
                    result.Add(pair.Value);
                    ScoreInputCopy -= pair.Key;
                }
            }
            return result;
        }
    }
}