using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace DelondAndriod
{
    //[Activity(Label = "DelondAndriod", MainLauncher = true, Icon = "@drawable/icon")]
    //public class MainActivity : Activity
    //{
    //    int count = 1;

    //    protected override void OnCreate(Bundle bundle)
    //    {
    //        base.OnCreate(bundle);

    //        // Set our view from the "main" layout resource
    //        SetContentView(Resource.Layout.Main);

    //        // Get our button from the layout resource,
    //        // and attach an event to it
    //        Button button = FindViewById<Button>(Resource.Id.MyButton);

    //        button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
    //    }
    //}

    [Activity(Label = "Delon Hockey App Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            CrashManager.Register(this, "be3e30f56610446c994186ada20d4479");

            MetricsManager.Register(Application, "be3e30f56610446c994186ada20d4479");
            SetContentView(Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.btnClick);
            button.Click += delegate
            {
                HockeyApp.Android.Metrics.MetricsManager.TrackEvent("button.Click");
                throw new DivideByZeroException("Divide By Zero Exception");
            };
            Button nextbutton = FindViewById<Button>(Resource.Id.btnNextPage);
            nextbutton.Click += delegate
            {
                HockeyApp.Android.Metrics.MetricsManager.TrackEvent("nextbuttons");
                StartActivity(typeof(NextPageActivity));
            };
        }


    }
}

