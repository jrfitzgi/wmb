using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Wmb.Views
{
    public class CustomBaseViewPage<T> : WebViewPage<T> where T : class
    {
        public CustomBaseViewPage() { }

        public override void Execute()
        {
            throw new System.NotImplementedException();
        }

        protected override void InitializePage()
        {
            base.InitializePage();

            this.CountPage();
        }

        /// <summary>
        /// Increments the page count for this page
        /// </summary>
        private void CountPage()
        {
            if (MvcApplication.PageVisits.ContainsKey(this.VirtualPath))
            {
                MvcApplication.PageVisits[this.VirtualPath]++;
            }
            else
            {
                MvcApplication.PageVisits.Add(this.VirtualPath, 1);
            }

            this.ViewBag.PageVisits = MvcApplication.PageVisits[this.VirtualPath].ToString();
        }
    }
}