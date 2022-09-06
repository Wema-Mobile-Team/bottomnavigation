
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
using bottomnavigationclass.IInterface;

namespace bottomnavigationclass.fragments
{
    public class HomeFragment : AndroidX.Fragment.App.Fragment
    {
        private Context mContext;
        private IFragmentCall callback;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
        }

     

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            mContext = context;
            callback = (IFragmentCall)context;
        }

    

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view  = 
               inflater.Inflate(Resource.Layout.fragment_home, container, false);
            initializeView(view);
            return view;
        }

        private void initializeView(View view)
        {
            Button button = view.FindViewById<Button>(Resource.Id.btn_purchase);
            //button = view.
            button.Click += delegate {
                clieckcc();
            };
        }
        private void clieckcc()
        {
            Toast.MakeText(mContext, "I'm going to Notification Page", ToastLength.Long).Show();

            //   AndroidX.Activity.FragmentTransaction fragment = ChildFragmentManager.BeginTransaction();
             var tras = ChildFragmentManager.BeginTransaction();
            //  var tras = mActivity.Sup .BeginTransaction();

            tras.Replace(Resource.Id.content_frame, new NotificationFragment(), "NotificationFragment");
            // tras.AddToBackStack(null);
            //  tras.Commit();
            //  Utility.SwapFragmentChild(new NotificationFragment(), ChildFragmentManager, false);

            var notification = new NotificationFragment();
            notification.Show(ChildFragmentManager, "notification");
           // callback.openNotificationFrgament("");

        }
    }
}
