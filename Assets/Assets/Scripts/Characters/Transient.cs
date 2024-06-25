using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transient : Character
{
    void Awake()
    {
        this.advantageDescription = "Much less likely to be remembered - by everyone - but there is always a chance.";
    }
}
