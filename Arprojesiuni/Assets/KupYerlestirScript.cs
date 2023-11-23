using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupYerlestirScript : MonoBehaviour
{
    private GameObject kup;
    private DuzlemScript halka;
    [SerializeField] private GameObject TV;
    [SerializeField] private GameObject lambader;
    [SerializeField] private GameObject Dolap;


    // Start is called before the first frame update
    void Start()
    {
        halka = FindAnyObjectByType<DuzlemScript>();
        kup.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

    }
    int objene ;
    public void kupYer()
    {
        kup = TV;
        kup.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        yarat(kup);
    }
    public void capYer()
    {
        kup = lambader;
        kup.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        yarat(kup);
    }
    public void DolapYer()
    {
        kup = Dolap;
        kup.transform.localScale = new Vector3(1.5f, 1f, 0.7f);
        yarat(kup);
    }
    public void Cikis()
    {
        Application.Quit();
    }
    GameObject go;

    public void yarat(GameObject yaratilacak)
    {
        GameObject go = Instantiate(yaratilacak, halka.transform.position, halka.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
