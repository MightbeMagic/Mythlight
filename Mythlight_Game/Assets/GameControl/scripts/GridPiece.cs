using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPiece : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite = null;
    [SerializeField] GameObject currentObject = null;


	Color baseColor;
	Color highlightColor;

    // Start is called before the first frame update
    void Awake()
    {
		baseColor = Color.black;
		highlightColor = Color.yellow;
    }

	public void SetColor(Color color)
	{
		sprite.color = color;
		baseColor = color;
	}

	private void OnMouseEnter()
	{
		sprite.color = highlightColor;
	}
	private void OnMouseExit()
	{
		sprite.color = baseColor;
	}
}
