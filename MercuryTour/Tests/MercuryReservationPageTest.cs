using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using MercuryTour.Pages;
using MercuryTour.Base;

namespace MercuryTour.Tests
{
	public class MercuryReservationPageTest : BaseClass
	{

		
		string reservationFlightFinderTextExpected = "After flight finder - No Seats Avaialble  ";

		[SetUp]
		public void Navigate()
		{
			mydriver.Url = "https://demo.guru99.com/test/newtours/reservation.php";

		}

		[Test]
		public void ReservationSearchTestExec()
		{
			
			MercuryReservationPage resTest = new MercuryReservationPage(mydriver);
			resTest.ReservationSearchTest();
			MercuryReservationPage2 reservationFlightFinderText = new MercuryReservationPage2(mydriver);
			string reservationFlightFinderTextActual = reservationFlightFinderText.ReservationSearchText();

			Assert.AreEqual(reservationFlightFinderTextExpected,reservationFlightFinderTextActual);
		}
		
	}
}