using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumTests
{
    public class RegisterTests : IDisposable
    {
        private IWebDriver driver;

        public RegisterTests()
        {
            driver = new EdgeDriver(); 
        }

        [Fact]
        public void TestFillRegistrationForm()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");

            // Preencher o campo First Name
            IWebElement firstNameField = driver.FindElement(By.CssSelector("input[placeholder='First Name']"));
            firstNameField.SendKeys("Test");

            // Preencher o campo Last Name
            IWebElement lastNameField = driver.FindElement(By.CssSelector("input[placeholder='Last Name']"));
            lastNameField.SendKeys("User");

            // Preencher o endereço
            IWebElement addressField = driver.FindElement(By.CssSelector("textarea[ng-model='Adress']"));
            addressField.SendKeys("1234 Test Street");

            // Preencher o e-mail
            IWebElement emailField = driver.FindElement(By.CssSelector("input[ng-model='EmailAdress']"));
            emailField.SendKeys("testuser@test.com");

            // Preencher o número de telefone
            IWebElement phoneField = driver.FindElement(By.CssSelector("input[ng-model='Phone']"));
            phoneField.SendKeys("1234567890");

            // Selecionar gênero
            IWebElement genderRadio = driver.FindElement(By.XPath("//input[@value='Male']"));
            genderRadio.Click();

            // Verificar se os campos foram preenchidos corretamente gsdgsd
            Assert.Equal("Test", firstNameField.GetAttribute("value"));
            Assert.Equal("User", lastNameField.GetAttribute("value"));
        }


        // Método de descarte (substitui o [TearDown] do NUnit)
        public void Dispose()
        {
            driver.Quit(); // Fecha o navegadorrrr
        }
    }
}
