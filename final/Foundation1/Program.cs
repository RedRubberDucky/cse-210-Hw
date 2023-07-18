       
       
       
        Videos video1 = new Videos("Remember Lots Wife", "Jeffery R. Holland", 34);
        video1.addcomment("Josh", "This was a great message!");
        video1.addcomment("Matt", "I learned a lot.");
        video1.addcomment("Marvin", "We are a lot like Lots wife.");
        
        Videos video2 = new Videos ($"As Many as I Love, I Rebuke and Chasten", "D. Todd Christofferson", 15);
        video2.addcomment("Mark", "We all need to be chastened in our lives.");
        video2.addcomment("James", "Hugh Brown's story is so inspirating.");
        video2.addcomment("Tom", "I have often felt like the berry bush in all stages it was in.");

        Videos video3 = new Videos ($"Peacemakers Needed", "Russel M. Nelson", 20);
        video3.addcomment("James", "Being a peacemaker isn't always that easy.");
        video3.addcomment("Mary", "I have found that patients plays a big role in becomming a peacemaker");
        video3.addcomment("Alex", "The Prophet always has such great wisdom for us.");

        List<Videos> _videolist = new List<Videos>
        {
            video1, 
            video2, 
            video3,
            
           
        };

        foreach (Videos video in _videolist) 
        {
            video.displayvideo();
        }
        
        

    
