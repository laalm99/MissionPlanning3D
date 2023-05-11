using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Animation : MonoBehaviour
    {
        [SerializeField] Animator _soldierAnimator;
        // Start is called before the first frame update
        void Start()
        {
            _soldierAnimator.Play("Run");
        }


    }


