using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaJAgent : Agent
{
    [SerializeField]
    private float tomPosition;
    [SerializeField]
    private float jerryPosition;
    [SerializeField]
    private Transform tomSprite;
    [SerializeField]
    private Transform jerrySprite;


    const int multiplier = 10;


    public override List<float> CollectState()
    {
        List<float> state = new List<float>();
        state.Add(tomPosition);
        state.Add(jerryPosition);
        return state;
    }


    public override void AgentReset()
    {
        jerryPosition = UnityEngine.Random.Range(-1f, 1f);
        tomPosition = 0;

        jerrySprite.position = new Vector3(jerryPosition * multiplier, 0, 0);
        tomSprite.position = Vector3.zero;
    }

    public override void AgentStep(float[] action)
    {
        switch((int)action[0])
        {
            case 0:
                tomPosition -= 0.01f;
                break;
            case 1:
                tomPosition += 0.01f;
                break;
            default:
                return;
        }

        tomSprite.position = new Vector3(tomPosition * multiplier, 0, 0);

        if (tomPosition < -1.2f || tomPosition > 1.2f)
        {
            reward = -1;
            done = true;
            return;
        }

        float difference = Mathf.Abs(jerryPosition - tomPosition);
        if (difference < 0.01f)
        {
            reward = 1;
            done = true;
            return;
        }
    }
}
