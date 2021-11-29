using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Allergies
{
    enum Allergen
    {
        Eggs = 1, 
        Peanut = 2,
        Shellfish = 4, 
        Strawberries = 8,
        Tomatoes = 16, 
        Chocolate = 32, 
        Pollen = 64, 
        Cats = 128
    }
    
    public class Allergies
    {
        private string _name;
        public string Name
        {
            get => _name;
        }
        private int _score;
        public int Score
        {
            get => _score;
        }
        
        private List<string> _allergies;
        
        public Allergies(string name)
        {
            _name = name;
            _allergies = new List<string>();
            _score = 0;
        }
        
        public Allergies(string name, int score)
        {
            _name = name;
            _allergies = ListOfAllergiesByScore(score);
            _score = score;
        }
        
        public Allergies(string name, string allergiesInString)
        {
            _name = name;
            _allergies = ListOfAllergiesByString(allergiesInString);
            _score = CountScore();
        }

        public string ToString()
        {
            if (_allergies.Count == 0)
            {
                return $"{_name} has no allergies";
            }
            
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_name} is allergic to ");

            for (int i = 0; i < _allergies.Count; i++)
            {
                sb.Append(_allergies[i]);
                if (i + 2 < _allergies.Count)
                {
                    sb.Append(", ");
                }
                if (i + 2 ==_allergies.Count)
                {
                    sb.Append(" and ");
                }

                if (i + 1 == _allergies.Count)
                {
                    sb.Append(".");
                }
            }

            return sb.ToString();
        }

        public bool IsAllergicTo(string allergen)
        {
            foreach (var allegry in _allergies)
            {
                if (allegry == allergen)
                {
                    return true;
                }
            }

            return false;
        }

        public void AddAllergy(string allergen)
        {
            try
            {
                if (IsAllergicTo(allergen))
                {
                    return;
                }
                _allergies.Add(allergen);
                _allergies = _allergies.OrderBy(x => GetScoreOfAllergen(x)).ToList();
                _score += GetScoreOfAllergen(allergen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void DeleteAllergy(string allergen)
        {
            try
            {
                var index = _allergies.FindIndex(i => i == allergen); 
                if (index >= 0) {
                    _allergies.RemoveAt(index);
                    _score -= GetScoreOfAllergen(allergen);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private int CountScore()
        {
            try
            {
                int score = 0;
                foreach (var allergen in _allergies)
                {
                    score += GetScoreOfAllergen(allergen);
                }

                return score;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private List<string> ListOfAllergiesByString(string allergiesAsString)
        {
            try
            {
                var allegries = new List<string>();
                string[] subs = allergiesAsString.Split(' ');
                foreach (var sub in subs)
                {
                    allegries.Add(sub);
                }
                allegries = allegries.OrderBy(x => GetScoreOfAllergen(x)).ToList();
                return allegries;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private List<string> ListOfAllergiesByScore(int score)
        {
            try
            {
                var allegries = new List<string>();
                int i = 0;
                while(score > 0)
                {
                    var digit = score & 1;
                    if (digit == 1)
                    {
                        string name = GetNameOfAllergen((int) Math.Pow(2, i));
                        allegries.Add(name);
                    }
                    score = score >> 1;
                    i++;
                }

                return allegries;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private string GetNameOfAllergen(int allergen)
        {
            foreach(Allergen value in Enum.GetValues(typeof(Allergen)))
            {
                if ((int)value == allergen)
                {
                    return value.ToString();
                }
            }

            throw new Exception("Error in GetNameOfAllergen: no allergen with score = " +  allergen);
        }

        private int GetScoreOfAllergen(string allergen)
        {
            foreach(Allergen value in Enum.GetValues(typeof(Allergen)))
            {
                string name = Enum.GetName(typeof(Allergen), value);
                if (name == allergen)
                {
                    return (int)value;
                }
            }

            throw new Exception("Error in GetScoreOfAllergen(): allergen " +  allergen + " do not exists");
        }
    }
}