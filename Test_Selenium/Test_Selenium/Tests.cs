using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test_Selenium
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Teste()
        {
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br/app/endereco/index.php");
            driver.Manage().Window.Maximize();

            // Validação para garantir que a página foi carregada
        }

        [TearDown]
        public void FimDoTeste()
        {
            driver.Quit();
        }
    }
}
