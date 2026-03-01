using UnityEngine;
public class Animal : MonoBehaviour
{
    // Protected fields (encapsulation)
    protected float walkSpeed;
    protected float runSpeed;
    protected float maxStamina;
    protected float currentStamina;
    protected string petName;
    // Public property with protected setter
    public string Name
    {
        get => petName;
        protected set => petName = value;
    }
    // Virtual methods (abstraction + polymorphism)
    public virtual void Stop()
    {
        Debug.Log($"{Name} stopped.");
    }
    public virtual void Walk()
    {
        Debug.Log($"{Name} is walking at speed {walkSpeed}.");
    }
    public virtual void Run()
    {
        if (currentStamina > 0)
        {
            Debug.Log($"{Name} is running at speed {runSpeed}.");
            currentStamina--;
        }
        else
        {
            Debug.Log($"{Name} is too tired to run.");
        }
    }
    public virtual void Talk()
    {
        Debug.Log($"{Name} makes a sound.");
    }
}