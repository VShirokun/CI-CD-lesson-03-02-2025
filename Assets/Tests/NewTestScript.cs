using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class NewTestScript
{
    // Тест на движение игрока вправо
    [UnityTest]
    public IEnumerator WhenMoveRightIsCalled_PlayerShouldMoveRight()
    {
        // Arrange
        GameObject player = new GameObject("Player");
        PlayerController playerController = player.AddComponent<PlayerController>();
        Vector3 initialPosition = Vector3.zero;
        player.transform.position = initialPosition;
        
        // Act
        playerController.MoveRight();
        
        // В режиме EditMode используем null вместо WaitForFixedUpdate
        yield return null;
        
        // Assert
        Assert.Greater(player.transform.position.x, initialPosition.x, "Player should move right when MoveRight is called");
    }
}
