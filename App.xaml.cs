using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Reflection;
using System.Diagnostics;
using Ini;

namespace TrainingProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    internal delegate void Invoker();
    public partial class App : Application
    {
        public App()
        {

            // Populate global variables
            LoadAppVariables gen = new LoadAppVariables();

            gen.LoadApplication();

            //ApplicationInitialize = _applicationInitialize;
        }
    }
}
