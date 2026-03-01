using ithappy.Animals_FREE;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject chicken;
    private Animal chickenAnimal;
    private CreatureMover chickenMover;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chickenAnimal = chicken.GetComponent<Animal>();
        chickenMover = chicken.GetComponent<CreatureMover>();

        chickenAnimal.Talk();
    }

    // Update is called once per frame
    void Update()
    {
        if (chickenAnimal.Stamina > 0)
        {
            chickenAnimal.Run();
            //Debug.Log("Is running, stamina left" + chickenAnimal.Stamina);
        }
        else
        {
            chickenAnimal.Walk();
        }
    }
}
