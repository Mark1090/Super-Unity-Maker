using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_Changer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite Dirt;
    public Sprite Grass;
    public Grass_Check Up_Grass_Check;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Up_Grass_Check.Touching_Up)
        {
            ChangeSpriteDirt();
            Debug.Log("2");
        }
        else
        {
            ChangeSpriteGrass();
        }
    }
    void ChangeSpriteDirt()
    {
        spriteRenderer.sprite = Dirt;
    }

    void ChangeSpriteGrass()
    {
        spriteRenderer.sprite = Grass;
    }
}
