using UnityEngine;
using UnityEngine.UI;

public class AbilitySliderController : MonoBehaviour
{
    public static AbilitySliderController instance;

    [SerializeField] private Slider[] berserkerAbilites, twdAbilites, frostbiteAbilities;

    private GameObject currAbilities;
    public Slider[] currSliders;

    public GameObject berserkerParent, twdParent, frostbiteParent;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        switch (PlayerMovement.instance.playerClass)
        {
            case PlayerMovement.PlayerClass.berserker:
                currAbilities = berserkerParent;
                currSliders = berserkerAbilites;
                break;
            case PlayerMovement.PlayerClass.theWhiteDeath:
                currAbilities = twdParent;
                currSliders = twdAbilites;
                break;
            case PlayerMovement.PlayerClass.frostbite:
                currAbilities = frostbiteParent;
                currSliders = frostbiteAbilities;
                break;
        }

        currAbilities.SetActive(true);
        
    }

    private void Update()
    {
        foreach (Slider s in currSliders) { 
            if (s.value != s.maxValue)
            {
                s.value = Mathf.MoveTowards(s.value, s.maxValue, Time.deltaTime);
            }
        }
    }

    public void resetSlider(int i) { 
        currSliders[i].value = 0;
    }
}
