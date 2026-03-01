using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private bool hasAnyoneWon = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal") && hasAnyoneWon == false)
        {
            Debug.Log(other.gameObject.name.ToString() + " has won the race!");
            hasAnyoneWon = true;
        }
    }
}
