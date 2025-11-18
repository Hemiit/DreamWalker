using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantRotate : MonoBehaviour
{
    public float rotateDegree;
    public float duration;


    // Start is called before the first frame update
    void Start()
    {
        AnimPlantSway();
    }

    void AnimPlantSway() 
    {
        var rotation = new Vector3(0f,0f,-rotateDegree);
        DOTween.Sequence()
            .Append(transform.DOLocalRotate(rotation, duration))
            .SetLoops(-1,LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
