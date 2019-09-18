using System.Runtime.InteropServices;
using UnityEngine;

namespace RestClientApp.Utils {
    public static class StatusBarManager {
        public static void statusBarStyle(bool isLight) {
            if (Application.platform != RuntimePlatform.IPhonePlayer) {
                return;
            }

            setStatusBarStyle(isLight);
        }

        public static void hideStatusBar(bool hidden) {
            if (Application.platform != RuntimePlatform.IPhonePlayer) {
                return;
            }

            hiddenStatusBar(hidden);
        }


#if UNITY_IOS
        [DllImport("__Internal")]
        static extern void setStatusBarStyle(bool isLight);

        [DllImport("__Internal")]
        static extern void hiddenStatusBar(bool hidden);

#else
        static void setStatusBarStyle(bool isLight) {
        }
        static void hiddenStatusBar(bool hidden) {
        }
#endif
    }
}