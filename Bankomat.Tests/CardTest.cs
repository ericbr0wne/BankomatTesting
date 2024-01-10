namespace BankomatTests;

using banko;


public class PinCodeFalse

{

    Bankomat _bankomat;
    Account _acc;
    Card _card;

    public PinCodeFalse()
    {
        _bankomat = new();
        _acc = new();
        _card = new(_acc);

    }


    [Theory]
    [InlineData("1234")]
    public void IsPinWrong(string pin)
    {
        Assert.False(_card.pin.Equals(pin), $"pin is incorrect");

    }

    [Theory]
    [InlineData("0123")]
    public void IsPinCorrect(string pin)
    {
        Assert.True(_card.pin.Equals(pin), $"pin is correct");

    }

}