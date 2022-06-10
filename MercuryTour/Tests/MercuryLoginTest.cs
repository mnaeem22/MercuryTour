using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using MercuryTour.Pages;
using MercuryTour.Base;
using System.Configuration;

namespace MercuryTour.Tests
{
	public class MercuryLoginTest : BaseClass
	{
		
		string expectedLoginSuccessMessage = "Login Successfully";

		[SetUp]
		public void Navigate()
		{
			
			mydriver.Url = "https://demo.guru99.com/test/newtours/";
		}


		[Test]
		public void LoginTestExec()
		{

			MercuryLoginPage login_test = new MercuryLoginPage(mydriver);

			//OLD Implementation
			//string userName = ConfigurationManager.AppSettings.Get("Username");
			//string password = ConfigurationManager.AppSettings.Get("Password");
			//login_test.LoginTest("userName", "password");

			//New Implementation
			login_test.LoginTest(CSettings.UserName,CSettings.Password);

			MercuryLoginSuccessPage loginSuccessMessage = new MercuryLoginSuccessPage(mydriver);
			string actualLoginSuccessMessage= loginSuccessMessage.LoginSuccessMessage();

			Assert.AreEqual(expectedLoginSuccessMessage,actualLoginSuccessMessage);
					   
		}
	}
}