Source source = new Source("None Were with Him","http://www.churchofjesuschrist.org");
Console.WriteLine(source.Stringify());


Quote holland = new Quote("Elder Holland", "Because Jesus walked such a long, lonely path utterly alone we do not have to do so.",source);

Console.WriteLine(holland.GetQuote());

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love, and of a sournd mind.",
        new Source("2 Timothy 1:7")
    )
);

//Two different whys to write quotes in the code
_board.AddQuote(
    new Quote(
        "Sister Elain S. Dalton",
        "Work hard to achieve your dreams. Don't let discouragement or mistakes delay you.",
        new Source(
            "How to Dare Great Things",
            "https://www.churchofjesuschrist.org/study/new_era/2012/03/how-to-dare-great=things?lang=eng"
        )
    )
);

//Second way to write the quotes in

_board.AddQuote(new Quote("Alma","Counsel with the Lord in all they doings, and he will direct thee for good.", new Source("Alma 37:37")));

Board quoteboard = new Board();
quoteboard.AddQuote(holland);
quoteborad.FindQuotesByAuthor("holland");

Menu _menu = new menu(_board);
_menue.Display();
