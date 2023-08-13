using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreate : MonoBehaviour
{
    [SerializeField]
    public GameObject MapObject = null ;


    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateMap();
    }

    private void CreateMap()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject map = Instantiate(MapObject, this.transform, true);

            Vector3 position = map.transform.position;
            float posX = position.x;
            
            position.Set(posX + i,position.y,position.z);

            map.transform.SetPositionAndRotation(position,map.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
