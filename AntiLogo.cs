using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;

public class AntiLogo
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void Function()
    {
        Task.Run(() => { SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate); });
    }
}