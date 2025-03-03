using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class UnitHealth : MonoBehaviour
{
    [SerializeField] private Unit _unit;

    protected float _maxHealth;
    protected float ĐurrenHealth;

    protected virtual void OnEnable()
    {
        _maxHealth = _unit.Config.Health;
        ĐurrenHealth = _maxHealth;
    }

    protected virtual void Die() { }
}
