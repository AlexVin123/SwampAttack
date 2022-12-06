using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTransiition : Transition
{
    [SerializeField] private float _transitonRange;
    [SerializeField] private float _rangetSpreat;

    private void Start()
    {
        _transitonRange += Random.Range(-_rangetSpreat, _rangetSpreat);
    }

    private void Update()
    {
        if (Target != null)
        {
            if (Vector2.Distance(transform.position, Target.transform.position) < _transitonRange)
            {
                NeedTransit = true;
            }
        }
    }
}

