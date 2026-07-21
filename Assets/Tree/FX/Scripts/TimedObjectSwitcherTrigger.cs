using UnityEngine;

public class TimedObjectSwitcherTrigger : MonoBehaviour
{
    public TimedObjectSwitcher timedObjectSwitcher;

    public void StartEffects()
    {
        timedObjectSwitcher.enabled = true;
    }
}