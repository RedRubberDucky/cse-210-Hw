using System;


public class Scriptures
{
        
        string[] words;
        string _text;
        private Reference _reference;
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
        public List<string> get_text()
        {
                return get_text; 
        }
        
        // public void display()
        // {
        //         int i = 0;
        //         for(i; i<10; i ++)
        //         {
                        
        //         }
        // }




        
        // List<string>wordList = new List<string>
        // {
        //   "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit,", 
        //   "and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love,",
        //   "willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",      
        
        // };
        
        

       

    
   
}

    
    // _scripture.AddScriptures
    // (
    //     new Scriptures
    //     (
    //         "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit,", 
    //         "and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love,",
    //         "willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",
    //         new Reference("Mosiah 3:19")
    //     )
    // );
