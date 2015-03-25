using System;

using Xamarin.Forms;

namespace HelloXamarinForms
{
	public class MyPage1 : ContentPage
	{
		public MyPage1 ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


