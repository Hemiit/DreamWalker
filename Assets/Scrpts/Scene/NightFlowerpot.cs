using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class NightFlowerpot : MonoBehaviour
{
    public BoxCollider2D collider;
    public float fadeSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Touch Flowerpot.");

        collider.enabled= false;

        Player.I.hasKnockOffFlowerPot = true;

        //Fade out: standed pot.
        //Fade in : laied pot on the ground.
        var standPot =GameMgr.I.roomCtrl.nightRoomProps.flowerpot_Night;
        var onGroundPot = GameMgr.I.roomCtrl.nightRoomProps.flowerpot_Night_OnGround;

        DOTween.Sequence()
            .Append(standPot.DOFade(0, fadeSpeed))
            .Join(Camera.main.DOShakePosition(1f,0.1f,10))
            .Append(onGroundPot.DOFade(1,fadeSpeed))
            .AppendCallback(()=>{ gameObject.SetActive(false);});
        


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //print("Leave Flowerport.");


    }
}
