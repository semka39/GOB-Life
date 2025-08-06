using System;
using System.Windows;

public partial class App : Application
{
    public App()
    {
        // Включение BinaryFormatter (ОПАСНО!)
        AppContext.SetSwitch("System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization", true);

    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
    }
}