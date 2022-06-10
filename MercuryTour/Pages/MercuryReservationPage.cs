using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MercuryTour.Pages
{
	public class MercuryReservationPage
	{

		IWebDriver mydriver;

		public MercuryReservationPage(IWebDriver mydriver)
		{
			this.mydriver = mydriver;
			PageFactory.InitElements(mydriver, this);

		}



		[Test]
		public void ReservationSearchTest()
		{
			
			IWebElement passengers = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select"));
			var selectpassengers = new SelectElement(passengers);
			selectpassengers.SelectByValue("2");

			IWebElement deptFrom = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/select"));
			var selectdeptFrom = new SelectElement(deptFrom);
			selectdeptFrom.SelectByValue("Frankfurt");

			IWebElement fromMonth = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[1]"));
			var fromMonthOn = new SelectElement(fromMonth);
			fromMonthOn.SelectByValue("3");

			IWebElement fromDay = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[2]"));
			var fromDayOn = new SelectElement(fromDay);
			fromDayOn.SelectByValue("12");

			IWebElement toPort = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td[2]/select"));
			var toPortSelect = new SelectElement(toPort);
			toPortSelect.SelectByValue("London");

			IWebElement toMonth = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[1]"));
			var toMonthSelect = new SelectElement(toMonth);
			fromMonthOn.SelectByValue("7");

			IWebElement toDay = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[2]"));
			var toDaySelect = new SelectElement(toDay);
			fromMonthOn.SelectByValue("12");

			IWebElement continueButton = mydriver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td/input"));
			continueButton.Click();

			
		}
		
	}
}