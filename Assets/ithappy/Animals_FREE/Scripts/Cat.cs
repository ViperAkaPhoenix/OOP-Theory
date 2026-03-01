using UnityEngine;
public class Cat : Animal
{
    private void Awake()
    {
        walkSpeed = 2f;
        runSpeed = 4f;
        maxStamina = 3f;
        currentStamina = maxStamina;
        Name = null; // triggers setter override
                     
    }
    // Override name setter behavior
    
    public new string Name
    {
        get => petName;
        protected set => petName = value ?? "Flully";
    }
    public override void Talk()
    {
        Debug.Log($"{Name}: Meow");
    }
}