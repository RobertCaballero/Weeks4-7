using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Zoo : MonoBehaviour
{


    public List<Animal> animals = new List <Animal>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animals.Add("snake");
        //animals.Remove("Gorilla");
        ////animals.Clear();

        //string selectedanimal = animals[3];
        //Debug.Log(selectedanimal);

        //for (int i = 0; i < animals.Count; i++)
        //{
        //    string currentanimal = animals[i];
        //    Debug.Log(currentanimal);
        //}


        //int x = 0;
        //float f = 1f;
        //string s = "";


        Animal newCat = new Animal("cat", "tiger", 5);
        animals.Add(newCat);

        for (int i = 0; i < animals.Count; i++)
        {
            Debug.Log(animals[i].name);
        }


        //Constructor: Method that stablishes the initial values of more complicated data types
        //(structs,classes,collections (lists)
        Vector3 v = new Vector3(0, 0, 0);
        Color c = new Color(0.5f, 0.5f, 0.5f);
        Vector3 v1 = Vector3.zero;


        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Animal
{
    public string type;
    public string name;
    public int age;
    public Color colour;
    public float size;
    public string sex;

    public Animal(string inType, string inName, int inAge)
    {
        type = inType;
        name = inName;
        age = inAge;

    }


}