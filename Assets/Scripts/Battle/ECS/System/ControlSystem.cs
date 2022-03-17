using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace ECS
{
    public class ControlSystem:MonoBehaviour
    {
        public PlayerInput playerInput;
        public Vector2Control recordMouse;
        void Update()
        {
            recordMouse = Mouse.current.position;
        }

        public void Start()
        {
            InputAction move = playerInput.currentActionMap.FindAction("Move");
            move.performed += OnMove;
            move.canceled += OnMove;
            InputAction fire = playerInput.currentActionMap.FindAction("Fire");
            fire.performed += OnFire;
            InputAction hold = playerInput.currentActionMap.FindAction("Hold");
            hold.performed += OnHold;
            hold.canceled += OnHold;
        }
        
        public void OnMove(InputAction.CallbackContext context)
        {
            Vector2 v = context.ReadValue<Vector2>();
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                Entity entity = ECSManager.Instance.allEntitis[i];
                if(entity.control == null) continue;
                entity.move.moveX = v.x;
                entity.move.moveY = v.y;
            }
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            for (int i = 0; i < ECSManager.Instance.allEntitis.Count; i++)
            {
                Entity entity = ECSManager.Instance.allEntitis[i];
                if(entity.control == null) continue;
                entity.attack.isAttack = true;
                entity.attack.targetPosition = recordMouse.ReadValue();
            }
        }

        public void OnHold(InputAction.CallbackContext context)
        {
            if(context.phase == InputActionPhase.Canceled)
            {
       
            }
            if(context.phase == InputActionPhase.Performed)
            {
               
            }
        }
    }
}
