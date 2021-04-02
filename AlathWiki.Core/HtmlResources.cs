#region header

// AlathWiki.Core - HtmlResources.cs
// 
// Created by: Alistair J R Young (avatar) at 2021/04/02 10:53 AM.

#endregion

#region using

using System.IO;
using System.Reflection;

#endregion

namespace ArkaneSystems.AlathWiki.Core
{
    public static class HtmlResources
    {
        private static readonly Assembly ThisAssembly;

        static HtmlResources () => HtmlResources.ThisAssembly = Assembly.GetExecutingAssembly ();

        public static string InitialPage
        {
            get
            {
                Stream str =
                    HtmlResources.ThisAssembly.GetManifestResourceStream (type: typeof (HtmlResources),
                                                                          name: "html.initial.html")!;

                return new StreamReader (stream: str).ReadToEnd ();
            }
        }
    }
}
