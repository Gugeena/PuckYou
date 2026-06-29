using UnityEngine;

public class StickHandler : MonoBehaviour
{
    [SerializeField] private Animator anim;

    private int swingDir = 0; //0 - right, 1 - Left;
    [SerializeField] private AnimationClip[] clips;

    public void swingAnim()
    {
        if (anim == null) return;
        anim.Play(clips[swingDir].name);

        swingDir++;

        if (swingDir > 1) swingDir = 0;
    }
}
