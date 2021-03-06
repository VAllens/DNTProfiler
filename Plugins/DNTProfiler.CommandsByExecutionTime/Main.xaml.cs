﻿using DNTProfiler.CommandsByExecutionTime.ViewModels;
using DNTProfiler.PluginsBase;

namespace DNTProfiler.CommandsByExecutionTime
{
    public partial class Main
    {
        public Main(ProfilerPluginBase pluginContext)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(pluginContext);
        }
    }
}