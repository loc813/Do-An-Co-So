using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamagedInvincibility : MonoBehaviour
{
    [SerializeField]
    private float _invincibilityDuration;
    private InvinciblityController _invinciblityController;

    private void Awake()
    {
        _invinciblityController = GetComponent<InvinciblityController>();
    }
    public void StartInvincibility()
    {
        _invinciblityController.StartInvinciblity(_invincibilityDuration);
    }
}
