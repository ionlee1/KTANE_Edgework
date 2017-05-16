using UnityEngine;
using System.Collections;

public class ExampleNeedyModule : MonoBehaviour
{
    public KMSelectable[] Buttons;
	public TextMesh[] Labels;
	public TextMesh DisplayText;

    void Awake()
    {
        GetComponent<KMNeedyModule>().OnNeedyActivation += OnNeedyActivation;
        GetComponent<KMNeedyModule>().OnNeedyDeactivation += OnNeedyDeactivation;
        GetComponent<KMNeedyModule>().OnTimerExpired += OnTimerExpired;
    }

    protected bool Solve()
    {
        GetComponent<KMNeedyModule>().OnPass();

        return false;
    }

    protected void OnNeedyActivation()
    {

    }

    protected void OnNeedyDeactivation()
    {

    }

    protected void OnTimerExpired()
    {
        GetComponent<KMNeedyModule>().OnStrike();
    }

    protected bool AddTime()
    {
        float time = GetComponent<KMNeedyModule>().GetNeedyTimeRemaining();
        if (time > 0)
        {
            GetComponent<KMNeedyModule>().SetNeedyTimeRemaining(time + 5f);
        }

        return false;
    }
}