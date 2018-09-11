using System.Web.Mvc;

namespace PTC.Web
{
    internal class ViewEnginesConfiguration
    {
        internal static void RegisterViewEngines(ViewEngineCollection engines)
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
        }
    }
}