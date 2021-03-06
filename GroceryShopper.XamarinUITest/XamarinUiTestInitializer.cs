﻿using Xamarin.UITest;

namespace GroceryShopper.XamarinUITest
{
    public abstract class XamarinUiTestInitializer
    {
        private const string PathToApk = "../../../GroceryShopper.Forms.Droid/bin/Release/GroceryShopper.Forms.Droid-Signed.apk";
        private const string PathToIpa = "<Todo>";

        public static IApp ConfigureAndStart(Platform platform, bool isTestCloud)
        {
            if (isTestCloud)
            {
                return platform == Platform.Android ? (IApp)ConfigureApp.Android.StartApp() : ConfigureApp.iOS.StartApp();
            }

            return platform == Platform.Android
                ? (IApp)ConfigureApp.Android.ApkFile(PathToApk).EnableLocalScreenshots().StartApp()
                : ConfigureApp.iOS.AppBundle(PathToIpa).EnableLocalScreenshots().StartApp();
        }
    }
}
