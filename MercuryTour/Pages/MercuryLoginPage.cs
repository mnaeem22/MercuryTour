using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;


namespace MercuryTour.Pages
{
	public class MercuryLoginPage
	{
		IWebDriver mydriver;

		public MercuryLoginPage(IWebDriver mydriver)
		{
			this.mydriver = mydriver;
			PageFactory.InitElements(mydriver, this);
			
		}


		public void LoginTest(string username, string password)
		{
			
			IWebElement userNameTxtBox = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input"));
			userNameTxtBox.SendKeys(username);

			IWebElement passwrdTxtBox = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[3]/td[2]/input"));
			passwrdTxtBox.SendKeys(password);

			IWebElement submitButton = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[4]/td[2]/div/input"));
			submitButton.Submit();
			
		}
	}
}