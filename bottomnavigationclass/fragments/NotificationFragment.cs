
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace bottomnavigationclass.fragments
{
    public class NotificationFragment : AndroidX.Fragment.App.DialogFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment


          
            View view = inflater.Inflate(Resource.Layout.fragment_notification, container, false);
           // string str = Arguments.GetString("Dada");
            TextView txxtSemt = view.FindViewById<TextView>(Resource.Id.txt_noti);
          //  txxtSemt.Text = $"{str} is a response value";
            txxtSemt.Text = "Welcome to Notification Daialog";

            return view;
            //return base.OnCreateView(inflater, container, savedInstanceState);

        }
    }
}
