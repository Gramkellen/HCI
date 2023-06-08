/*
https://www.cgvim.com/

极致(Acme) Unity3d 每日Unity3d插件更新 VIP免费下载



插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using UnityEngine;
using System.Collections;
/// <summary>
/// hành động tiums vào cổ của cảnh sát
/// </summary>
public class IkEmty : MonoBehaviour {
    public Animator animationPlayer;
    public static IkEmty IKMAGNET;
    // Use this for initialization
    void Start () {
        IKMAGNET = this;
        sEttaget();

    }
    /// <summary>
    /// sét vị trí túm cổ cho từng nhân vật
    /// </summary>
    public void sEttaget()
    {
        switch (managerdata.manager.Getnowcharacter())
        {
            case "nvchinh":
                maintaget = positionmangnetl;
                break;
            case "nvgirl":
                maintaget = positionmangnetlgirl;
                break;
            case "nvgau":
                maintaget = positionmangnetlgau;
                break;
            default:
                break;
        }
    }
    Transform maintaget;
    void OnAnimatorIK()
    {
        animationPlayer.SetIKPositionWeight(AvatarIKGoal.LeftHand, iklegth);
        animationPlayer.SetIKPositionWeight(AvatarIKGoal.RightHand, iklegth1);
        animationPlayer.SetIKPosition(AvatarIKGoal.LeftHand, maintaget.position);
        animationPlayer.SetIKPosition(AvatarIKGoal.RightHand, maintaget.position);
        // animationPlayer.SetIKHintPosition(AvatarIKHint.);
       // animationPlayer.
    }
    public Transform positionmangnetl; // ik cổ player chính
    public Transform positionmangnetlgau; // ik nhân vạt da đen
    public Transform positionmangnetlgirl; // ik nhân vật cô gái
    public static float iklegth;
    public static float iklegth1;
}
