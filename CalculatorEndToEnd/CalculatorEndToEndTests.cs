using Microsoft.Playwright;
namespace CalculatorEndToEnd;
using CalculatorEngine;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Tests : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        
    }

    [Test]
    public async Task CalculatorUI_PageTitle_IsCalculator()
    {
        //preq-E2E-Test-5
        await Page.GotoAsync("http://localhost:5175/");
        var title = await Page.TitleAsync();
        Assert.AreEqual("Calculator", title);
    }

    [Test]
    public async Task CalculatorUI_AdditionOperation_CorrectSummation()
    {
        //preq-E2E-Test-6
        CalculatorEngine Cal = new CalculatorEngine();
        String Expected = Cal.Addition(56, -85).ToString();
        await Page.GotoAsync("http://localhost:5175/");
        await Page.Locator("#OperandA").ClickAsync();
        await Page.Locator("#OperandA").FillAsync("56");
        await Page.Locator("#OperandB").ClickAsync();
        await Page.Locator("#OperandB").FillAsync("-85");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Expect(Page.Locator("h2")).ToContainTextAsync(Expected);
    }
    
    [Test]
    public async Task Calculator_DivisionOperation_InvalidDivision()
    {
        //preq-E2E-Test-7
        await Page.GotoAsync("http://localhost:5175/");
        await Page.Locator("#OperandA").ClickAsync();
        await Page.Locator("#OperandA").FillAsync("356");
        await Page.Locator("#OperandB").ClickAsync();
        await Page.Locator("#OperandB").FillAsync("0");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A / B" }).ClickAsync();
        await Expect(Page.Locator("h2")).ToContainTextAsync("Not a Number");
    }
    
    [Test]
    public async Task Calculator_AdditionOperation_InvalidInput()
    {
        //preq-E2E-Test-8
        await Page.GotoAsync("http://localhost:5175/");
        await Page.Locator("#OperandA").ClickAsync();
        await Page.Locator("#OperandA").FillAsync("546");
        await Page.Locator("#OperandB").ClickAsync();
        await Page.Locator("#OperandB").FillAsync("fifteen");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Expect(Page.Locator("h2")).ToContainTextAsync("Invalid Input, Numbers Only");
    }
    
    [Test]
    public async Task Calculator_AdditionOperation_ClearPage()
    {
        //preq-E2E-Test-9
        await Page.GotoAsync("http://localhost:5175/");
        await Page.Locator("#OperandA").ClickAsync();
        await Page.Locator("#OperandA").FillAsync("46");
        await Page.Locator("#OperandB").ClickAsync();
        await Page.Locator("#OperandB").FillAsync("-234");
        await Page.GetByRole(AriaRole.Button, new() { Name = "A + B" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Clear" }).ClickAsync();
        await Expect(Page.Locator("h2")).ToContainTextAsync("Enter value(s) below and select an operation");
    }
}