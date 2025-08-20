using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using Singleton.Generic;

namespace Screens 
{ 
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBase;

        // The initial screen to show when the game starts
        public ScreenType startScreen = ScreenType.Gameplay;

        private ScreenBase _currentScreen;


        private void Start()
        {
            HideAll();
            ShowByType(startScreen);
        }


        public void ShowByType(ScreenType type)
        {

            if (_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBase.Find(x => x.screenType == type);

            nextScreen?.Show();
            _currentScreen = nextScreen;

        }

        public void HideAll()
        {
            screenBase.ForEach(screen => screen.Hide());
        }
    }
}

