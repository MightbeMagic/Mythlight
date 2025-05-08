using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class ItemPack
    {
        public string PackName { get; set; }
        public string CreatorName { get; set; }
        public List<Part> Items { get; set; }
    }
}