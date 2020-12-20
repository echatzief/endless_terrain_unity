using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> roads;
    private float offset=4000f;
    void Start()
    {
        if(roads !=null && roads.Count > 0){
            //roads = roads.OrderBy(r=>r.transform.position.z).ToList();
            roads = roads.OrderBy(r=> r.transform.position.x).ToList();
        }
    }

    public void MoveRoad(){
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newX = roads[roads.Count - 1].transform.position.x + offset;
        moveRoad.transform.position = new Vector3(newX,0,-120f);
        roads.Add(moveRoad);
    }
}
