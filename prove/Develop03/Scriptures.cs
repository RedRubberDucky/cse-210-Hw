//using System;


public class Scriptures
{

        
        public string _text;
        int _variable;
        private Reference _reference;

        private List<string> _scriptures = new List<string>();
        private List<Words> _eachword = new List<Words>();
        

       
        //"For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.
        public Scriptures(string text, Reference book)
        {       
                _reference = book;
                _text = text;
                string[] subs = text.Split(" ");
                foreach (string word in subs)
                {
                        Words w = new Words(word);
                        _eachword.Add(w);
                }
                
        }

        public void displaytext()
        {
                foreach (var eachword in _eachword)
                {
                  Console.Write($"{eachword.get_text()} ");       
                }
        }

        public void RemoveRandomWord()
        {

                for (int i = 0; i < 3; i++)
                {
                Random random = new Random();

                _variable = random.Next(0, _eachword.Count);
                _eachword[_variable].hide();
                
                _eachword[_variable].get_text();
                        
                }
        }

        public int CountShownWords()
        {
                int wordcount = 0;

                for (int i = 0;  i < _eachword.Count; i++)
                {    
                        if (!_eachword[i].GetHidden())
                        {
                                wordcount += 1;
                        }           
                } 
                return wordcount;     
        }
}
        
        
