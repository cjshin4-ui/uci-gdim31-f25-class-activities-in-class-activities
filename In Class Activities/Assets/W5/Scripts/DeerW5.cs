using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5 : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    [SerializeField] private NavMeshAgent deer;
    [SerializeField] private GameObject mush;
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform target;
    
    public void moveDeer()
    {
        nav.SetDestination(target.position);
    }
    public void Start()
    {
        target.position = mush.transform.position;
        nav = deer.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //Debug.Log(target);
        moveDeer();
    }
}