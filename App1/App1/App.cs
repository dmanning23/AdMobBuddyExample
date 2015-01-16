using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdMobBuddy.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace App1
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						new AdMobBuddyControl{
							AdUnitId = "ca-app-pub-8228485892439970/3183360843"
						}
					}
				}
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
