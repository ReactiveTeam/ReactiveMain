using PluginCore;
using System.ComponentModel.Composition;
using System;

namespace TestPlugin
{
    [Export(typeof(IPlugin))]
    public class TestPlugin : IPlugin
    {
        public string navItem
        {
            get
            {
                return "TESTNAV";
            }
        }

        public string pluginAuthor
        {
            get
            {
                return "Haikal Izzuddin";
            }
        }

        public string pluginDescription
        {
            get
            {
                return "Just a test plugin";
            }
        }

        public string pluginName
        {
            get
            {
                return "Test Plugin";
            }
        }

        public void Start()
        {
            // Your code here
        }

        public void Stop()
        {
            // Your code here
        }

        public void Tick()
        {
            // Your code here
        }
    }
}
