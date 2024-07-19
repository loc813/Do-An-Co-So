using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InvinciblityController : MonoBehaviour
{
     private HealthController _healthController;

    private void Awake()
    {
        _healthController = GetComponent<HealthController>();
    }

    public void StartInvinciblity(float invinciblityDuration)
    {
        StartCoroutine(InvinciblityCoroutine(invinciblityDuration));
    }

    private IEnumerator InvinciblityCoroutine(float invinciblityDuration)
    {
        _healthController.IsInvincible = true;
        yield return new WaitForSeconds(invinciblityDuration);
        _healthController.IsInvincible = false;
    }
}
