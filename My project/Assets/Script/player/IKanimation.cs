/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class IKanimation : MonoBehaviour {
    public Animator animationPlayer;
    public static IKanimation IKMAGNET;
    // Use this for initialization
    void Start () {
        IKMAGNET = this;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnAnimatorIK()
    {
        animationPlayer.SetIKPositionWeight(AvatarIKGoal.RightHand, iklegth);
        animationPlayer.SetIKPositionWeight(AvatarIKGoal.LeftHand, iklegth1);
        // Quaternion handRotation = Quaternion.LookRotation(positionmangnetl.position - transform.position);
        // Quaternion handRotation = Quaternion.LookRotation(positionmangnetl.position - transform.position);
        // animationPlayer.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0F);
        // animationPlayer.SetIKRotation(AvatarIKGoal.RightHand, handRotation);
        animationPlayer.SetIKPosition(AvatarIKGoal.RightHand, positionRighHand.position);
        animationPlayer.SetIKPosition(AvatarIKGoal.LeftHand, positionLeftHand.position);
    }
    public void SetIKnamCham()
    {
        positionRighHand = positionmangnetl;
    }
    public void SetIKBay()
    {
        positionRighHand = positionRighHand;
        positionLeftHand = positionLeftHand;
    }
    public void Deleteikbay()
    {
        if (Manageritem.hutcoin ==false)
        {
            iklegth = 0;
        }
        iklegth1 = 0;
    }
    public Transform positionmangnetl;
    public Transform positionRighHand;
    public Transform positionLeftHand;
    public static float iklegth;
    public static float iklegth1;

}
