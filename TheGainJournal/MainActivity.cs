using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace TheGainJournal
{
    [Activity(Label = "@string/app_name", Icon = "@mipmap/ic_launcher", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_workout:
                    textMessage.SetText(Resource.String.title_workout);
                    return true;
                case Resource.Id.navigation_you:
                    textMessage.SetText(Resource.String.title_you);
                    return true;
                case Resource.Id.navigation_management:
                    textMessage.SetText(Resource.String.title_management);
                    return true;
            }
            return false;
        }
    }
}

