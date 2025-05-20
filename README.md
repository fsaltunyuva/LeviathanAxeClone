# LeviathanAxeClone
A Unity project to clone the Leviathan Axe's physical behaviour in God of War.

## Some Things I Learned
- I do not know why, but Unity decided to set the default value for [Rigidbody.maxAngularVelocity](https://docs.unity3d.com/ScriptReference/Rigidbody-maxAngularVelocity.html) to 50 in Unity 6. However, it is set to 7 in Unity 2022. It may be related to all other changes made to the physics system and the renewed physics API of Unity. Since I began this project on Unity 6, it was painful to transfer the project to Unity 2022 because the [torqueMultiplier variable on AxeThrower.cs](https://github.com/fsaltunyuva/LeviathanAxeClone/blob/main/Assets/Scripts/AxeThrower.cs) was not reflecting any changes on its magnitude.
- Use of [Vector3.Slerp](https://docs.unity3d.com/6000.1/Documentation/ScriptReference/Vector3.Slerp.html) is suited for this kind of callback animation of the axe. However, Slerp decides the axis that movement will occur according to the points, so only Slerping X and Z axes and Lerping Y axis separately give the intended result, as in God of War (calling back horizontally).

## Used Assets
- [Kratos by sxnneh on Sketchfab](https://sketchfab.com/3d-models/kratos-low-poly-2df398e721ad44e68d594f4769ce7a3e)
- [Fire Axe by Jusai on Sketchfab](https://sketchfab.com/3d-models/fire-axe-f3fc3193e2514c14b21f90191dac2aa4)
