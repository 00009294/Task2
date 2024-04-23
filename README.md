
````
// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V121.CSS;

var driver = new ChromeDriver();

driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("https://cloud.google.com/");

// Seacrch
driver.FindElement(By.XPath("/html/body/c-wiz[2]/header/div[2]/div[1]/div/div[2]/div[2]/div[1]/div/div")).Click();
driver.FindElement(By.Id("i4")).SendKeys("Google Cloud Platform Pricing Calculator");
driver.FindElement(By.Id("i4")).Submit();

Thread.Sleep(2000);

// Selects one from search result
driver.FindElement(By.CssSelector("#yDmH0d > c-wiz.SSPGKf > div > div > div > div > div > div:nth-child(3) > c-wiz > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(1) > a")).Click();
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[1]/div/div")).Click();

Thread.Sleep(2000);

//driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/div[2]/div[2]/div/div[1]/div/div/div")).Click();
driver.FindElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/div[2]/div/div/div[1]/div/div/div")).Click();


//driver.Navigate().GoToUr
//l("https://cloud.google.com/products/calculator?dl=CiRmOTQ5NzIwNy01NDAwLTQ5NDgtODZmZC01OWU5NzcwYjQwMjIQCBokRDMwQjg2RDMtNTA4MS00MDlBLTg5MEUtQzhDMTJFNjM5NTYz");

// Fill out instaces with data
Thread.Sleep(4000);

var inputField = driver.FindElement(By.CssSelector("#c11"));
inputField.Click();
Thread.Sleep(1000);
inputField.Clear();
inputField.SendKeys("4");

driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[7]/div/div[1]/div/div/div/div[1]/div")).Click();
Thread.Sleep(1000);
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(7) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-aJasdd-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc")).Click();
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(9) > div > div > div.Iykrdb > div > div > div:nth-child(1) > label")).Click();

// Machine type
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div")).Click();
Thread.Sleep(2000);
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(11) > div > div > div.Iykrdb > div > div.LHK0xb.KXFYXb > div:nth-child(1) > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-hjZysc-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-aSi1db-MCEKJb")).Click();
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/div")).Click();
Thread.Sleep(2000);
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(11) > div > div > div.Iykrdb > div > div.LHK0xb.KXFYXb > div:nth-child(2) > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-hjZysc-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-aSi1db-MCEKJb")).Click();
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div")).Click();
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(11) > div > div > div.Iykrdb > div > div.LHK0xb.KXFYXb > div:nth-child(3) > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(8)")).Click();

// Add GPUs
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(21) > div > div > div.AsBIyb > div > div > span > div > button > div > span.eBlXUe-hywKDc")).Click();
Thread.Sleep(2000);

// Gpu Type
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div")).Click();
Thread.Sleep(2000);
//driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(23) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-uxVfW-FNFY6c-uFfGwd.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(4)")).Click();
//driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(23) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-uxVfW-FNFY6c-uFfGwd.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-aJasdd-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc")).Click();
driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(23) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(4)")).Click();

// Number of GPUs by default
//driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[24]/div/div[1]/div/div/div/div[1]/div")).Click();
//driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(24) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-uxVfW-FNFY6c-uFfGwd.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-aJasdd-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc")).Click();
//driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(24) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-aJasdd-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc")).Click();
//driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(24) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-uxVfW-FNFY6c-uFfGwd.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li.MCs1Pd.HiC7Nc.VfPpkd-OkbHre.VfPpkd-aJasdd-RWgCYc-wQNmvb.VfPpkd-rymPhb-ibnC6b.VfPpkd-rymPhb-ibnC6b-OWXEXe-gk6SMd.VfPpkd-rymPhb-ibnC6b-OWXEXe-SfQLQb-Woal0c-RWgCYc")).Click();


// Local SSD
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div")).Click();
Thread.Sleep(2000);
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(27) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(4)")).Click();

// DataCenter
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div")).Click();
Thread.Sleep(2000);

// In some case there is Frankfurt so as a default I choose Netherlands
//driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(29) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(13)")).Click();
driver.FindElement(By.CssSelector("#ow4 > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(29) > div > div.YgByBe > div > div > div > div.VfPpkd-xl07Ob-XxIAqe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-tsQazb.VfPpkd-xl07Ob.VfPpkd-YPmvEd.IWDrLe.VfPpkd-xl07Ob-XxIAqe-OWXEXe-FNFY6c > ul > li:nth-child(5)")).Click();


// Committed usage
driver.FindElement(By.CssSelector("#ucj-1 > div > div > div > div > div > div > div > div.kyx3Tb.AlLELb > div > div.vHartc > div.U4lDT > div:nth-child(31) > div > div > div.Iykrdb > div > div > div:nth-child(2) > label")).Click();
Thread.Sleep(2000);
var price1 = driver.FindElement(By.ClassName("egBpsb")).Text;

// click button
driver.FindElement(By.XPath("/html/body/c-wiz[1]/div/div/div[1]/div/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button/span[6]")).Click(); 

var driver2 = new ChromeDriver();
driver2.Navigate().GoToUrl("https://cloud.google.com/products/calculator/estimate-preview/e646d137-f3fc-40e0-a71d-d6baa4afb3f2");
var price2 = driver2.FindElement(By.ClassName("OtcLZb")).Text;


Console.WriteLine(price1);
Console.WriteLine(price2);

Console.WriteLine(price2+"/ month" == price1);


// $5,628.90 == $5,628.90/ month







// Email Generating
//var driver2 = new ChromeDriver();

//driver2.Manage().Window.Maximize();
//driver2.Navigate().GoToUrl("https://yopmail.com/");

//driver2.FindElement(By.CssSelector("body > div > div.ymaincenter > header > nav > div.flexcx > a:nth-child(4)")).Click();

//Thread.Sleep(5000);
//// Here manually remove adds


//var emailUsername = driver2.FindElement(By.ClassName("genytxt")).Text;
//var emailDomain = "@yopmail.com";

//Console.WriteLine(emailUsername + emailDomain);


