using UnityEngine;
// Inheritance
public class Cat : Animal
{
    protected override void Awake()
    {
        base.Awake(); // initializes CreaterMover in the parent class

        walkSpeed = 2f;
        runSpeed = 4f;
        maxStamina = 3f;
        currentStamina = maxStamina;
        friendlyName = null; // triggers setter override

        mover.ApplyMovementStats(walkSpeed, runSpeed);

    }
    // Override name setter behavior
    
    public new string friendlyName
    {
        get => petName;
        set => petName = string.IsNullOrEmpty(value) ? "Fluffy" : value;
    }
    public override void Talk()
    {
        Debug.Log($"{friendlyName}: Meow");
    }
}