using SpaceJet.PlayerInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceJet.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementData movementData;
        [SerializeField] private AbstractInputData inputdata;
        Rigidbody2D rb;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            rb.velocity = new Vector2(inputdata.Horizontal * movementData.HorizontalMovementSpeed, 
                inputdata.Vertical * movementData.VerticalMovementSpeed);
        }
    }
}