using UnityEngine;
public class Chicken : Animal
{
    private void Awake()
    {
        walkSpeed = 1f;
        runSpeed = 2f;
        maxStamina = 2f;
        currentStamina = maxStamina;
        Name = null;
    }
    public new string Name
    {
        get => name;
        protected set => name = value ?? "Charles";
    }
    public override void Talk()
    {
        Debug.Log($"{Name}: Cluck");
    }
}