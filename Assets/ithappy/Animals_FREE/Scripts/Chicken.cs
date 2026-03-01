using UnityEngine;
// Inheritance
public class Chicken : Animal
{
    protected override void Awake()
    {
        base.Awake(); // initializes CreaterMover in the parent class

        walkSpeed = 1f;
        runSpeed = 2f;
        maxStamina = 2f;
        currentStamina = maxStamina;
        friendlyName = null;

        mover.ApplyMovementStats(walkSpeed, runSpeed);
    }
    public new string friendlyName
    {
        get => petName;
        set => petName = string.IsNullOrEmpty(value) ? "Charles" : value;
    }
    public override void Talk()
    {
        Debug.Log($"{friendlyName}: Cluck");
    }
}