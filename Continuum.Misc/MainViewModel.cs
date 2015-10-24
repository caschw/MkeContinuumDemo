using System;

namespace Continuum.Misc
{
    public class MainViewModel
    {
        public string Greeting { get { return "Hello Milwaukee Code Camp!"; } }

        public string Time { get { return DateTime.Now.ToString("HH:mm:ss"); } }
    }
}
