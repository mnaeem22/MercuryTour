using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace MercuryTour.Pages
{
	public class MercuryRegistrationPage
	{

		IWebDriver mydriver;

		public MercuryRegistrationPage(IWebDriver mydriver)
		{
			this.mydriver = mydriver;
			PageFactory.InitElements(mydriver, this);

		}



		[Test]
		public void EnterRegisterInformation()
		{
			
			IWebElement firstNameTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/input"));
			firstNameTxtField.SendKeys("firstName");

			IWebElement lastNameTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/input"));
			lastNameTxtField.SendKeys("lastName");

			IWebElement phoneTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/input"));
			phoneTxtField.SendKeys("12345678");

			IWebElement emailTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/input"));
			emailTxtField.SendKeys("email@email.com");

			IWebElement addressTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/input"));
			addressTxtField.SendKeys("address");

			IWebElement cityTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/input"));
			cityTxtField.SendKeys("city");

			IWebElement stateTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/input"));
			stateTxtField.SendKeys("state");

			IWebElement postalCodeTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input"));
			postalCodeTxtField.SendKeys("state");

			IWebElement countryDrpDown = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/select"));
			var selectCountry = new SelectElement(countryDrpDown);
			selectCountry.SelectByText("PAKISTAN");

			IWebElement userNameTxtField = mydriver.FindElement(By.XPath("//*[@id='email']"));
			userNameTxtField.SendKeys("username");

			IWebElement passwordTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input"));
			passwordTxtField.SendKeys("password");

			IWebElement confirmPasswordTxtField = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[15]/td[2]/input"));
			confirmPasswordTxtField.SendKeys("password");

			IWebElement submitButton= mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[17]/td/input"));
			submitButton.Click();

		}

	}
}