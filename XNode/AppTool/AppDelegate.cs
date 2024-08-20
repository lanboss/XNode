﻿using System.Windows;

namespace XNode.AppTool
{
    /// <summary>
    /// 应用程序代理
    /// </summary>
    public class AppDelegate
    {
        public static App Main { get; set; }

        public static string AppTitle => "XNode 1.0.2 Alpha";

        public static void Init()
        {
            if (Application.Current is App app) Main = app;
        }

        public static void Invoke(Action action)
        {
            Main.Dispatcher.Invoke(action);
        }

        public static void BeginInvoke(Action action)
        {
            Main.Dispatcher.BeginInvoke(action);
        }
    }
}