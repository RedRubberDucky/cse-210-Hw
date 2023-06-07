using System;


public class Scriptures
{
        
        string[] words;

        private List<string> _text = new List<string>(new string[]{
                "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."
        });
        public Scriptures(List<string> text)
        {
                _text = text;
                 string[] subs = text.Split(' ');
                
        }
        public List<string> get_text()
        {
                return _text; 
        }
        
        public void display()
        {
                int i = 0;
                for(i; i<10; i ++)
                {
                        
                }
        }




        
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
