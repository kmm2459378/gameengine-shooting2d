using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{   public GameObject EnemyAPrehab;
    public GameObject spearPrehab;
    public Button AttackButton;
    public Vector3 mousePos, worldPos, beforeMousePos;
    //Clamp関数
    private float _minX = -2;
    private float _maxX = 2;
    private float _minY = -3;
    private float _maxY = 5;
    //1度だけ動かす
    private bool hasMovedOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        
        Application.targetFrameRate = 60;
        //アタック
        AttackButton.onClick.AddListener(TouchBeem);
    }

    // Update is called once per frame
    void Update()
    {   

        var pos1 = transform.position;
        pos1.x = Mathf.Clamp(pos1.x, _minX, _maxX);
        transform.position = pos1;
        var pos2 = transform.position;
        pos2.y = Mathf.Clamp(pos2.y, _minY, _maxY);
        transform.position = pos2;
        //GetMouseButtonを1個しか反応しなくなる

        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null)
            return;
        if (Input.GetMouseButton(0))
        {
            Instantiate(spearPrehab, transform.position, Quaternion.identity);
            Controller();
            Debug.Log("a");
        }

    }    
         
       
     

    //ビーム
    public void TouchBeem()
    {  
           Instantiate(spearPrehab, transform.position, Quaternion.identity);
           Debug.Log("a");
    }

    public void Controller()
    {
        
          
          mousePos = Input.mousePosition;
          worldPos = Camera.main.ScreenToWorldPoint( new Vector3(mousePos.x, mousePos.y, 10.0f));
          //1度だけ動かす
          if(Input.GetMouseButton(0) && !hasMovedOnce)
        {
            transform.position = worldPos;
            hasMovedOnce = true;
        }

        float distance = 1.3f;
        if (Vector3.Distance(worldPos, beforeMousePos) < distance) 
        {
          transform.position = worldPos;
          beforeMousePos = transform.position;
        }
          
        Debug.Log($"beforeMousePos: {beforeMousePos}, World Position: {worldPos}");
          
         
        
    }
}
    
