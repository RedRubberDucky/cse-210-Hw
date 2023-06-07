


// Scriptures Mosiah = new Scriptures("Mosiah 3:19");
// Reference  Book = new Reference ("Book of Mormon", 3, 7); //Book, Chapter, Verse

Reference Mosiah = new Reference("Mosiah", 3, 19);
Mosiah.ScriptRef("Mosiah");
Console.WriteLine(Mosiah.display());
                                    //Displays the scripture reference

Scriptures Gospel = new Scriptures();
Gospel.get_text();
Console.WriteLine(Gospel.get_text()[0]);

Words New_scripture = new Words(Gospel.get_text()[0]);


// Reference scripture = new Reference("Mosiah",3, 19);
//     Console.WriteLine(scripture.Stringify());

    // Reference Mosiah = new Reference("Mosiah", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit,", 
    //         "and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love,",
    //         "willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.", place);
    // Console.WriteLine(Mosiah.GetScripture());


