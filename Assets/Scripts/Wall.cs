using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public Sprite dmgSprite;
    public int hp = 4;

    private SpriteRenderer spriteRender;

	// Use this for initialization
	void Awake () {
        spriteRender = GetComponent<SpriteRenderer>();
	}

    public void DamageWall(int loss) {
        spriteRender.sprite = dmgSprite;
        hp -= loss;
        if (hp <= 0) {
            gameObject.SetActive(false);
        }

    }
	
}
