using UnityEngine;

public class PatrolCommand : IPatrolCommand
{
    public Vector3 From => throw new System.NotImplementedException();

    public Vector3 To => throw new System.NotImplementedException();
    public Vector3 Position { get; }
    public Vector3 GroundClick { get; }
    public PatrolCommand(Vector3 position, Vector3 groundClick)
    {
        Position = position;
        GroundClick = groundClick;
    }
}