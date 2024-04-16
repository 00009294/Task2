using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver = new ChromeDriver();

driver.Navigate().GoToUrl("https://pastebin.com/");
driver.Manage().Window.Maximize();

driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/a[2]")).Click();

driver.FindElement(By.Id("postform-text")).SendKeys("git config --global user.name  'New Sheriff in Town'");
driver.FindElement(By.Id("postform-text")).SendKeys("git reset $(git commit-tree HEAD^{tree} -m 'Legacy code')");
driver.FindElement(By.Id("postform-text")).SendKeys("git push origin master --force");



driver.FindElement(By.Id("select2-postform-format-container")).Click();
driver.FindElement(By.XPath("/html/body/span[2]/span/span[2]/ul/li[2]/ul/li[1]")).Click();


driver.FindElement(By.Id("select2-postform-expiration-container")).Click();
driver.FindElement(By.XPath("/html/body/span[2]/span/span[2]/ul/li[3]")).Click();

driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/form/div[5]/div[1]/div[9]/div/input")).SendKeys("how to gain dominance among developers");


driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/form/div[5]/div[1]/div[10]/button")).Click();



