using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackCurtain : MonoBehaviour
{
    public Image black;
    public float speed;

    public void Init ()
    {
        black.color = new Color(0,0,0,0);
        black.gameObject.SetActive(false);
    }

    public void Show() 
    {
        black.gameObject.SetActive(true);

        DOTween.Sequence()
            .Append(black.DOFade(1,speed))
            .AppendInterval(3f)
            .Append(black.DOFade(0,speed))
            ;
    }
    public void Hide() 
    {
        //DOTween.Sequence()
        //    .Append(black.DOFade(0, speed))
        //    ;
    }
}
