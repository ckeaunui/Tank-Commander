using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObj : MonoBehaviour
{
    // Start is called before the first frame update

    public List<int> objItems = new List<int>();

    public void Collect(int id){

        objItems.Add(id);

    }
}
