using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using WorkForceApp;
using WorkForceApp.Droid;

[assembly: ExportRenderer(typeof(MyEntry), typeof(CustomRenderer))]
namespace WorkForceApp.Droid
{
    class CustomRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
               
                Control.SetBackgroundResource(Resource.Drawable.borderxml);
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}