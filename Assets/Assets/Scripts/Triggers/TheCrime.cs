using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class TheCrime : AbstractTrigger
{
    public bool isDid = false;

    protected override void doEffects()
    {
        doTheCrime();
    }

    private void doTheCrime()
    {
        Debug.Log("You did the dirty deed! Time to leave.");
        this.isDid = true;
    }
}
