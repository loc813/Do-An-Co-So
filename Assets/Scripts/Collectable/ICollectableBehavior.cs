using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectableBehavior 
{
    void OnCollected(GameObject player);
}
