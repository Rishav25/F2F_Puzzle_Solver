using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Manager : MonoBehaviour
{

    public GameObject Congrats,part1,part2,part3,part4,part5,part1Black,part2Black,part3Black,part4Black,part5Black;
    bool part1Correct,part2Correct,part3Correct,part4Correct,part5Correct;
    Vector3 part1InitialPosition, part2InitialPosition, part3InitialPosition, part4InitialPosition,part5InitialPosition;

    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip hugeSuccess;
    IEnumerator SmoothTranslation(GameObject src, Vector3 target, float speed)
    {
        while (src.transform.position != target) {
            src.transform.position = Vector3.Lerp(src.transform.position, target, Time.deltaTime * speed);
            yield return null;
        }
    }

    public bool Check()
    {
        if(part1Correct && part2Correct && part3Correct && part4Correct && part5Correct)
            return true;
        else
            return false;
    }
    void Start()
    {
        part1InitialPosition = part1.transform.position;
        part2InitialPosition = part2.transform.position;
        part3InitialPosition = part3.transform.position;
        part4InitialPosition = part4.transform.position;
        part5InitialPosition = part5.transform.position;
    }

    public void DragPart1() {
        StopAllCoroutines();
        part1.transform.position = Input.mousePosition;
    }

    public void DragPart2() {
        StopAllCoroutines();
        part2.transform.position = Input.mousePosition; 
    }

    public void DragPart3() {
        StopAllCoroutines();
        part3.transform.position = Input.mousePosition;
    }

    public void DragPart4(){
        StopAllCoroutines();
        part4.transform.position = Input.mousePosition;
    }

    public void DragPart5(){
        StopAllCoroutines();
        part5.transform.position = Input.mousePosition;
    }

    public void DropPart1()
    {
        float Distance = Vector3.Distance(part1.transform.position, part1Black.transform.position);
        if(Distance < 50)
        {
            part1.transform.position = part1Black.transform.position;
            Vector3 rescale = part1.transform.localScale;
            rescale.x = 2;
            rescale.y = 2;
            part1.transform.localScale = rescale;
            source.clip = correct;
            source.Play();
            part1Correct = true;
        }
        else
        {
            StartCoroutine(SmoothTranslation(part1, part1InitialPosition, 7.5f));
            Vector3 rescale = part1.transform.localScale;
            rescale.x = 1;
            rescale.y = 1;
            part1.transform.localScale = rescale;
            source.clip = incorrect;
            source.Play();
            part1Correct = false;
        }
    }

    public void DropPart2()
    {
        float Distance = Vector3.Distance(part2.transform.position, part2Black.transform.position);
        if (Distance < 50)
        {
            part2.transform.position = part2Black.transform.position;
            Vector3 rescale = part2.transform.localScale;
            rescale.x = 2;
            rescale.y = 2;
            part2.transform.localScale = rescale;
            source.clip = correct;
            source.Play();
            part2Correct = true;
        }
        else
        {
            StartCoroutine(SmoothTranslation(part2, part2InitialPosition, 7.5f));
            Vector3 rescale = part2.transform.localScale;
            rescale.x = 1;
            rescale.y = 1;
            part2.transform.localScale = rescale;
            source.clip = incorrect;
            source.Play();
            part2Correct = false;
        }
    }
    public void DropPart3()
    {
        float Distance = Vector3.Distance(part3.transform.position, part3Black.transform.position);
        if (Distance < 50)
        {
            part3.transform.position = part3Black.transform.position;
            Vector3 rescale = part3.transform.localScale;
            rescale.x = 2;
            rescale.y = 2;
            part3.transform.localScale = rescale;
            source.clip = correct;
            source.Play();
            part3Correct = true;
        }
        else
        {
            StartCoroutine(SmoothTranslation(part3, part3InitialPosition, 7.5f));
            Vector3 rescale = part3.transform.localScale;
            rescale.x = 1;
            rescale.y = 1;
            part3.transform.localScale = rescale;
            source.clip = incorrect;
            source.Play();
            part3Correct = false;   
        }
    }
    public void DropPart4()
    {
        float Distance = Vector3.Distance(part4.transform.position, part4Black.transform.position);
        if (Distance < 50)
        {
            part4.transform.position = part4Black.transform.position;
            Vector3 rescale = part4.transform.localScale;
            rescale.x = 2;
            rescale.y = 2;
            part4.transform.localScale = rescale;
            source.clip = correct;
            source.Play();
            part4Correct = true;
        }
        else
        {
            StartCoroutine(SmoothTranslation(part4, part4InitialPosition, 7.5f));
            Vector3 rescale = part4.transform.localScale;
            rescale.x = 1;
            rescale.y = 1;
            part4.transform.localScale = rescale;
            source.clip = incorrect;
            source.Play();
            part4Correct = false;
        }
    }

    public void DropPart5()
    {
        float Distance = Vector3.Distance(part5.transform.position, part5Black.transform.position);
        if (Distance < 50)
        {
            part5.transform.position = part5Black.transform.position;
            Vector3 rescale = part5.transform.localScale;
            rescale.x = 2;
            rescale.y = 2;
            part5.transform.localScale = rescale;
            source.clip = correct;
            source.Play();
            part5Correct = true;
        }
        else
        {
            StartCoroutine(SmoothTranslation(part5, part5InitialPosition, 7.5f));
            Vector3 rescale = part5.transform.localScale;
            rescale.x = 1;
            rescale.y = 1;
            part5.transform.localScale = rescale;
            source.clip = incorrect;
            source.Play();
            part5Correct = false;
        }
    }

    void Update()
    {
        if (Check())
        {
            Congrats.SetActive(true);
        }
    }
}
