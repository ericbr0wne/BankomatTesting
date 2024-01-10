namespace AccountTest;

using banko;
using System.Net.NetworkInformation;
using System.Security.Principal;

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

  /*  [Theory]
    [Fact]
    public void withdraw()
    {
        Account account = new Account();
        int collected = account.withdraw(5000);
        // expected, actual
        Assert.Equal(5000, collected);
    }
   */

    [Theory]
    // actual, expected
    [InlineData(0, 0, 5000)]
    [InlineData(1, 1, 4999)]
    [InlineData(4999, 4999, 1)]
    [InlineData(5000, 5000, 0)]
    [InlineData(5001, 0, 5000)]
    [InlineData(6000, 0, 5000)]
    [InlineData(-5000, 0, 5000)]
    public void withdrawAmounts(int actual, int expected, int remainder)
    {
        Account account = new Account();

        // perform withdrawal
        int collected = account.withdraw(actual);
        // expected, actual
        Assert.Equal(expected, collected);

        // check remaining balance
        int balance = account.getBalance();
        Assert.Equal(remainder, balance);
    }
    }

