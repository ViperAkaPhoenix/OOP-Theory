using UnityEngine;
public class Dog : Animal
{
    private void Awake()
    {
        walkSpeed = 2f;
        runSpeed = 3f;
        maxStamina = 5f;
        currentStamina = maxStamina;
        Name = null;
    }
    public new string Name
    {
        get => name;
        protected set => name = value ?? "Lucky";
    }
    public override void Talk()
    {
        Debug.Log($"{Name}: Woof");
    }
}