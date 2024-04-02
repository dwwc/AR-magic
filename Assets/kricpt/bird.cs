using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
        Animator anim;
        void Start()
        {
            anim=this.GetComponent<Animator>();
        }
        void OnMouseDown()
        {
            anim.SetTrigger("istouched");
        }
}
