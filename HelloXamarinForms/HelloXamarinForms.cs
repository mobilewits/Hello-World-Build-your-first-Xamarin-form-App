using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HelloXamarinForms
{
	public class App : Application
	{

		public App ()
		{

				MainPage=new NavigationPage(new MyPage());
		}
}

}