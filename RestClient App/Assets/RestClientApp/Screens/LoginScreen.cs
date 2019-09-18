using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;
using UnityEngine;
using RestClientApp.Components;
using RestClientApp.Constants;
using RestClientApp.Utils;

namespace RestClientApp.Screens {
    public class LoginScreen : StatelessWidget {

        public override Element createElement() {
            StatusBarManager.hideStatusBar(false);
            return base.createElement();
        }

        public override Widget build(BuildContext context) {
            return new Container(
                color: CColors.White,
                child: new CustomSafeArea(
                    child: null
                )
            );
        }
    }
}