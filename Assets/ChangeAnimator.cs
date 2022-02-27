using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorStand(){
        this.GetComponent<Animator>().Play("Unarmed Idle Looking Ver_2");
    }

    public void getAnimatorWalk(){
        this.GetComponent<Animator>().Play("Start Walking");
    }
}
