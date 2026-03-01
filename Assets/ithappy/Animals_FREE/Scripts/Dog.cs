using UnityEngine;
// Inheritance
public class Dog : Animal
{
    protected override void Awake()
    {
        base.Awake(); // initializes CreaterMover in the parent class

        walkSpeed = 2f;
        runSpeed = 3f;
        maxStamina = 5f;
        currentStamina = maxStamina;
        friendlyName = null;

        mover.ApplyMovementStats(walkSpeed, runSpeed);
    }
    public new string friendlyName
    {
        get => petName;
        set => petName = string.IsNullOrEmpty(value) ? "Lucky" : value;
    }
    public override void Talk()
    {
        Debug.Log($"{friendlyName}: Woof");
    }
}