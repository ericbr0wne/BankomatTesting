namespace Bankomat.Tests;

using banko;


public class IsCardInserted
{

    Bankomat _bankomat;
    Account _acc;
    Card _card;

    public IsCardInserted()
    {
        _bankomat = new();
        _acc = new();
        _card = new(_acc);
    }

    [Fact]
    public void IsCardInserted_ReturnFalse()
    {
        Assert.False(_bankomat.cardInserted);
    }

    [Fact]
    public void IsCardInserted_ReturnTrue()
    {
   
       _bankomat.insertCard(_card);
        Assert.True(_bankomat.cardInserted);
    }
}

