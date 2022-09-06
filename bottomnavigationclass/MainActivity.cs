using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.App;
using bottomnavigationclass.fragments;
using bottomnavigationclass.IInterface;
using Google.Android.Material.BottomNavigation;
using TaskStackBuilder = AndroidX.Core.App.TaskStackBuilder;

namespace bottomnavigationclass
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener, IFragmentCall
    {

        protected override void OnStart()
        {
            base.OnStart();
            var strin = "OnStart";
                
        }

        protected override void OnStop()
        {
            base.OnStop();
            var strin = "OnStop";

        }


        protected override void OnPause()
        {
            base.OnPause();
            var strin = "OnPause";
        }


        protected override void OnResume()
        {
            base.OnResume();
            var strin = "OnResume";


        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            var strin = "OnDestroy";

         
        }



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            Utility.SwapFragment(new HomeFragment(), SupportFragmentManager, false);
            navigation.NavigationItemSelected += NavigationClickedSelect;
           
           // navigation.SetOnNavigationItemSelectedListener(this);

        }

        public void NavigationClickedSelect(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            LoadFragments(e.Item.ItemId);
        }

        /*
         * 
         *   private void loadFirstFragment()
          {
              var frag = SupportFragmentManager.BeginTransaction();
              HomeFragment home = new HomeFragment();
              frag.Replace(Resource.Id.content_frame, home);
              frag.Commit();
          }
         */

        public void LoadFragments(int d)
        {
            var frag = SupportFragmentManager.BeginTransaction();
            switch (d)
            {
                case Resource.Id.navigation_home:
                    Utility.SwapFragment(new HomeFragment(), SupportFragmentManager, true);
                    break;
                case Resource.Id.navigation_dashboard:
                    Utility.SwapFragment(new DashboardFragment(), SupportFragmentManager, true);
                    break;
            }
            frag.Commit();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            var frag = SupportFragmentManager.BeginTransaction();
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    HomeFragment home = new HomeFragment();
                    frag.Replace(Resource.Id.content_frame, home);
                    break;
                case Resource.Id.navigation_dashboard:
                    DashboardFragment dashboard = new DashboardFragment();
                    frag.Replace(Resource.Id.content_frame, dashboard);
                    break;
            
            }
            frag.Commit();
            return true;
        }

        public void openNotificationFrgament()
        {
            //Utility.showNotification("Wema", "Trainin", this);
            Utility.swapFragment(new NotificationFragment(), SupportFragmentManager, this,"Ayodeji", true);
        }

        public void openNotificationFrgament(string value)
        {
            Utility.swapFragment(new NotificationFragment(), SupportFragmentManager, this, "Ade and Dada are Android devs", true);

        }
    }
}

