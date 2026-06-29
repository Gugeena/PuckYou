using UnityEngine;

public class LowTierGodScript : MonoBehaviour
{
    [SerializeField] private float time;

    private void Awake()
    {
        Destroy(gameObject, time);
    }
}
