using System;
using System.Collections.Generic;
using System.Text;
using Android.Views;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;
using DeapExtensions.Binding.Droid.Views;

namespace DeapExtensions.Binding.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType(typeof(BindableGroupListAdapter), typeof(BindableGroupListAdapter));
            Mvx.RegisterType(typeof(BindableExpandableListAdapter), typeof(BindableExpandableListAdapter));
            Mvx.RegisterType(typeof(BindableGroupListView), typeof(BindableGroupListView));
            Mvx.RegisterType(typeof(BindableExpandableListView), typeof(BindableExpandableListView));

            //var viewCache = Mvx.Resolve<IMvxTypeCache<View>>();
            //viewCache.AddAssembly(typeof(BindableExpandableListAdapter).Assembly);

        }
    }
}
