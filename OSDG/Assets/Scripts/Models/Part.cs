using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Part : MonoBehaviour 
    {
        public bool Posable;
        public Vector3 DefaultColor;
        public PartType Type;
        public List<Tag> Tags;
        public List<PartLayer> Layers; //redefine as Layer object later
        public IEnumerable<Object> HiddenBodyParts { get; set; } // redefine
        public IEnumerable<object> SkintoneLayers { get; set; } //redefine
        public IEnumerable<object> BlendMode { get; set; } //redefine
        public IEnumerable<object> Pallete { get; set; } // redefine

        private void Start()
        {
            SetLayers(Layers);
        }

        public void SetLayers(List<PartLayer> layers)
        {
            Layers = layers;

            foreach (var item in Layers)
            {
                item.Image.sortingLayerName = Type.ToString();
                item.Image.sortingOrder = item.LayerPosition;
            }
        }
         
    }
}