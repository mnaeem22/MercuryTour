using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using MercuryTour.Pages;
using MercuryTour.Base;

namespace MercuryTour.Tests
{
	public class MercuryRegisterTest : BaseClass
	{
	
		[SetUp]
		public void Navigate()
		{
			
			mydriver.Url = "https://demo.guru99.com/test/newtours/register.php";
		}


		[Test]
		public void RegisterTestExec()
		{

			MercuryRegistrationPage register_test  = new MercuryRegistrationPage(mydriver);
			register_test.EnterRegisterInformation();

			
		}
	}
}