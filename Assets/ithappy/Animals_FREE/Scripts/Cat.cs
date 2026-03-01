using UnityEngine;
public class Cat : Animal
{
    protected override void Awake()
    {
        base.Awake(); // initializes CreaterMover in the parent class

        walkSpeed = 2f;
        runSpeed = 4f;
        maxStamina = 3f;
        currentStamina = maxStamina;
        Name = null; // triggers setter override

        mover.ApplyMovementStats(walkSpeed, runSpeed);

    }
    // Override name setter behavior
    
    public new string Name
    {
        get => petName;
        protected set => petName = value ?? "Fluffy";
    }
    public override void Talk()
    {
        Debug.Log($"{Name}: Meow");
    }
}