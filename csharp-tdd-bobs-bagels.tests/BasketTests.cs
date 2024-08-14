namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddBagelToBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool canAddBagel = basket.Add(bagel);
       
        Assert.That(expected == canAddBagel);
    }

}