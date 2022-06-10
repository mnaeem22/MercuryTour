using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace MercuryTour.Pages
{
	public class MercuryReservationPage2
	{

		IWebDriver mydriver;

		public MercuryReservationPage2(IWebDriver mydriver)
		{
			this.mydriver = mydriver;
			PageFactory.InitElements(mydriver, this);

		}



		[Test]
		public String ReservationSearchText()
		{
			
			String flighFinderText = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[1]/td/p/font/b/font[1]")).Text;
			return flighFinderText;
			
		}
		
	}
}