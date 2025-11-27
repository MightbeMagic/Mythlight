using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class PartLayer : MonoBehaviour
    {
        public SpriteRenderer Image;
        public int LayerPosition;
        public Color DefaultColor;
        public Color Color;

        public PartLayer() { }
        public PartLayer(Color defaultColor, SpriteRenderer spriteRenderer)
        {
            DefaultColor = defaultColor;
            Image = spriteRenderer;
        }

        private void Awake()
        {
            Image = this.GetComponent<SpriteRenderer>();
            SetLayerToDefaults();
        }
        public void SetLayerColor(Color? newColor = null)
        {
            Image.color = (Color)(newColor.HasValue ? newColor : Color);
        }
        public void SetLayerToDefaults()
        {
            Image.color = DefaultColor;
        }
    }
}