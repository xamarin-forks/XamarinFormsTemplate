﻿using System;
using Test.NewSolution.FormsApp;
using System.Linq;

using Foundation;
using UIKit;

namespace Test.NewSolution.iOS
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}

