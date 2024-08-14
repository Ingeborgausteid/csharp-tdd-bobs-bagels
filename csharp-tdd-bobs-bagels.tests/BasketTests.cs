namespace csharp_tdd_bobs_bagels.tests;
using tdd_bobs_bagels.CSharp.Main;

public class BasketTests
{
    [SetUp]
    public void Setup()
    {
    }

    //1. As a member of the public, So I can order a bagel before work, I'd like to add a specific type of bagel to my basket.
    [Test]
    public void AddBagelToBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool canAddBagel = basket.Add(bagel);
       
        Assert.That(expected == canAddBagel);
    }

    [Test]
    public void RemoveBagelFromBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool isRemoved = basket.Remove(bagel);

        Assert.That(expected == isRemoved);
    }

}