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

    //2. As a member of the public, So I can change my order, I'd like to remove a bagel from my basket.
    [Test]
    public void RemoveBagelFromBasketTest()
    {
        string bagel = "Classic";
        bool expected = true;
        Basket basket = new Basket();

        bool isRemoved = basket.Remove(bagel);

        Assert.That(expected == isRemoved);
    }

    //3. As a member of the public, So that I can not overfill my small bagel basket, I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
    [Test]
    public void BasketIsFullTest()
    {
        string bagel = "Classic";
        bool expected = false;
        Basket basket = new Basket();

        bool canAddBagel = basket.Add(bagel);

        Assert.That(expected == canAddBagel);
    }

}