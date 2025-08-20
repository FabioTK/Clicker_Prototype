using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NaughtyAttributes;
using DG.Tweening; 

namespace Screens 
{ 
    public enum ScreenType
    {
        Status,
        Settings,
        Gameplay,
        Wardrobe,
        Shop,
        Achivements
    }


    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public Image uiBackground;

        public List<Transform> listOfObjects;

        [Header("Animation")]
        public float animationDuration = 0.3f;
        public float delayBetweenObjects = 0.5f;



        [Button("Hide")]
        public virtual void Hide()
        {
            HideObjects();
        }




        [Button("Show")]
        public virtual void Show()
        {
            ShowObjects();
        }




        private void HideObjects()
        {
            listOfObjects.ForEach(obj => obj.gameObject.SetActive(false));
            uiBackground.gameObject.SetActive(false);
        }

        private void ShowObjects()
        {

            for (int i = 0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(1, animationDuration).From(0).SetDelay(i * delayBetweenObjects);
            }
            
            uiBackground.gameObject.SetActive(true);
        }


    }
}
