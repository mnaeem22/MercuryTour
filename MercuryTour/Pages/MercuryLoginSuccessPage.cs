using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System;

namespace MercuryTour.Pages
{
	public class MercuryLoginSuccessPage
	{
		IWebDriver mydriver;

		public MercuryLoginSuccessPage(IWebDriver mydriver)
		{
			this.mydriver = mydriver;
			PageFactory.InitElements(mydriver, this);
			
		}


		public String LoginSuccessMessage()
		{
			
			String successMessageText = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[1]/td/h3")).Text;
			return successMessageText;

		}
	}
}