using UnityEngine;

public class Player : Character
{
    private string _horizontalAxis = "Horizontal";
    private string _verticalAxis = "Vertical";

    private KeyCode _keyForward = KeyCode.W;
    private KeyCode _keyBack = KeyCode.S;
    private KeyCode _keyLeft = KeyCode.A;
    private KeyCode _keyRight = KeyCode.D;
    private KeyCode _keyUseArtifact = KeyCode.F;

    private void Update()
    {
        if (Input.GetKeyDown(_keyUseArtifact) && Artifact != null)
        {
            UseArtifact();
        }
    }

    private void FixedUpdate()
    {
        if (GetInput())
        {
            Move();
        }
        else
        {
            _rigidbody.velocity = Vector3.zero;
        }
    }

    private protected override void UseArtifact()
    {
        _artifact.UseArtifact(this);
        _artifact = null;
    }

    private void Move()
    {
        float verticalDirection = Input.GetAxisRaw(_verticalAxis);
        float horizontalDirection = Input.GetAxisRaw(_horizontalAxis);

        Vector3 input = new Vector3(horizontalDirection, 0, verticalDirection);

        _movement.MovePhysics(_rigidbody, _speed, input);
        _movement.Rotator(this.transform, _speedRotation, input.normalized);
    }

    private bool GetInput() => Input.GetKey(_keyForward) || Input.GetKey(_keyBack) || Input.GetKey(_keyLeft) || Input.GetKey(_keyRight);
}
