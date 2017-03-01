using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace rentcar.Web.Views
{
    public abstract class rentcarRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected rentcarRazorPage()
        {
            LocalizationSourceName = rentcarConsts.LocalizationSourceName;
        }
    }
}
