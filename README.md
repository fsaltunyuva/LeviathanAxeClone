# LeviathanAxeClone
A Unity project to clone the Leviathan Axe's physical behaviour in God of War.

## Some Things I Learned
- I do not know why, but Unity decided to set the default value for [Rigidbody.maxAngularVelocity](https://docs.unity3d.com/ScriptReference/Rigidbody-maxAngularVelocity.html) to 50 in Unity 6. However, it is set to 7 in Unity 2022. It may be related to all other changes made to the physics system and the renewed physics API of Unity. Since I began this project on Unity 6, it was painful to transfer the project to Unity 2022 because the [torqueMultiplier variable on AxeThrower.cs](https://github.com/fsaltunyuva/LeviathanAxeClone/blob/main/Assets/Scripts/AxeThrower.cs) was not reflecting any changes on its magnitude.
