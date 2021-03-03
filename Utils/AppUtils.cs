using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Windows;

namespace FishSpiderPluginEngineWPF.Utils
{
    public static class AppUtils
    {
        private static readonly string TAG = "AppUtils";


        public static void CheckAdministrator()
        {
            WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
            bool isAdministratorRole = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!isAdministratorRole)
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);
                processStartInfo.WorkingDirectory = Environment.CurrentDirectory;
                processStartInfo.FileName = Assembly.GetExecutingAssembly().Location;
                processStartInfo.UseShellExecute = true;
                processStartInfo.Verb = "runas";
                try
                {
                    Process.Start(processStartInfo);
                }
                catch (Exception e)
                {
                    Log.E(TAG, e, "Failed When CheckAdminitrator");
                }

                Environment.Exit(0);
                //Application.Current.Shutdown();
            }
        }


    }
}
