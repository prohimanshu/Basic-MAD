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
using MakePhoneCall.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(PhoneCall_Droid))]

namespace MakePhoneCall.Droid
{
    public class PhoneCall_Droid : IPhoneCall
    {
        public void makecall(string phonenumber)
        {
            try
            {

           
            var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", phonenumber));
            var intent = new Intent(Intent.ActionCall, URI);
            Xamarin.Forms.Forms.Context.StartActivity(intent);
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
            }
        }
    }
}