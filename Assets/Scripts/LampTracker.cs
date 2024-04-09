using UnityEngine;

public class LampTracker : MonoBehaviour
{
    public GameObject[] lamps;

    public void CheckOnLamps(Objective objective)
    {
        int inactiveLamps = 0;

        for (int i = 0; i <= lamps.Length - 1; i++)
        {
            if (lamps[i].activeSelf == false)
            {
                inactiveLamps++;
            }
        }

        if (inactiveLamps >= lamps.Length)
        {
            objective.CompleteObjective();
        }
    }
}
