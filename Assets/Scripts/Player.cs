using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour, IPlayerBehaviour
{
    public Text Score;
    
    public void PlayDamageSound()
    {
        throw new System.NotImplementedException();
    }

    public void ShowPlayerHit(int newScore)
    {
        anim.SetTrigger("death");
        Score.text = newScore.ToString();
    }

    public void UpdateGUI()
    {
        throw new System.NotImplementedException();
    }

    PlayerControler ctrl;
    Animator anim;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        ctrl = new PlayerControler(this, new PlayerData());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown()
    {
        ctrl.DoDamage();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //ctrl.OnCollisionEnter2D(collision.gameObject.getController());
    }
}


