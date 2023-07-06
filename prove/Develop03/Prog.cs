using System;


// Scriptures Mosiah = new Scriptures("Mosiah 3:19");
// Reference  Book = new Reference ("Book of Mormon", 3, 7); //Book, Chapter, Verse
Reference Mosiah = new Reference("Mosiah", 3, 19);
Mosiah.ScriptRef("Mosiah");
                                    //Displays the scripture reference

Scriptures Gospel = new Scriptures("For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.", Mosiah);

Reference Proverbs = new Reference("Proverbs", 3, 5, 6);
Proverbs.ScriptRef("Proverbs");

Scriptures Scripture2 = new Scriptures($"Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.", Proverbs);



while (Gospel.CountShownWords()!= 0)
{
    Console.WriteLine("Press Enter to begin removing words.");
    Gospel.RemoveRandomWord();
    Console.WriteLine(Mosiah.display());
    Gospel.displaytext();
    Console.ReadLine();
    Console.Clear();
}

while (Scripture2.CountShownWords()!= 0)
{
    Console.WriteLine("Press Enter to begin removing words.");
    Scripture2.RemoveRandomWord();
    Console.WriteLine(Proverbs.display());
    Scripture2.displaytext();
    Console.ReadLine();
    Console.Clear();
}

