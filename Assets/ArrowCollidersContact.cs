using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollidersContact : Interactable
{
    public GameObject parentObject;
    public PolygonCollider2D polyCollider2D;
    public Mesh mesh;
    public MeshCollider currentMeshCollider;
    public bool createNewMesh;
    public bool firstLoad = true;

    void Update()
    {
        if (createNewMesh)
        {
            Debug.Log("Mesh Created");
            this.gameObject.AddComponent<MeshCollider>();
            this.gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
            createNewMesh = false;
        }
        else if (createNewMesh == false && firstLoad == true)
        {
            Debug.Log("Awake");
            currentMeshCollider = new MeshCollider();
            mesh = gameObject.GetComponent<PolygonCollider2D>().CreateMesh(true, true);
            Destroy(gameObject.GetComponent<PolygonCollider2D>());
            createNewMesh = true;
            firstLoad = false;
        }
        
    }

    public override void Interact()
    {
        parentObject.transform.parent.GetComponent<ArrowMovement>().Interact();
    }
}
