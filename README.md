# NavMeshAssignment

**Objective: Create a functioning navmesh surface with an agent that can use it to orient itself to a destination.**
Steps to complete:
1. Download the project and open it. If it's empty, double click on the SampleScene in the Project tab.
2. Attach the Navigation Modifier to the objects found under the Environment. Select in the Inspector whether an object should be "walkable" or not. If you do not see these options, click on the checkbox "Override area".
3. Add a component called "NavigatonCollectSources2D" and click on "Rotate Surface to XY".
4. Bake the NavMesh. Click on the game object called "NavMeshSurface" and check the inspector.
5. Attach a NavMeshAgent component to the WalkingAgent.
6. Open the WalkingAgentScript in the project folder.
7. Complete the script by following the comments.
8. Attach the script to the WalkingAgent.
9. Test play! If the WalkingAgent goes to the target by going around the obstacle, you have succeeded!

**Bonus assignments: these are additional assignments you can do in whichever order you choose.**
1. Create a patrol path for the WalkingAgent. Feel free to add more Nonwalkable obstacles as well.
2. Make it so that the WalkingAgent will go to where you click your cursor.
3. Give the WalkingAgent controls and create a labyrinth for the player to solve.
4. Create moving objstacles that the WalkingAgent will have to orient around. Check: https://docs.unity3d.com/6000.0/Documentation/ScriptReference/AI.NavMeshObstacle.html
5. Add traps to the map and then spawn other agents that will chase the WalkingAgent. Have the traps destroy agents that walk over it (including the WalkingAgent).
