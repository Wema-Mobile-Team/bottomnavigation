using System;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using AndroidX.Core.App;
using AndroidX.Fragment.App;
using Android.App;
using Fragment = AndroidX.Fragment.App.Fragment;
using FragmentManager = AndroidX.Fragment.App.FragmentManager;

namespace bottomnavigationclass
{
    public class Utility
    {
        public Utility()
        {
        }

        public static void SwapFragment(Fragment fragment,FragmentManager fragmentManager,bool addToBackStack)
        {
            if (addToBackStack) fragmentManager.BeginTransaction().Replace(Resource.Id.content_frame, fragment).AddToBackStack(null).Commit();
            else fragmentManager.BeginTransaction().Replace(Resource.Id.content_frame, fragment).Commit();
        }

    

        public static void swapFragment(Fragment fragment, FragmentManager fragmentManager, Context context, string data, bool   addToBackStack)
        {
            Bundle bundle = new Bundle();
            bundle.PutString("Dada", data);
            fragment.Arguments  = (bundle);
            SwapFragment(fragment, fragmentManager, addToBackStack);
        }




        public static void swapFragment(Fragment fragment, FragmentManager fragmentManager, Context context, IParcelable data, bool addToBackStack)
        {
            Bundle bundle = new Bundle();
            bundle.PutParcelable(context.Resources.GetString(Resource.String.fallback_menu_item_copy_link), data);
            fragment.Arguments = (bundle);
            SwapFragment(fragment, fragmentManager, addToBackStack);
        }



        public static void showNotification(string title, string message, Context context)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                string channelName = context.GetString(Resource.String.app_name);
                string description = context.GetString(Resource.String.app_name);
                var importance = NotificationImportance.Default;
                NotificationChannel channel = new NotificationChannel(channelName, "Ayodeji", importance);
                NotificationManager notificationManage = context.GetSystemService(Context.NotificationService) as NotificationManager;
                notificationManage.CreateNotificationChannel(channel);
        }


            NotificationCompat.Builder mBuilder = new NotificationCompat.Builder(context, context.GetString(Resource.String.app_name))
            .SetSmallIcon(Resource.Drawable.ic_home_black_24dp)
            .SetContentTitle(title)
            .SetContentText(message)
            //.SetContentIntent(contentIntent)
            .SetAutoCancel(true)
            .SetPriority(3);

             Notification notification = mBuilder.Build();
             NotificationManager notificationManager = context.GetSystemService(Context.NotificationService) as NotificationManager;
            notificationManager.Notify(100, notification);
    }


    }
}
