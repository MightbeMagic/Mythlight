using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class Part 
    {
        public bool Posable { get; set; }
        public Vector3 DefaultColor { get; set; }
        public PartType Type { get; set; }
        public List<Tag> Tags { get; set; }
        public IEnumerable<Object> Layers { get; set; } //redefine as Layer object later
        public IEnumerable<Object> HiddenBodyParts { get; set; } // redefine
        public IEnumerable<object> SkintoneLayers { get; set; } //redefine
        public IEnumerable<object> BlendMode { get; set; } //redefine
        public IEnumerable<object> Pallete { get; set; } // redefine
         
    }
}