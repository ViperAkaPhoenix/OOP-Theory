using ithappy.Animals_FREE;
using UnityEngine;
public class Animal : MonoBehaviour
{
    // Protected fields (encapsulation)
    protected float walkSpeed;
    protected float runSpeed;
    protected float maxStamina;
    protected float currentStamina;
    protected string petName;

    // Added for movement system integration with CreatureMover that came with the asset
    protected CreatureMover mover;

    // Create a virtual Awake class. Ensure to call base.Awake() in each of the child classes to retain this behaviur

    protected virtual void Awake()
    {
        mover = GetComponent<CreatureMover>();
    }

    // Public property with protected setter
    public string Name
    {
        get => petName;
        protected set => petName = value;
    }

    public float Stamina
    {
        get => currentStamina;
    }
    // Virtual methods (abstraction + polymorphism)
    public virtual void Stop()
    {
        mover.SetInput(
            axis: Vector2.zero,
            target: transform.position + transform.forward,
            isRun: false,
            isJump: false
            );
        
        Debug.Log($"{Name} stopped.");
    }
    public virtual void Walk()
    {
        mover.SetInput(
            axis: new Vector2(0, 1),
            target: transform.position + transform.forward,
            isRun: false,
            isJump: false
            );

        //Debug.Log($"{Name} is walking at speed {walkSpeed}.");
    }
    public virtual void Run()
    {
        if(currentStamina > 0)
        {
            mover.SetInput(
                axis: new Vector2(0, 1),
                target: transform.position + transform.forward,
                isRun: true,
                isJump: false
                );
            
            currentStamina = currentStamina - 0.01f;
            Debug.Log($"{Name} is running, stamina left: " + currentStamina);
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