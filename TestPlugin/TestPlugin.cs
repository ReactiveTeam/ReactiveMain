﻿using PluginCore;
using System.ComponentModel.Composition;
using System;

namespace TestPlugin
{
    [Export(typeof(IPlugin))]
    public class TestPlugin : IPlugin
    {
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
            System.Windows.Forms.MessageBox.Show("Test");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Tick()
        {
            throw new NotImplementedException();
        }
    }
}
