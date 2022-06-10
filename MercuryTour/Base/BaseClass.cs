using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercuryTour.Base
{
	public class BaseClass
	{

		public IWebDriver mydriver;

	[OneTimeSetUp]
		public void StartBrowser()
		{
			mydriver = new ChromeDriver("F:\\Selenium");
			mydriver.Manage().Window.Maximize();

		}

	[OneTimeTearDown]
		public void CloseBrowser()
		{
			mydriver.Quit();

		}

	}
}
