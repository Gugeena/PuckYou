using UnityEngine;
using UnityEngine.InputSystem;

public class dynamicAudioVolume : MonoBehaviour
{
    PlayerMovement pm;
    InputAction move;

    private float volume;
    [SerializeField] private AudioSource source;
    private void Start()
    {
        pm= PlayerMovement.instance;
        move = pm.move;

        volume = source.volume;
    }

    private void Update()
    {
        source.volume = volume * move.ReadValue<Vector2>().magnitude;
    }
}
