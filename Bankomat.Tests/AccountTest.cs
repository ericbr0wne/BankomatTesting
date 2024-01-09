namespace AccountTest;

using banko;

public class withdraw5000
{
    Bankomat _bankomat;
    Account _acc;
    Card _card;

    public withdraw5000()
    {
        _bankomat = new();
        _acc = new();
        _card = new(_acc);
    }

    [Theory]
    [InlineData(5000)]

    public void Withdraw5lax(int balance)
    {

        Assert.True(_card.account.WTF METHOD?!(-balance));

    }
}

