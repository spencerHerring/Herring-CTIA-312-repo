using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

namespace RPG.Cinemtics
{
    public class CinematicsControlCanceler : MonoBehaviour
    {

        private void Start()
        {
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;
        }

        void DisableControl(PlayableDirector pd) 
        {
            print("Disable Control");
        }

        void EnableControl(PlayableDirector pd)
        {
            print("Enable Control");
        }
    }
}
