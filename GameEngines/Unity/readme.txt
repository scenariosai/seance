Introduction:
https://blogs.unity3d.com/2017/09/19/introducing-unity-machine-learning-agents/

Git repo:
https://github.com/Unity-Technologies/ml-agents

Environment setup:
https://unity3d.college/2017/10/25/machine-learning-in-unity3d-setting-up-the-environment-tensorflow-for-agentml-on-windows-10/

Getting started with the balance ball example
https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Getting-Started-with-Balance-Ball.md


YouTube Starter videos:
Unity3D Machine Learning Setup for ML-Agents on Windows 10 with Tensorflow: https://www.youtube.com/watch?v=qxicgknzUG8
Creating a custom Unity3D Machine Learning Agent: https://www.youtube.com/watch?v=61_FtB1PhaM
Unity3D Machine Learning - Building and Training the First Example: https://www.youtube.com/watch?v=-YWts_GlHCY




To use the tom and jerry demo:
First: copy Ml-Agents folder into the assets folder (I did not include this, because its 800Mb).
In this Ml-Agents folder you only need the following directories: Editor, Plugins, Scripts.
Delete the others

Open the project in Unity
At the bottom of the screen you see the assets.
In the TomAndJerry folder there is a c# file. This contains the TaJAgent class which is the controller of this learning.

He you can see two other files:
tom_and_jerry.bytes
tom_and_jerry_full.bytes
These are the learned results. You can use them in the Unity editor.
In the editor select: TomAndJerryBrain object (this is the child of the TomAndJerryAcademy)
At the right side set Brain type to internal (should be this by default)
Below this, there is the "Graph Model" settings.
Grab one of the files above into this field.
Run.

