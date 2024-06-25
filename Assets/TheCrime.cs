using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class TheCrime : MonoBehaviour
{
    public Requirement[] requirements;
    public bool isDid = false;
    void OnCollisionEnter(Collision bonk)
    {
        if (bonk.collider.CompareTag("Player"))
        {
            if (playerFulfillsRequirements(bonk.collider.gameObject))
            {
                doTheCrime();
            }
            else
            {
                printRequirements();
            }
        }
    }

    private void printRequirements()
    {
        string requirementsString = "To commit the crime you need:\r\n";
        foreach (Requirement req in requirements)
        {
            requirementsString += req.ToString() + "\r\n";
        }
        Debug.Log(requirementsString);
    }

    private void doTheCrime()
    {
        Debug.Log("You did the dirty deed! Time to leave.");
        this.isDid = true;
    }

    private bool playerFulfillsRequirements(GameObject playerObject)
    {
        throw new System.NotImplementedException();
    }
}

public class Requirement
{
    public string requirementName { get; set; }
    
    public Requirement(string requirementName)
    {
        this.requirementName = requirementName;
    }

    public override string ToString()
    {
        return this.requirementName;
    }
}
