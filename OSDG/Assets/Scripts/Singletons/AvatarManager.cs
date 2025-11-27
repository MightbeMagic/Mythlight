using Assets.Scripts.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AvatarManager : MonoBehaviour
{
    public Color Skintone;
    public Color LineartColor;
    public bool UseDefaultSkintone = true;
    Color DefaultSkintone = new Color (.64f, .45f, .29f, 1);
    Color DefaultLineart = new Color (.24f, .03f, .38f, 1);
    public List<SpriteRenderer> LineartPieces;
    public List<SpriteRenderer> SkinPieces;

    private void Start()
    {
        LineartPieces = this.GetComponentsInChildren<AvatarBase>().Where( x => x.IsLineart).Select(x => x.sprite).ToList();
        SkinPieces = this.GetComponentsInChildren<AvatarBase>().Where(x => !x.IsLineart).Select(x => x.sprite).ToList();

        SetSkintone(UseDefaultSkintone ? DefaultSkintone : Skintone);
        SetLineart(UseDefaultSkintone ? DefaultLineart : LineartColor);
    }

    public void SetSkintone (Color? newColor = null)
    {
        foreach (var item in SkinPieces)
        {
            item.color = (Color)(newColor.HasValue ? newColor: Skintone);
        }
    }

    public void SetLineart(Color? newColor = null)
    {
        foreach (var item in LineartPieces)
        {
            item.color = (Color)(newColor.HasValue ? newColor : LineartColor);
        }
    }

    public void SetDefaults()
    {
        SetSkintone(DefaultSkintone);
        SetLineart(DefaultLineart);
    }
}