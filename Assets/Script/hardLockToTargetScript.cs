using UnityEngine;

public class hardLockToTargetScript : MonoBehaviour
{
    public Transform target;

    [SerializeField] private bool lockToPlayer = false;
    [SerializeField] protected bool copyDirection = false;

    private void Start()
    {
        if(lockToPlayer) target = PlayerMovement.instance.transform;
    }
    private void Update()
    {
        transform.position = target.position;
        if(copyDirection) transform.rotation = target.rotation;
    }
}
