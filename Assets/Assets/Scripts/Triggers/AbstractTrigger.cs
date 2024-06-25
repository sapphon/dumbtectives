using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractTrigger : MonoBehaviour
{
    public Requirement[] requirements;

    protected abstract void doEffects();
    private bool playerFulfillsRequirements(GameObject playerObject)
    {
        foreach (Requirement requirement in requirements)
        {
            if (!requirement.isMetBy(playerObject))
            {
                return false;
            }
        }
        return true;
    }
    
    void OnCollisionEnter(Collision bonk)
    {
        if (bonk.collider.CompareTag("Player"))
        {
            if (playerFulfillsRequirements(bonk.collider.gameObject))
            {
                doEffects();
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

    public bool isMetBy(GameObject playerObject)
    {
        throw new System.NotImplementedException();
    }
}
