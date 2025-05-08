using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Singletons
{
    /// <summary>
    /// Central Game Manager for entire game. 
    /// All Singletons should be accessed from this parent class. fake dependency injection
    /// </summary>
    public class SystemManager : MonoBehaviour
    {
        public AvatarManager avatarManager;
        public DyeManager dyeManager;
        public PalleteManager palleteManager;
        public PartsManager partManager;
        public SearchManager searchManager;
        public SettingsManager settingsManager;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}