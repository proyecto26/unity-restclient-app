using System.Collections.Generic;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.widgets;
using Unity.UIWidgets.ui;
using UnityEngine;
using Image = Unity.UIWidgets.widgets.Image;
using RestClientApp.Constants;
using RestClientApp.Utils;

namespace RestClientApp.Screens {
    public class SplashScreen : StatelessWidget {

        public override Element createElement() {
            StatusBarManager.hideStatusBar(true);
            return base.createElement();
        }

        public override Widget build(BuildContext context) {
            if (Application.platform == RuntimePlatform.Android) {
                return new Container(
                    color: CColors.White);
            }

            return new Container(
                color: CColors.White,
                child: new Center(
                    child: new Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        crossAxisAlignment: CrossAxisAlignment.center,
                        children: new List<Widget> {
                            new Container(
                                width: MediaQuery.of(context).size.width,
                                height: MediaQuery.of(context).size.height,
                                margin: EdgeInsets.only(bottom: 0, top: 0),
                                child: Image.asset("image/iOS/AppIcon.imageset/AppIcon",
                                    fit: BoxFit.cover)
                            ),
                            new Text (
                                "By @jdnichollsc",
                                textAlign: TextAlign.center,
                                style: CTextStyle.H2
                            )
                        })
                ));
        }
    }
}