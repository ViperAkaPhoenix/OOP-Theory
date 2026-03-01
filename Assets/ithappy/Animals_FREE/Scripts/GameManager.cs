using ithappy.Animals_FREE;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject chicken;
    private Animal chickenAnimal;

    public GameObject dog;
    private Animal dogAnimal;

    public GameObject cat;
    private Animal catAnimal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        chicken.GetComponent<Chicken>().friendlyName = GlobalInfo.Instance.chickenName;
        chickenAnimal = chicken.GetComponent<Animal>();
        chickenAnimal.Talk();

        dog.GetComponent<Dog>().friendlyName = GlobalInfo.Instance.dogName;
        dogAnimal = dog.GetComponent<Animal>();
        dogAnimal.Talk();

        cat.GetComponent<Cat>().friendlyName = GlobalInfo.Instance.catName;
        catAnimal = cat.GetComponent<Animal>();
        catAnimal.Talk();
    }

    // Update is called once per frame
    void Update()
    {
        if (chickenAnimal.Stamina > 0)
        {
            chickenAnimal.Run();
        }
        else
        {
            chickenAnimal.Walk();
        }

        if (dogAnimal.Stamina > 0)
        {
            dogAnimal.Run();
        }
        else
        {
            dogAnimal.Walk();
        }

        if (catAnimal.Stamina > 0)
        {
            catAnimal.Run();
        }
        else
        {
            catAnimal.Walk();
        }
    }
}
