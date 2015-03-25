using System;

using Xamarin.Forms;

namespace HelloXamarinForms
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" },
					new Button {
						Text = "PushAsync",
						Command = new Command(() => Navigation.PushAsync(new MyPage1()))
					}
				}
			};

		}
	}
}


