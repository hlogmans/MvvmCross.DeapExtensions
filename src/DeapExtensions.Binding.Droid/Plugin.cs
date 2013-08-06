using System;
using Android.Views;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.Binding.Droid.Binders.ViewTypeResolvers;

namespace DeapExtensions.Binding.Droid
{
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            // The type cache is not initialized yet when the plugins are loaded. So add a callback when is does.
            Mvx.CallbackWhenRegistered<IMvxTypeCache<View>>(FillViewTypes);
            Mvx.CallbackWhenRegistered<IMvxAxmlNameViewTypeResolver>(FillAxmlViewTypeResolver);
        }

        private void FillAxmlViewTypeResolver(IMvxAxmlNameViewTypeResolver viewTypeResolver)
        {
            viewTypeResolver.ViewNamespaceAbbreviations["DeapExt"] = "DeapExtensions.Binding.Droid.Views";
        }

        protected void FillViewTypes(IMvxTypeCache<View> cache)
        {
            cache.AddAssembly(typeof(DeapExtensions.Binding.Droid.Views.BindableGroupListView).Assembly);
        }
    }
}
