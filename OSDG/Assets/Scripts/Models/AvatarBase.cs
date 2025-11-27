using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class AvatarBase : MonoBehaviour
    {
        public bool IsLineart;
        public SpriteRenderer sprite;

        private void Awake()
        {
            sprite = this.GetComponent<SpriteRenderer>();
        }
    }
}